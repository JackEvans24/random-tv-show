using AngleSharp;
using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTvShow
{
    public partial class MainForm : Form
    {
        #region Variables

        bool refreshing = false, ready = true;
        Random rnd = new Random();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        string[] timerFolders;

        static string[] videoExtensions = { ".AVI", ".MP4", ".DIVX", ".WMV", ".MKV" };
        static Tuple<string, string>[] onlineCartoons = {
            Tuple.Create("Adventure Time", "adventure-time"),
            Tuple.Create("Aqua Teen Hunger Force", "aqua-teen-hunger-force"),
            Tuple.Create("Archer", "archer"),
            Tuple.Create("Bob's Burgers", "bobs-burgers"),
            Tuple.Create("Creature Comforts", "creature-comforts"),
            Tuple.Create("Ed Edd n Eddy", "ed-edd-n-eddy"),
            Tuple.Create("F is for Family", "f-is-for-family"),
            Tuple.Create("Fairly OddParents", "the-fairly-oddparents"),
            Tuple.Create("Foster's Home for Imaginary Friends", "fosters-home-for-imaginary-friends"),
            Tuple.Create("Futurama",
                "futurama-season-1,futurama-season-2,futurama-season-3,futurama-season-4,futurama-season-5,futurama-season-6,futurama-season-7"),
            Tuple.Create("Gravity Falls", "gravity-falls"),
            Tuple.Create("Johnny Bravo", "johnny-bravo-season-1"),
            Tuple.Create("Looney Tunes", "looney-tunes-golden-collection,looney-tunes-platinum-collection,wile-e-coyote-and-the-road-runner"),
            Tuple.Create("Over The Garden Wall", "over-the-garden-wall"),
            Tuple.Create("Phineas and Ferb", "phineas-and-ferb"),
            Tuple.Create("Regular Show", "regular-show"),
            Tuple.Create("Rick and Morty", "rick-and-morty"),
            Tuple.Create("Samurai Jack", "samurai-jack"),
            Tuple.Create("Scooby Doo", "scooby-doo-where-are-you-1969,the-scooby-doo-show"),
            Tuple.Create("Shaun the Sheep", "shaun-the-sheep"),
            Tuple.Create("South Park",
                "south-park-season-1,south-park-season-2,south-park-season-3,south-park-season-4,south-park-season-5,south-park-season-6,south-park-season-7," +
                "south-park-season-8,south-park-season-9,south-park-season-10,south-park-season-11,south-park-season-12,south-park-season-13,south-park-season-14," +
                "south-park-season-15,south-park-season-16,south-park-season-17,south-park-season-18,south-park-season-19,south-park-season-20,south-park-season-21"),
            Tuple.Create("Space Ghost", "space-ghost,space-ghost-coast-to-coast"),
            Tuple.Create("Spongebob Squarepants", "spongebob-squarepants"),
            Tuple.Create("Steven Universe", "steven-universe"),
            Tuple.Create("The Simpsons (Seasons 1-10)",
                "the-simpsons,the-simpsons-season-7,the-simpsons-season-8,the-simpsons-season-9,the-simpsons-season-10"),
            Tuple.Create("The Simpsons (Seasons 11-15)",
                "the-simpsons-season-11,the-simpsons-season-12,the-simpsons-season-13,the-simpsons-season-14,the-simpsons-season-15"),
            Tuple.Create("The Simpsons (Seasons 16-29)",
                "the-simpsons-season-16,the-simpsons-season-17,the-simpsons-season-18,the-simpsons-season-19,the-simpsons-season-20,the-simpsons-season-21," +
                "the-simpsons-season-22,the-simpsons-season-23,the-simpsons-season-24,the-simpsons-season-25,the-simpsons-season-26,the-simpsons-season-27," +
                "the-simpsons-season-28,the-simpsons-season-29"),
            Tuple.Create("Wacky Races", "wacky-races"),
            Tuple.Create("We Bare Bears", "we-bare-bears"),
            Tuple.Create("What's New, Scooby Doo?", "whats-new-scooby-doo"),

        };

        AppTab currentTab;

        #endregion

        #region Dragging Variables

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        public MainForm()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;

            AppDesignProvider.SetTheme(this, (AppTheme)Properties.Settings.Default.ThemeIndex);
            HardDriveLabel_Click(this.HardDriveLabel, null);

            VersionNumberLabel.Text = "Random TV Show\r\nVersion: " +
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(3);

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.MainDrivePath))
            {
                Properties.Settings.Default.MainDrivePath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                Properties.Settings.Default.Save();
            }

            // On load, load shows from the hard drive
            LoadFromDrive();
        }

        #region Event Handlers

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Shortcut1Path) &&
                keyData == (Keys.Control | Keys.D1) || keyData == (Keys.Control | Keys.NumPad1))
                PickAndPlayVideoFile(Properties.Settings.Default.Shortcut1Path);
            else if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Shortcut2Path) &&
                keyData == (Keys.Control | Keys.D2) || keyData == (Keys.Control | Keys.NumPad2))
                PickAndPlayVideoFile(Properties.Settings.Default.Shortcut2Path);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MinimiseLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HardDriveLabel_Click(object sender, EventArgs e)
        {
            // Change label border & backcolor, and populate list from hard drive
            currentTab = AppTab.HardDrive;
            AppDesignProvider.SetCurrentTab(this, (AppTheme)Properties.Settings.Default.ThemeIndex, currentTab);

            ShowsLayout.Visible = AutoplayButton.Visible = true;
            PlayerLayout.Visible = SettingsLayout.Visible = false;
            Refresh();

            LoadFromDrive();
        }

        private void PlayLabel_Click(object sender, EventArgs e)
        {
            currentTab = AppTab.Player;
            AppDesignProvider.SetCurrentTab(this, (AppTheme)Properties.Settings.Default.ThemeIndex, currentTab);

            PlayerLayout.Visible = true;
            ShowsLayout.Visible = SettingsLayout.Visible = false;
            DriveNotFoundLabel.Visible = RefreshLabel.Visible = AutoplayButton.Visible = false;
        }

        private void OnlineLabel_Click(object sender, EventArgs e)
        {
            // Change label font to border & backcolor, hide refresh labels, and populate list from internal list (onlineCartoons)
            currentTab = AppTab.Online;
            AppDesignProvider.SetCurrentTab(this, (AppTheme)Properties.Settings.Default.ThemeIndex, currentTab);

            ShowsLayout.Visible = true;
            PlayerLayout.Visible = SettingsLayout.Visible = false;
            DriveNotFoundLabel.Visible = RefreshLabel.Visible = AutoplayButton.Visible = false;

            LoadFromOnline();
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            MainDriveTextbox.Text = Properties.Settings.Default.MainDrivePath;
            Shortcut1Textbox.Text = Properties.Settings.Default.Shortcut1Path;
            Shortcut2Textbox.Text = Properties.Settings.Default.Shortcut2Path;

            currentTab = AppTab.Settings;
            AppDesignProvider.SetCurrentTab(this, (AppTheme)Properties.Settings.Default.ThemeIndex, currentTab);

            AppDesignProvider.SetThemeLabelFont(this, (AppTheme)Properties.Settings.Default.ThemeIndex);

            ShowsLayout.Visible = PlayerLayout.Visible = DriveNotFoundLabel.Visible = RefreshLabel.Visible = false;
            SettingsLayout.Visible = true;
        }

        private void HardDriveLabel_MouseEnter(object sender, EventArgs e)
        {
            Control label = sender as Control;
            if (label.BackColor != Properties.Settings.Default.AppColourHighlight)
                label.BackColor = Properties.Settings.Default.AppColourMenuHover;
        }

        private void AutoplayButton_MouseEnter(object sender, EventArgs e)
        {
            Control label = sender as Control;
            if (label.BackColor != Properties.Settings.Default.AppColourHighlight)
                label.BackColor = Properties.Settings.Default.AppColourHover;
        }

        private void HardDriveLabel_MouseLeave(object sender, EventArgs e)
        {
            Control label = sender as Control;
            if (label.BackColor != Properties.Settings.Default.AppColourHighlight)
                label.BackColor = Color.Transparent;
        }

        private void MinimiseLabel_MouseEnter(object sender, EventArgs e)
        {
            Control label = sender as Control;
            if (label.BackColor != Properties.Settings.Default.AppColourHighlight)
                label.BackColor = Properties.Settings.Default.AppColourMenu;
        }

        private void MinimiseLabel_MouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Properties.Settings.Default.AppColourMenuHover;
        }

        private void RefreshLabel_Click(object sender, EventArgs e)
        {
            if (refreshing)
                return;

            refreshing = true;
            Task.Run(() => UpdateLoaderIcon());

            for (int i = 0; i < 10; i++)
            {
                if (!refreshing)
                    break;

                LoadFromDrive();
            }

            refreshing = false;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            // Send the user back if they haven't checked anything
            if (ready && ShowsList.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Please select at least one show.", "Choose something...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                List<string> selectedShows = new List<string>();

                // If picking from the hard drive...
                if (currentTab == AppTab.HardDrive)
                {
                    // Add selected shows to list, run Select method
                    foreach (var item in ShowsList.CheckedItems)
                    {
                        selectedShows.Add(item.ToString());
                    }

                    SelectFromDrive(selectedShows);
                }
                // If picking from online shows...
                else if (currentTab == AppTab.Online)
                {
                    // Add the relevant url path selectors to list, join and split (for shows with multiple links), run Select method
                    foreach (var item in ShowsList.CheckedItems)
                    {
                        selectedShows.Add(onlineCartoons.Where(oc => oc.Item1 == item.ToString()).FirstOrDefault().Item2);
                    }

                    var cartoonUrlPaths = string.Join(",", selectedShows.ToArray());
                    selectedShows = cartoonUrlPaths.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    SelectFromOnline(selectedShows);
                }
            }
            catch (Exception ex)
            {
                // Catch and show any errors that occur
                MessageBox.Show("Could not start tv show.\r\n\r\nError: " + ex.Message);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ShowPlayer.playState != WMPLib.WMPPlayState.wmppsStopped)
            {
                timer.Stop();

                var accurateTimer = ShowPlayer.Ctlcontrols.isAvailable["currentPosition"] && ShowPlayer.Ctlcontrols.currentPosition != 0;
                if (accurateTimer)
                    timer.Interval = Math.Max((int)((ShowPlayer.currentMedia.duration - ShowPlayer.Ctlcontrols.currentPosition) * 1000), 1000);
                else
                    timer.Interval = 1000;

                timer.Start();
            }
            else {
                if (AutoplayButton.Checked)
                    SelectFromDrive(timerFolders);
            }
        }

        private void BrowseMainButton_Click(object sender, EventArgs e)
        {
            var result = folderBroswerDialog.ShowDialog();
            if (result == DialogResult.OK)
                MainDriveTextbox.Text = folderBroswerDialog.SelectedPath;
        }

        private void BrowseS1Button_Click(object sender, EventArgs e)
        {
            var result = folderBroswerDialog.ShowDialog();
            if (result == DialogResult.OK)
                Shortcut1Textbox.Text = folderBroswerDialog.SelectedPath;
            folderBroswerDialog.SelectedPath = Properties.Settings.Default.MainDrivePath;
        }

        private void BrowseS2Button_Click(object sender, EventArgs e)
        {
            var result = folderBroswerDialog.ShowDialog();
            if (result == DialogResult.OK)
                Shortcut2Textbox.Text = folderBroswerDialog.SelectedPath;
            folderBroswerDialog.SelectedPath = Properties.Settings.Default.MainDrivePath;
        }

        private void MonolithLabel_Click(object sender, EventArgs e)
        {
            MonolithLabel.Font = AzureLabel.Font = ForestLabel.Font = new Font(MonolithLabel.Font, FontStyle.Regular);
            ((Control)sender).Font = new Font(((Control)sender).Font, FontStyle.Underline);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var settingsChanged = false;
            var validated = true;

            if (Directory.Exists(MainDriveTextbox.Text))
            {
                Properties.Settings.Default.MainDrivePath = MainDriveTextbox.Text;
                settingsChanged = true;
            }
            else if (!string.IsNullOrWhiteSpace(MainDriveTextbox.Text))
                validated = false;

            if (Directory.Exists(Shortcut1Textbox.Text))
            {
                Properties.Settings.Default.Shortcut1Path = Shortcut1Textbox.Text;
                settingsChanged = true;
            }
            else if (!string.IsNullOrWhiteSpace(Shortcut1Textbox.Text))
                validated = false;

            if (Directory.Exists(Shortcut2Textbox.Text))
            {
                Properties.Settings.Default.Shortcut2Path = Shortcut2Textbox.Text;
                settingsChanged = true;
            }
            else if (!string.IsNullOrWhiteSpace(Shortcut2Textbox.Text))
                validated = false;

            Properties.Settings.Default.Save();

            if (!validated)
                MessageBox.Show("Could not set one or more of the default folder paths. Please try again.");

            var theme = MonolithLabel.Font.Underline ? 0 : AzureLabel.Font.Underline ? 1 : 2;
            settingsChanged |= theme != Properties.Settings.Default.ThemeIndex;
            AppDesignProvider.SetTheme(this, (AppTheme)theme);
            AppDesignProvider.SetCurrentTab(this, (AppTheme)theme, currentTab);

            if (settingsChanged)
                UpdateSettingsButton();

            MainDriveTextbox.Text = Properties.Settings.Default.MainDrivePath;
            Shortcut1Textbox.Text = Properties.Settings.Default.Shortcut1Path;
            Shortcut2Textbox.Text = Properties.Settings.Default.Shortcut2Path;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Populate the CheckboxList from my Ext HDD, or show the user the "empty" text if it isn't mounted.
        /// </summary>
        private void LoadFromDrive()
        {
            // Get external hard drive
            if (Directory.Exists(Properties.Settings.Default.MainDrivePath))
            {
                ShowsList.Items.Clear();
                // Display the name of each folder in "TV Shows" folder
                foreach (var folder in Directory.GetDirectories(Properties.Settings.Default.MainDrivePath))
                    ShowsList.Items.Add(Path.GetFileName(folder), false);

                refreshing = false;
                DriveNotFoundLabel.Visible = RefreshLabel.Visible = false;
                ShowsList.Visible = ready = true;
            }

            if (ShowsList.Items.Count <= 0)
            {
                ShowsList.Visible = ready = false;
                DriveNotFoundLabel.Visible = RefreshLabel.Visible = true;
            }
        }

        /// <summary>
        /// Populate the CheckboxList from the internal "onlineCartoons" array
        /// </summary>
        private void LoadFromOnline()
        {
            ShowsList.Items.Clear();
            ShowsList.Items.AddRange(onlineCartoons.Select(c => c.Item1).ToArray());
            ShowsList.Visible = ready = true;
        }

        /// <summary>
        /// Play a random episode from one of the shows passed in
        /// </summary>
        /// <param name="selectedShows">The list of shows selected by the user to pick an episode from</param>
        private void SelectFromDrive(IEnumerable<string> selectedShows)
        {
            // If no shows are passed in, return
            if (selectedShows == null || selectedShows.Count() <= 0)
            {
                MessageBox.Show("Please select at least one show.", "Choose something...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var videoStarted = false;
            var attempts = 0;
            var selectedShowsArr = selectedShows.ToArray();

            // For 5 attempts...
            while (!videoStarted)
            {
                attempts++;
                // Get the folder path of one of the selected shows
                var showFolder = Path.Combine(Properties.Settings.Default.MainDrivePath, selectedShowsArr[rnd.Next(selectedShowsArr.Count())]);

                // Attempt to find a file in the folder and play it
                videoStarted = PickAndPlayVideoFile(showFolder);

                // If 5 attempts have passed, inform the user and return
                if (attempts > 4)
                {
                    MessageBox.Show("Could not find a show to launch...\r\n\r\nPlease try again.", "Could not launch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            timerFolders = selectedShows.ToArray();
        }

        /// <summary>
        /// Goes into a season folder, gets all files in the folder path, picks one and plays it if it is a video file
        /// </summary>
        /// <param name="folderPath">Path to pick file from</param>
        /// <param name="rnd">Random number generator</param>
        /// <returns>True if the video is started</returns>
        private bool PickAndPlayVideoFile(string folderPath)
        {
            // Stop the timer if it's running
            if (timer.Enabled)
                timer.Stop();

            // Get all files in the folder and pick one
            var files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories).Where(f => IsVideoFile(f)).ToArray();
            var file = files.Count() > 0 ? files[rnd.Next(files.Count())] : null;

            // If it's a video file, play it and break the loop
            try
            {
                // Open the file in the media player control, set and start timer
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    ShowPlayer.currentMedia = ShowPlayer.newMedia(file);
                }).Start();

                PlayLabel_Click(null, null);
                timer.Interval = (int)(ShowPlayer.newMedia(file).duration * 1000);
                timer.Start();
                
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        /// <summary>
        /// Launch the page of a random episode from one of the shows passed in
        /// </summary>
        /// <param name="selectedShowPaths">The list of paths relating to shows selected by the user</param>
        private async void SelectFromOnline(IEnumerable<string> selectedShowPaths)
        {
            // If no shows are passed in, return
            if (selectedShowPaths == null || selectedShowPaths.Count() <= 0)
            {
                MessageBox.Show("Please select at least one show.", "Choose something...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool videoStarted = false;
            int attemps = 0;
            var parser = new HtmlParser();
            var selectedShowPathsArr = selectedShowPaths.ToArray();

            // For 5 attempts...
            while (!videoStarted)
            {
                /// Pick a show from the array
                var randomShow = selectedShowPathsArr[rnd.Next(selectedShowPathsArr.Count())];

                // Load the web scraper and get the DOM of the episode list page e.g. https://www.watchcartoononline.com/anime/adventure-time
                var config = Configuration.Default.WithDefaultLoader();
                var document = await BrowsingContext
                    .New(config)
                    .OpenAsync("https://www.watchcartoononline.com/anime/" + randomShow);

                // Get all anchor elements containing a link to an episode page
                var episodeAnchorElements = (randomShow != "rick-and-morty") ?
                    document.QuerySelectorAll("div.cat-eps>a").ToArray() :
                    document.QuerySelectorAll("div.cat-eps>a") // Added this selector for rick and morty to filter out all the special features bullshit I don't want
                        .Where(a => a.TextContent.ToLowerInvariant().IndexOf("rick and morty season") == 0 || a.TextContent.ToLowerInvariant().IndexOf("rick and morty episode") == 0)
                        .ToArray();

                try
                {
                    // Open up the url using a random div's href
                    attemps++;
                    Process.Start(episodeAnchorElements[rnd.Next(episodeAnchorElements.Count())].Attributes["href"].Value);
                    videoStarted = true;
                }
                catch (Exception ex)
                {
                    // After 5 tries, inform the user and return
                    if (attemps > 4)
                    {
                        MessageBox.Show("Could not launch show...\r\n\r\nError: " + ex.Message, "Could not launch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Change the refresh icon to a loading "..." for at least one cycle while the program searches for the Ext HDD
        /// </summary>
        private void UpdateLoaderIcon()
        {
            if ((AppTheme)Properties.Settings.Default.ThemeIndex == AppTheme.Monolith)
            {
                RefreshLabel.BackColor = Color.Transparent;
                RefreshLabel.MouseEnter -= AutoplayButton_MouseEnter;

                RefreshLabel.Image = Properties.Resources._1_dot_alt;
                System.Threading.Thread.Sleep(200);
                RefreshLabel.Image = Properties.Resources._2_dot_alt;
                System.Threading.Thread.Sleep(200);
                RefreshLabel.Image = Properties.Resources._3_dot_alt;
                System.Threading.Thread.Sleep(200);

                RefreshLabel.Image = Properties.Resources.refresh_icon_alt;
                RefreshLabel.MouseEnter += AutoplayButton_MouseEnter;
            }
            else
            {
                RefreshLabel.BackColor = Color.Transparent;
                RefreshLabel.MouseEnter -= AutoplayButton_MouseEnter;

                RefreshLabel.Image = Properties.Resources._1_dot;
                System.Threading.Thread.Sleep(200);
                RefreshLabel.Image = Properties.Resources._2_dot;
                System.Threading.Thread.Sleep(200);
                RefreshLabel.Image = Properties.Resources._3_dot;
                System.Threading.Thread.Sleep(200);

                RefreshLabel.Image = Properties.Resources.refresh_icon;
                RefreshLabel.MouseEnter += AutoplayButton_MouseEnter;
            }
        }

        /// <summary>
        /// Change the settings button text to "Saved!", and then back again
        /// </summary>
        private void UpdateSettingsButton()
        {
            SaveButton.Text = "Saved!";
            var t = new System.Windows.Forms.Timer() { Interval = 800 };
            t.Tick += (s, e) => { SaveButton.Text = "Save"; t.Stop(); };
            t.Start();
        }

        /// <summary>
        /// Determine if a file passed in is a video file type (.avi, .mp4, .divx, .wmv, .mkv)
        /// </summary>
        /// <param name="path">The path of the file to evaluate</param>
        /// <returns>Return true if video file type</returns>
        static bool IsVideoFile(string path)
        {
            return Array.IndexOf(videoExtensions, Path.GetExtension(path).ToUpperInvariant()) != -1;
        }

        #endregion
    }
}