using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Linq;
using System.Threading;
using Microsoft.Win32;
using System.Diagnostics;
using System.Net;
using IWshRuntimeLibrary;

namespace testOne
{
    public partial class Form1 : Form
    {
        string sourceItem = string.Empty;
        string saveFileName = string.Empty; //Create empty string
        string JSON_FILTER = @"JSON Files (*.json)|*.json"; //set JSON file
        UserSettings userSettings = new UserSettings(); //add updated settings 
        string settingsString = ""; //Create empty string for settings
        List<UserSettings> newSettings = new List<UserSettings>(); //Hold new settings values
        List<UserSettings> webBrowserItems = new List<UserSettings>(); //Hold we browser Items
        List<UserSettings> taskbarItems =   new List<UserSettings>(); //Hold taskbar Items
        List<UserSettings> startMenuItems = new List<UserSettings>(); //Hold start menu Items
        List<UserSettings> networkItems = new List<UserSettings>(); //Hold network Items 
        List<UserSettings> applicationItems = new List<UserSettings>(); //Hold application items
        List<UserSettings> uploadItems = new List<UserSettings>(); //Hold items to be uploaded.
        
        //Main
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(startForm)); //Create thread
            t.Start(); //Start thread
            Thread.Sleep(5000); //Wait 
            InitializeComponent();
            t.Abort(); //End thread
        }

        //Start the Splash screen
        public void startForm()
        {
            Application.Run(new Splash()); //Run splash
        }
        
        //taskbar button section (gather taskbar items)
        private void taskbar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //clear items in listview
            listView1.Groups.Clear(); //clear group headers
            sourceItem = "taskbar"; //Set current source item
            Apply.Visible = true;//display the apply button
            var di = new DirectoryInfo(@"C:\Users\Admin\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar");
            foreach (FileInfo fi in di.GetFiles())
            {
                String ext = fi.Extension;
                ListViewItem item = new ListViewItem(); //new listview item
                imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName)); //Listview item image
                int index = imageList1.Images.Keys.IndexOf(ext);
                item.Text = fi.Name; //displays name in second column 
                item.ImageIndex = index; //display the system icon
                item.SubItems.Add(fi.FullName);//Display location name in the third column
                foreach (var obj in taskbarItems) //loop through each item in taskbarItems
                {
                    if (fi.Name == obj.Name) //If taskbarItems saved item equals to files in folder
                    {
                        item.Checked = true;  //Save items as checked
                    }
                }
                listView1.Items.Add(item); //Display all the items in table View
            }
        }

        //web Browser Buttons
        private void webBrowser_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //Clear items in listview
            listView1.Groups.Clear(); //cleat group headers in listview
            sourceItem = "webBrowser"; //Set current source item
            Apply.Visible = true;//display the apply button
            var di = new DirectoryInfo(@"C:\Users\Admin\AppData\Local\Google\Chrome\User Data\Default"); //File path location for web browser bookmarks
            foreach (FileInfo fi in di.GetFiles()) //loop through each file in directory
            {
                String ext = fi.Extension;
                imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName)); //add image to listview
                int index = imageList1.Images.Keys.IndexOf(ext);
                ListViewItem item = new ListViewItem();
                item.Text = fi.Name; //displays name in second column 
                item.ImageIndex = index; //display the system icon
                item.SubItems.Add(fi.FullName);//Display location name in the third column
                foreach (var obj in webBrowserItems) //loop through each item in webBrowserItems
                {
                    if (fi.Name == obj.Name) //If current name equals name in webBrowser items
                    {
                        item.Checked = true; //Check item in listview
                    }
                }
                listView1.Items.Add(item); //Display all the items in table View
            }
        }
        
        //Start menu Button on the side panel
        private void startMenu_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //Clear items
            listView1.Groups.Clear();
            sourceItem = "startMenu";  //Set current source item
            Apply.Visible = true;//display the apply button
            var di = new DirectoryInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs"); //Dirctory location
            foreach (FileInfo fi in di.GetFiles())
            {
                String ext = fi.Extension; 
                imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                int index = imageList1.Images.Keys.IndexOf(ext);
                ListViewItem item = new ListViewItem();
                item.Text = fi.Name; //displays name in second column 
                item.ImageIndex = index; //display the system icon
                item.SubItems.Add(fi.FullName);//Display location name in the third column
                foreach (var obj in startMenuItems) //Check if item is selected
                {
                    if (fi.Name == obj.Name) //if directory name equals items in start menu list
                    {
                        item.Checked = true; //Check items
                    }
                }
                listView1.Items.Add(item); //Display all the items in table View
            }
        }

        //Applications 
        private void Applications_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Groups.Clear();
            sourceItem = "applications"; 
            Apply.Visible = true;//display the apply button
            ListViewItem lvi = new ListViewItem();
            string[] strArrGroups = new string[4] { "Browsers", "Tools", "Communication", "Other" }; //Group Titles
            string[] strTools = new string[4] { "Microsoft Office", "NotePad++", "Github", "Source Tree" }; //tools list
            string[] strCommunication = new string[2] { "Microsoft Teams", "Slack" };//communication list
            string[] strBrowser = new string[3] { "Google Chrome", "Firefox", "Opera" }; //Browser list
            string[] strOther = new string[4] { "Spotify", "Pandora", "Youtube", "Plex" }; //Other List
            var applicationFiles = new DirectoryInfo(@"C:\Users\Admin\AppData\Local\Google\Chrome\User Data\Default"); //Location for items in folder
            for (int i = 0; i < strArrGroups.Length; i++)
            {
                int groupIndex = listView1.Groups.Add(new ListViewGroup(strArrGroups[i], HorizontalAlignment.Left)); //Group Header [i]
                if (strArrGroups[i] == "Tools")//If "tools" 
                {
                    for (int j = 0; j < strTools.Length; j++) //Loop through strTools length
                    {
                        lvi = new ListViewItem(strTools[j]); //new listview item in the strTools list
                        lvi.SubItems.Add("Tool"); //add the subItem "Tool"
                        listView1.Items.Add(lvi); //Print items to listview
                        listView1.Groups[i].Items.Add(lvi);// Add under group header
                        foreach (var obj in applicationItems) //loop through applicationItems
                        {
                            if (strTools[j] == obj.Name) //If current strTool item equals one of the applicationItems
                            {
                                lvi.Checked = true; // Check Box
                            }
                        }
                    }
                }
                else if (strArrGroups[i] == "Browsers")
                {
                    for (int j = 0; j < strBrowser.Length; j++)
                    {
                        lvi = new ListViewItem(strBrowser[j]);
                        lvi.SubItems.Add("Web");
                        listView1.Items.Add(lvi);
                        listView1.Groups[i].Items.Add(lvi);
                        foreach (var obj in applicationItems)
                        {
                            //Console.WriteLine(lvi);
                            if (strBrowser[j] == obj.Name)
                            {
                                lvi.Checked = true;
                            }
                        }
                    }
                }
                else if (strArrGroups[i] == "Communication")
                {
                    for (int j = 0; j < strCommunication.Length; j++)
                    {
                        lvi = new ListViewItem(strCommunication[j]);
                        lvi.SubItems.Add("Communication");
                        listView1.Items.Add(lvi);
                        listView1.Groups[i].Items.Add(lvi);
                        foreach (var obj in applicationItems)
                        {
                            //Console.WriteLine(lvi);
                            if (strCommunication[j] == obj.Name)
                            {
                                lvi.Checked = true;
                            }
                        }
                    }
                }
                else if (strArrGroups[i] == "Other")
                {
                    for (int j = 0; j < strOther.Length; j++)
                    {
                        lvi = new ListViewItem(strOther[j]);
                        lvi.SubItems.Add("Other");
                        listView1.Items.Add(lvi);
                        listView1.Groups[i].Items.Add(lvi);
                        foreach (var obj in applicationItems)
                        {
                            //Console.WriteLine(lvi);
                            if (strOther[j] == obj.Name)
                            {
                                lvi.Checked = true;
                            }
                        }
                    }
                }
                listView1.GridLines = true;
            }
        }

        //Network configs
        private void networks_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            sourceItem = "network"; //Set current source item
            Apply.Visible = true;//display the apply button
            string[] strArrGroups = new string[3] { "Network Drives", "Configs", "Other" }; //Group Titles
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            for (int i = 0; i < strArrGroups.Length; i++) //loop the strArrGroup length
            {
                Console.WriteLine(strArrGroups[i]);
                listView1.Groups.Add(new ListViewGroup(strArrGroups[i], HorizontalAlignment.Left)); //Add strArrGroup header
                foreach (DriveInfo drives in allDrives)//Loop throgh results
                {
                    string[] strArrItems = new string[1] { drives.Name}; //gather array of data
                    ListViewItem lvi = new ListViewItem(strArrItems[0]); //Store array in listview
                    if (strArrGroups[i] == "Network Drives") //only add if source matches group header
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = drives.Name;
                        listView1.Items.Add(item); //Display all the items in table View
                        foreach (var obj in networkItems) //Check if items check
                        {
                            if (drives.Name == obj.Name)
                            {
                                item.Checked = true; //Check Items
                            }
                        }
                    }
                }
            }
        }

        private void bootOptions_Click(object sender, EventArgs e)
        {
            sourceItem = "bootOptions"; //Set current source item
            Apply.Visible = true;//display the apply button
                                 //ability to allow apps to no start on boot up or start on boot up
                                 //Ex: set skype to not start on boot up
            startMenuInstall();
        }

        //System options
        private void deviceOptions_Click(object sender, EventArgs e)
        {
            sourceItem = "deviceOptions";//Set current source item
            Apply.Visible = true;//display the apply button
            //Set resolution
            //set taskbar to display 
            //Set taskbar buttons to never combine
            //Cerner C:Cloud
        }

        //Save specific settings
        private void Apply_Click(object sender, EventArgs e)
        {
            List<UserSettings> newSettingsPlaceholder = new List<UserSettings>(); //Store local placeholder for new settings
            newSettingsPlaceholder.Clear(); //Clear placeholder list
            for (int j = 0; j < listView1.Items.Count; j++) //Loop through listview1 items
            {
                if (listView1.Items[j].Checked == true) //If listview1 items is checked
                {
                    if (sourceItem == "taskbar") //if the saved source item equals taskbar
                    {
                        newSettingsPlaceholder.Add(new UserSettings { Name = listView1.Items[j].Text, Source = "Taskbar", Location = listView1.Items[j].SubItems[1].Text }); //add new taskbar setting to new settings
                        taskbarItems.Clear(); //clear taskbarItems items
                        taskbarItems.AddRange(newSettingsPlaceholder); //add new settings to taskbar items
                    }
                    else if (sourceItem == "startMenu") //If listview1 items is checked
                    {
                        newSettingsPlaceholder.Add(new UserSettings { Name = listView1.Items[j].Text, Source = "Start Menu", Location = listView1.Items[j].SubItems[1].Text }); //add new start menu settings to new settings
                        startMenuItems.Clear(); //clear startmenuItems items
                        startMenuItems.AddRange(newSettingsPlaceholder);//add new settings to start menu items
                    }
                    else if (sourceItem == "webBrowser") //If listview1 items is checked
                    {
                        newSettingsPlaceholder.Add(new UserSettings { Name = listView1.Items[j].Text, Source = "Web Browser", Location = listView1.Items[j].SubItems[1].Text });
                        webBrowserItems.Clear(); //Clear webBrowserItems
                        webBrowserItems.AddRange(newSettingsPlaceholder);//add new settings to webBrowserItems
                    }
                    else if (sourceItem == "network") //If listview1 items is checked
                    {
                        newSettingsPlaceholder.Add(new UserSettings { Name = listView1.Items[j].Text, Source = "Network", Location = listView1.Items[j].Text });
                        networkItems.Clear(); //clear network Items
                        networkItems.AddRange(newSettingsPlaceholder);//add new settings to network Items
                    }
                    else if (sourceItem == "applications") //If listview1 items is checked
                    {
                        newSettingsPlaceholder.Add(new UserSettings { Name = listView1.Items[j].Text, Source = "Applications", Location = "" });
                        applicationItems.Clear();//clear application items
                        applicationItems.AddRange(newSettingsPlaceholder);//add new settings to applicationItems
                    }
                }
            }
        }

        //submit saved data
        private void submit_Click(object sender, EventArgs e)
        {
            if (sourceItem != "loadSettings")
            {
                newSettings.AddRange(webBrowserItems); //Add web browsers settings to new settings to be saved 
                newSettings.AddRange(taskbarItems); //Add taskbar Items to new settings to be saved
                newSettings.AddRange(startMenuItems); //Add startmenu items to new settings to be saved
                newSettings.AddRange(networkItems); //Add network items to new settings to be saved
                newSettings.AddRange(applicationItems); //Add applications items to new setting to be saved
                if (string.IsNullOrWhiteSpace(saveFileName)) //save items
                {
                    SaveAs(); //Run SaveAs() function
                }
                else
                {
                    try
                    {
                        saveFile(saveFileName); // Store the user settings then save them to file
                    }
                    catch (ArgumentNullException ex)
                    {
                        MessageBox.Show(string.Format("An exception was thrown while trying to save the file: {0}", ex.Message));
                    }
                }
                MessageBox.Show("Settings Saved"); //Display popover "Settings saved"
                newSettings.Clear(); //Clear new settings 
            }
            else
            {
                applicationDownload(); //Install applications that have not been installed
                //taskbarInstall(); //Add programs to taskbar
                //bookMarkInstall(); //Add bookmarks to browsers
            }
        }

        //about button clicked on the side panel
        private void loadConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //new openFileDialog
            sourceItem = "loadSettings"; //set current source Item.
            openFileDialog.Filter = JSON_FILTER;
            openFileDialog.Title = "Load settings...";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileName = openFileDialog.FileName; //Name of file
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName)) // Load the settings from the file and apply the settings to the associated fields
                {
                    settingsString = streamReader.ReadToEnd();
                    ApplySettings(settingsString); //Run apply settings function with settingsStrings
                }
            }
            Apply.Visible = false; //Hide apply button 
        }
        
        //Panel for taskbar 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        //Set column parameters
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            const int padding = 15;
            foreach (ColumnHeader clmHeader in listView1.Columns)
            {
                clmHeader.Width = (this.Width - padding) / listView1.Columns.Count;

            }
        }
        //Export config file
        private void actionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //import saved user settings
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //new openFileDialog
            openFileDialog.Filter = JSON_FILTER;
            openFileDialog.Title = "Load settings...";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileName = openFileDialog.FileName; //Name of file
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName)) // Load the settings from the file and apply the settings to the associated fields
                {
                    string settingsString = streamReader.ReadToEnd();
                    ApplySettings(settingsString); //Run ApplySettings function with settingstring
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If a field is empty, notify the user and allow them to decide whether or not to save the settings to file
            // If a file hasn't been set for saving, show the Save As file dialog
            if (string.IsNullOrWhiteSpace(saveFileName))
            {
                SaveAs(); //Run SaveAs() 
            }
            else
            {
                try
                {
                    saveFile(saveFileName);// Store the user settings then save them to file
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(string.Format("An exception was thrown while trying to save the file: {0}", ex.Message));
                }
            }
        }

        //SaveAs all information
        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = JSON_FILTER;
            saveFileDialog.Title = "Save As...";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Store save filename
                saveFileName = saveFileDialog.FileName; //store saveFileName
                saveFile(saveFileName); //run saveFile funtion with saveFileName
            }
            else
            {
                MessageBox.Show("Error saving settings to file", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Save information from the save as function
        private void saveFile(string saveFileName)
        {
            // Serialize the UserSettings object to JSON and get the string representation of the JSON object
            string jsonString = new JavaScriptSerializer().Serialize(newSettings);
            // Save the JSON string to file
            using (StreamWriter streamWriter = new StreamWriter(saveFileName))
            {
                streamWriter.Write(jsonString); //save file to file
            }
        }

        //Display and apply user settings 
        private void ApplySettings(string jsonString)
        {
            listView1.Items.Clear();
            listView1.Groups.Clear();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var records = new JavaScriptSerializer().Deserialize<List<UserSettings>>(jsonString);
            uploadItems = records;
            string[] strArrHeaders = new string[5] { "Taskbar", "Web Browser", "Start Menu", "Applications", "Network" }; //Group Titles
            for (int i = 0; i < strArrHeaders.Length; i++) //loop the strArrGroup length
            {
                listView1.Groups.Add(new ListViewGroup(strArrHeaders[i], HorizontalAlignment.Left)); //Add strArrGroup header
                foreach (var obj in records)//Loop throgh results
                {
                    string[] strArrItems = new string[2] { obj.Name, obj.Location }; //gather array of data
                    ListViewItem lvi = new ListViewItem(strArrItems[0]); //Store array in listview
                    lvi.SubItems.Add(obj.Location);//Display location name in the third column
                    if (obj.Source == strArrHeaders[i]) //only add if source matches group header
                    {
                        listView1.Groups[i].Items.Add(lvi); //Add to group header
                        listView1.Items.Add(lvi); //Add data below header
                        //Console.WriteLine(obj.Name);
                    }
                }
            }
        }

        public class UserSettings
        {
            public string Source;
            public string Name;
            public string Location;
        }
        public class Record
        {
            public UserSettings record;
        }
        //Select all items on page for the menu
        private void selectPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    listView1.Items[i].Checked = true; //check list view items
                }
            }
        }
        //Deselect all items on page for the menu
        private void deselectPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    listView1.Items[i].Checked = false; //deselect all listview items
                }
            }
        }
  
        private void applicationDownload()
        {
            foreach (var obj in uploadItems)
            {
                if (obj.Source == "Applications")
                {
                    DialogResult result = MessageBox.Show(obj.Name + " has not been installed", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (obj.Name)
                    {
                        case "Google Chrome":
                            if (result == DialogResult.Yes)
                            {
                                //code for Yes
                                string URL = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B10EFC3E5-45A8-8EFF-6E74-E8F5FDCA8B88%7D%26lang%3Den%26browser%3D4%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe";
                                downloadFile(URL);
                            }
                            Thread.Sleep(1000);
                            break;
                        case "Firefox":
                            if (result == DialogResult.Yes)
                            {
                                //code for Yes
                                string URL = "https://stubdownloader.cdn.mozilla.net/builds/firefox-stub/en-US/win/f984298bd4943e8787d0af2b92d76a23d15ec52790be28dc2f1b797c6297783b/Firefox%20Installer.exe";
                                downloadFile(URL);
                            }
                            Thread.Sleep(1000);
                            break;
                        case "Opera":
                            if (result == DialogResult.Yes)
                            {
                                //code for Yes
                                string URL = "https://net.geo.opera.com/opera/stable/windows?http_referrer=https://www.google.com/&utm_source=google_via_opera_com&utm_medium=ose&utm_campaign=google_ose_via_opera_com_https&utm_lastpage=opera.com/download&dl_token=67954017";
                                downloadFile(URL);
                            }
                            Thread.Sleep(1000);
                            break;
                        /////////////////////////////////////////////////////////////////////////////
                        case "Slack":
                            if (result == DialogResult.Yes)
                            {
                                //code for Yes
                                string URL = "https://downloads.slack-edge.com/releases_x64/SlackSetup.exe";
                                downloadFile(URL);
                            }
                            Thread.Sleep(1000);
                            break;
                        case "NotePad++":
                            if (result == DialogResult.Yes)
                            {
                                //code for Yes
                                string URL = "https://notepad-plus-plus.org/repository/7.x/7.6/npp.7.6.Installer.exe";
                                downloadFile(URL);
                            }
                            Thread.Sleep(1000);
                            break;
                        case "Github":
                            if (result == DialogResult.Yes)
                            {
                                //code for Yes
                                string URL = "https://desktop.githubusercontent.com/releases/1.5.0-2f0c701f/GitHubDesktopSetup.exe";
                                downloadFile(URL);
                            }
                            break;
                        case "Source Tree":
                            if (result == DialogResult.Yes)
                            {
                                //code for Yes
                                string URL = "https://product-downloads.atlassian.com/software/sourcetree/windows/ga/SourceTreeSetup-3.0.8.exe?_ga=2.28812476.1084820634.1542399255-483359977.1542399255";
                                downloadFile(URL);
                            }
                            break;
                        ////////////////////////////////////////////////////////////////////////////
                        case "Spotify":
                            if (result == DialogResult.Yes)
                            {
                                //code for Yes
                                string URL = "https://download.scdn.co/SpotifySetup.exe";
                                downloadFile(URL);
                            }
                            Thread.Sleep(1000);
                            break;
                    }
                    MessageBox.Show("Downloads should appear on desktop");
                    DialogResult confirmCompletion = MessageBox.Show("Confirm after completion", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (confirmCompletion == DialogResult.Yes)
                    {
                        //code for Yes
                        addBookmarks();
                    };
                }
            }
        }

        private void taskbarInstall()
        {
            foreach (var obj in uploadItems)
            {
                if (obj.Source == "Taskbar")
                {
                    
                }
            }
        }

        private void startMenuInstall()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + @"C:\Program Files (x86)\Google\Chrome\Application"))
            {
                return;
            }
            else
            {
                File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + @"C:\Program Files (x86)\Google\Chrome\Application", true);
            }
        }

        private void downloadFile(string URL)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Change the url by the value you want (a textbox or something else)
            string url = URL;// Get filename from URL
            string filename = getFilename(url);
            using (var client = new WebClient())
            {
                client.DownloadFile(url,desktopPath + "/" + filename);
            }
            string installFile = @desktopPath + "/" + filename; //save install path
            Process.Start(installFile); //start install File process
        }

        private string getFilename(string hreflink)
        {
            Uri uri = new Uri(hreflink); //Get filename 
            string filename = System.IO.Path.GetFileName(uri.LocalPath); //store file name 
            return filename; //return filename
        }

        private void addBookmarks()
        {

        }
    }
}

//https://stackoverflow.com/questions/25932873/add-a-listviewitem-to-multiple-groups - listview groups