namespace RandomTvShow
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ShowsList = new System.Windows.Forms.CheckedListBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.MenuBar = new System.Windows.Forms.TableLayoutPanel();
            this.DriveNotFoundLabel = new System.Windows.Forms.Label();
            this.ShowsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MinimiseLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PlayShowPanel = new System.Windows.Forms.Panel();
            this.AutoplayButton = new System.Windows.Forms.CheckBox();
            this.SettingsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.Shortcut2Textbox = new System.Windows.Forms.TextBox();
            this.BrowseS2Button = new System.Windows.Forms.Label();
            this.MainDriveLabel = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.MainDriveTextbox = new System.Windows.Forms.TextBox();
            this.BrowseMainButton = new System.Windows.Forms.Label();
            this.Shortcut2Label = new System.Windows.Forms.Label();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.Shortcut1Textbox = new System.Windows.Forms.TextBox();
            this.BrowseS1Button = new System.Windows.Forms.Label();
            this.Shortcut1Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ForestLabel = new System.Windows.Forms.Label();
            this.AzureLabel = new System.Windows.Forms.Label();
            this.MonolithLabel = new System.Windows.Forms.Label();
            this.HeaderLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MinimiseLabel2 = new System.Windows.Forms.Label();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.SaveSettingsPanel = new System.Windows.Forms.Panel();
            this.VersionNumberLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.folderBroswerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.FormTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.OnlineLabel = new System.Windows.Forms.Label();
            this.HardDriveLabel = new System.Windows.Forms.Label();
            this.CloseLabel2 = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.RefreshLabel = new System.Windows.Forms.Label();
            this.ShowPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.MenuBar.SuspendLayout();
            this.ShowsLayout.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.PlayShowPanel.SuspendLayout();
            this.SettingsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.HeaderLayoutPanel.SuspendLayout();
            this.SaveSettingsPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowsList
            // 
            this.ShowsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowsList.BackColor = System.Drawing.Color.Gray;
            this.ShowsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowsList.CheckOnClick = true;
            this.ShowsList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ShowsList.FormattingEnabled = true;
            this.ShowsList.Location = new System.Drawing.Point(10, 63);
            this.ShowsList.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ShowsList.Name = "ShowsList";
            this.ShowsList.Size = new System.Drawing.Size(356, 402);
            this.ShowsList.TabIndex = 0;
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoButton.BackColor = System.Drawing.Color.DimGray;
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.ForeColor = System.Drawing.Color.Transparent;
            this.GoButton.Location = new System.Drawing.Point(11, 6);
            this.GoButton.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(111, 49);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go!";
            this.FormTooltip.SetToolTip(this.GoButton, "Play a random video");
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.Transparent;
            this.MenuBar.ColumnCount = 1;
            this.MenuBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuBar.Controls.Add(this.SettingsLabel, 0, 2);
            this.MenuBar.Controls.Add(this.OnlineLabel, 0, 1);
            this.MenuBar.Controls.Add(this.HardDriveLabel, 0, 0);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RowCount = 4;
            this.MenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuBar.Size = new System.Drawing.Size(85, 263);
            this.MenuBar.TabIndex = 2;
            // 
            // DriveNotFoundLabel
            // 
            this.DriveNotFoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.DriveNotFoundLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveNotFoundLabel.ForeColor = System.Drawing.Color.Transparent;
            this.DriveNotFoundLabel.Location = new System.Drawing.Point(87, 140);
            this.DriveNotFoundLabel.Name = "DriveNotFoundLabel";
            this.DriveNotFoundLabel.Size = new System.Drawing.Size(367, 69);
            this.DriveNotFoundLabel.TabIndex = 3;
            this.DriveNotFoundLabel.Text = "Drive could not be found...";
            this.DriveNotFoundLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DriveNotFoundLabel.Visible = false;
            // 
            // ShowsLayout
            // 
            this.ShowsLayout.BackColor = System.Drawing.Color.Transparent;
            this.ShowsLayout.ColumnCount = 1;
            this.ShowsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ShowsLayout.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.ShowsLayout.Controls.Add(this.ShowsList, 0, 1);
            this.ShowsLayout.Controls.Add(this.PlayShowPanel, 0, 2);
            this.ShowsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowsLayout.Location = new System.Drawing.Point(0, 0);
            this.ShowsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ShowsLayout.Name = "ShowsLayout";
            this.ShowsLayout.RowCount = 3;
            this.ShowsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShowsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.5F));
            this.ShowsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.ShowsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ShowsLayout.Size = new System.Drawing.Size(376, 534);
            this.ShowsLayout.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel3.Controls.Add(this.MinimiseLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TitleLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CloseLabel, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(376, 53);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // MinimiseLabel
            // 
            this.MinimiseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.MinimiseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimiseLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimiseLabel.Location = new System.Drawing.Point(240, 0);
            this.MinimiseLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MinimiseLabel.Name = "MinimiseLabel";
            this.MinimiseLabel.Size = new System.Drawing.Size(67, 53);
            this.MinimiseLabel.TabIndex = 2;
            this.MinimiseLabel.Text = "__";
            this.MinimiseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTooltip.SetToolTip(this.MinimiseLabel, "Close");
            this.MinimiseLabel.Click += new System.EventHandler(this.MinimiseLabel_Click);
            this.MinimiseLabel.MouseEnter += new System.EventHandler(this.MinimiseLabel_MouseEnter);
            this.MinimiseLabel.MouseLeave += new System.EventHandler(this.MinimiseLabel_MouseLeave);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.TitleLabel.Size = new System.Drawing.Size(240, 53);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Drive";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // PlayShowPanel
            // 
            this.PlayShowPanel.Controls.Add(this.AutoplayButton);
            this.PlayShowPanel.Controls.Add(this.GoButton);
            this.PlayShowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayShowPanel.Location = new System.Drawing.Point(0, 466);
            this.PlayShowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PlayShowPanel.Name = "PlayShowPanel";
            this.PlayShowPanel.Size = new System.Drawing.Size(376, 68);
            this.PlayShowPanel.TabIndex = 15;
            // 
            // AutoplayButton
            // 
            this.AutoplayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoplayButton.AutoSize = true;
            this.AutoplayButton.BackColor = System.Drawing.Color.Transparent;
            this.AutoplayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoplayButton.ForeColor = System.Drawing.Color.Transparent;
            this.AutoplayButton.Location = new System.Drawing.Point(232, 15);
            this.AutoplayButton.Name = "AutoplayButton";
            this.AutoplayButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AutoplayButton.Size = new System.Drawing.Size(124, 32);
            this.AutoplayButton.TabIndex = 0;
            this.AutoplayButton.Text = "Autoplay";
            this.FormTooltip.SetToolTip(this.AutoplayButton, "Select to play another video when the current one ends");
            this.AutoplayButton.UseVisualStyleBackColor = false;
            this.AutoplayButton.MouseEnter += new System.EventHandler(this.AutoplayButton_MouseEnter);
            this.AutoplayButton.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // SettingsLayout
            // 
            this.SettingsLayout.ColumnCount = 1;
            this.SettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsLayout.Controls.Add(this.ThemeLabel, 0, 8);
            this.SettingsLayout.Controls.Add(this.splitContainer7, 0, 7);
            this.SettingsLayout.Controls.Add(this.MainDriveLabel, 0, 2);
            this.SettingsLayout.Controls.Add(this.splitContainer4, 0, 3);
            this.SettingsLayout.Controls.Add(this.Shortcut2Label, 0, 6);
            this.SettingsLayout.Controls.Add(this.splitContainer6, 0, 5);
            this.SettingsLayout.Controls.Add(this.Shortcut1Label, 0, 4);
            this.SettingsLayout.Controls.Add(this.tableLayoutPanel1, 0, 9);
            this.SettingsLayout.Controls.Add(this.HeaderLayoutPanel, 0, 0);
            this.SettingsLayout.Controls.Add(this.SaveSettingsPanel, 0, 10);
            this.SettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLayout.Location = new System.Drawing.Point(0, 0);
            this.SettingsLayout.Name = "SettingsLayout";
            this.SettingsLayout.RowCount = 11;
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091819F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.21121F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091819F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.21121F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091818F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.21121F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.SettingsLayout.Size = new System.Drawing.Size(376, 534);
            this.SettingsLayout.TabIndex = 5;
            this.SettingsLayout.Visible = false;
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThemeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ThemeLabel.Location = new System.Drawing.Point(3, 344);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ThemeLabel.Size = new System.Drawing.Size(364, 21);
            this.ThemeLabel.TabIndex = 11;
            this.ThemeLabel.Text = "Theme";
            this.ThemeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer7
            // 
            this.splitContainer7.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer7.IsSplitterFixed = true;
            this.splitContainer7.Location = new System.Drawing.Point(0, 279);
            this.splitContainer7.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.Shortcut2Textbox);
            this.splitContainer7.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 145, 0);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.BrowseS2Button);
            this.splitContainer7.Size = new System.Drawing.Size(376, 65);
            this.splitContainer7.SplitterDistance = 303;
            this.splitContainer7.SplitterWidth = 1;
            this.splitContainer7.TabIndex = 8;
            // 
            // Shortcut2Textbox
            // 
            this.Shortcut2Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shortcut2Textbox.BackColor = System.Drawing.Color.Gray;
            this.Shortcut2Textbox.ForeColor = System.Drawing.Color.Transparent;
            this.Shortcut2Textbox.Location = new System.Drawing.Point(10, 10);
            this.Shortcut2Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Shortcut2Textbox.Name = "Shortcut2Textbox";
            this.Shortcut2Textbox.Size = new System.Drawing.Size(43, 22);
            this.Shortcut2Textbox.TabIndex = 0;
            // 
            // BrowseS2Button
            // 
            this.BrowseS2Button.AutoSize = true;
            this.BrowseS2Button.BackColor = System.Drawing.Color.Transparent;
            this.BrowseS2Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseS2Button.ForeColor = System.Drawing.Color.Transparent;
            this.BrowseS2Button.Location = new System.Drawing.Point(0, 5);
            this.BrowseS2Button.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseS2Button.Name = "BrowseS2Button";
            this.BrowseS2Button.Padding = new System.Windows.Forms.Padding(5);
            this.BrowseS2Button.Size = new System.Drawing.Size(75, 33);
            this.BrowseS2Button.TabIndex = 0;
            this.BrowseS2Button.Text = "Browse";
            this.BrowseS2Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrowseS2Button.Click += new System.EventHandler(this.BrowseS2Button_Click);
            this.BrowseS2Button.MouseEnter += new System.EventHandler(this.AutoplayButton_MouseEnter);
            this.BrowseS2Button.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // MainDriveLabel
            // 
            this.MainDriveLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainDriveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDriveLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDriveLabel.ForeColor = System.Drawing.Color.Transparent;
            this.MainDriveLabel.Location = new System.Drawing.Point(3, 65);
            this.MainDriveLabel.Name = "MainDriveLabel";
            this.MainDriveLabel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.MainDriveLabel.Size = new System.Drawing.Size(370, 28);
            this.MainDriveLabel.TabIndex = 0;
            this.MainDriveLabel.Text = "Main Drive:";
            this.MainDriveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 93);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.MainDriveTextbox);
            this.splitContainer4.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 145, 0);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.BrowseMainButton);
            this.splitContainer4.Size = new System.Drawing.Size(376, 65);
            this.splitContainer4.SplitterDistance = 303;
            this.splitContainer4.SplitterWidth = 1;
            this.splitContainer4.TabIndex = 1;
            // 
            // MainDriveTextbox
            // 
            this.MainDriveTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDriveTextbox.BackColor = System.Drawing.Color.Gray;
            this.MainDriveTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.MainDriveTextbox.Location = new System.Drawing.Point(10, 10);
            this.MainDriveTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.MainDriveTextbox.Name = "MainDriveTextbox";
            this.MainDriveTextbox.Size = new System.Drawing.Size(43, 22);
            this.MainDriveTextbox.TabIndex = 0;
            // 
            // BrowseMainButton
            // 
            this.BrowseMainButton.AutoSize = true;
            this.BrowseMainButton.BackColor = System.Drawing.Color.Transparent;
            this.BrowseMainButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseMainButton.ForeColor = System.Drawing.Color.Transparent;
            this.BrowseMainButton.Location = new System.Drawing.Point(0, 5);
            this.BrowseMainButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseMainButton.Name = "BrowseMainButton";
            this.BrowseMainButton.Padding = new System.Windows.Forms.Padding(5);
            this.BrowseMainButton.Size = new System.Drawing.Size(75, 33);
            this.BrowseMainButton.TabIndex = 0;
            this.BrowseMainButton.Text = "Browse";
            this.BrowseMainButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrowseMainButton.Click += new System.EventHandler(this.BrowseMainButton_Click);
            this.BrowseMainButton.MouseEnter += new System.EventHandler(this.AutoplayButton_MouseEnter);
            this.BrowseMainButton.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // Shortcut2Label
            // 
            this.Shortcut2Label.BackColor = System.Drawing.Color.Transparent;
            this.Shortcut2Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shortcut2Label.ForeColor = System.Drawing.Color.Transparent;
            this.Shortcut2Label.Location = new System.Drawing.Point(3, 251);
            this.Shortcut2Label.Name = "Shortcut2Label";
            this.Shortcut2Label.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Shortcut2Label.Size = new System.Drawing.Size(364, 21);
            this.Shortcut2Label.TabIndex = 6;
            this.Shortcut2Label.Text = "Shortcut 2 (Ctrl+2)";
            this.Shortcut2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer6
            // 
            this.splitContainer6.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 186);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.Shortcut1Textbox);
            this.splitContainer6.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 145, 0);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.BrowseS1Button);
            this.splitContainer6.Size = new System.Drawing.Size(376, 65);
            this.splitContainer6.SplitterDistance = 303;
            this.splitContainer6.SplitterWidth = 1;
            this.splitContainer6.TabIndex = 7;
            // 
            // Shortcut1Textbox
            // 
            this.Shortcut1Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shortcut1Textbox.BackColor = System.Drawing.Color.Gray;
            this.Shortcut1Textbox.ForeColor = System.Drawing.Color.Transparent;
            this.Shortcut1Textbox.Location = new System.Drawing.Point(10, 10);
            this.Shortcut1Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Shortcut1Textbox.Name = "Shortcut1Textbox";
            this.Shortcut1Textbox.Size = new System.Drawing.Size(43, 22);
            this.Shortcut1Textbox.TabIndex = 0;
            // 
            // BrowseS1Button
            // 
            this.BrowseS1Button.AutoSize = true;
            this.BrowseS1Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseS1Button.ForeColor = System.Drawing.Color.Transparent;
            this.BrowseS1Button.Location = new System.Drawing.Point(0, 5);
            this.BrowseS1Button.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseS1Button.Name = "BrowseS1Button";
            this.BrowseS1Button.Padding = new System.Windows.Forms.Padding(5);
            this.BrowseS1Button.Size = new System.Drawing.Size(75, 33);
            this.BrowseS1Button.TabIndex = 0;
            this.BrowseS1Button.Text = "Browse";
            this.BrowseS1Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrowseS1Button.Click += new System.EventHandler(this.BrowseS1Button_Click);
            this.BrowseS1Button.MouseEnter += new System.EventHandler(this.AutoplayButton_MouseEnter);
            this.BrowseS1Button.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // Shortcut1Label
            // 
            this.Shortcut1Label.BackColor = System.Drawing.Color.Transparent;
            this.Shortcut1Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shortcut1Label.ForeColor = System.Drawing.Color.Transparent;
            this.Shortcut1Label.Location = new System.Drawing.Point(3, 158);
            this.Shortcut1Label.Name = "Shortcut1Label";
            this.Shortcut1Label.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Shortcut1Label.Size = new System.Drawing.Size(364, 21);
            this.Shortcut1Label.TabIndex = 5;
            this.Shortcut1Label.Text = "Shortcut 1 (Ctrl+1)";
            this.Shortcut1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ForestLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AzureLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MonolithLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 372);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 80);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // ForestLabel
            // 
            this.ForestLabel.AutoSize = true;
            this.ForestLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForestLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ForestLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForestLabel.Location = new System.Drawing.Point(270, 0);
            this.ForestLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ForestLabel.Name = "ForestLabel";
            this.ForestLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ForestLabel.Size = new System.Drawing.Size(86, 30);
            this.ForestLabel.TabIndex = 2;
            this.ForestLabel.Text = "Forest";
            this.ForestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForestLabel.Click += new System.EventHandler(this.MonolithLabel_Click);
            this.ForestLabel.MouseEnter += new System.EventHandler(this.AutoplayButton_MouseEnter);
            this.ForestLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // AzureLabel
            // 
            this.AzureLabel.AutoSize = true;
            this.AzureLabel.BackColor = System.Drawing.Color.Transparent;
            this.AzureLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AzureLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AzureLabel.Location = new System.Drawing.Point(145, 0);
            this.AzureLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.AzureLabel.Name = "AzureLabel";
            this.AzureLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.AzureLabel.Size = new System.Drawing.Size(85, 30);
            this.AzureLabel.TabIndex = 1;
            this.AzureLabel.Text = "Azure";
            this.AzureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AzureLabel.Click += new System.EventHandler(this.MonolithLabel_Click);
            this.AzureLabel.MouseEnter += new System.EventHandler(this.AutoplayButton_MouseEnter);
            this.AzureLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // MonolithLabel
            // 
            this.MonolithLabel.AutoSize = true;
            this.MonolithLabel.BackColor = System.Drawing.Color.Transparent;
            this.MonolithLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MonolithLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonolithLabel.Location = new System.Drawing.Point(20, 0);
            this.MonolithLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.MonolithLabel.Name = "MonolithLabel";
            this.MonolithLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.MonolithLabel.Size = new System.Drawing.Size(85, 30);
            this.MonolithLabel.TabIndex = 0;
            this.MonolithLabel.Text = "Monolith";
            this.MonolithLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MonolithLabel.Click += new System.EventHandler(this.MonolithLabel_Click);
            this.MonolithLabel.MouseEnter += new System.EventHandler(this.AutoplayButton_MouseEnter);
            this.MonolithLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // HeaderLayoutPanel
            // 
            this.HeaderLayoutPanel.ColumnCount = 3;
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.HeaderLayoutPanel.Controls.Add(this.MinimiseLabel2, 1, 0);
            this.HeaderLayoutPanel.Controls.Add(this.TitleLabel2, 0, 0);
            this.HeaderLayoutPanel.Controls.Add(this.CloseLabel2, 2, 0);
            this.HeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderLayoutPanel.Name = "HeaderLayoutPanel";
            this.HeaderLayoutPanel.RowCount = 1;
            this.HeaderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderLayoutPanel.Size = new System.Drawing.Size(376, 53);
            this.HeaderLayoutPanel.TabIndex = 13;
            // 
            // MinimiseLabel2
            // 
            this.MinimiseLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.MinimiseLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimiseLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimiseLabel2.Location = new System.Drawing.Point(240, 0);
            this.MinimiseLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.MinimiseLabel2.Name = "MinimiseLabel2";
            this.MinimiseLabel2.Size = new System.Drawing.Size(67, 53);
            this.MinimiseLabel2.TabIndex = 2;
            this.MinimiseLabel2.Text = "__";
            this.MinimiseLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTooltip.SetToolTip(this.MinimiseLabel2, "Minimise");
            this.MinimiseLabel2.Click += new System.EventHandler(this.MinimiseLabel_Click);
            this.MinimiseLabel2.MouseEnter += new System.EventHandler(this.MinimiseLabel_MouseEnter);
            this.MinimiseLabel2.MouseLeave += new System.EventHandler(this.MinimiseLabel_MouseLeave);
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.TitleLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel2.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.TitleLabel2.Size = new System.Drawing.Size(240, 53);
            this.TitleLabel2.TabIndex = 0;
            this.TitleLabel2.Text = "Settings";
            this.TitleLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // SaveSettingsPanel
            // 
            this.SaveSettingsPanel.Controls.Add(this.VersionNumberLabel);
            this.SaveSettingsPanel.Controls.Add(this.SaveButton);
            this.SaveSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveSettingsPanel.Location = new System.Drawing.Point(0, 452);
            this.SaveSettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SaveSettingsPanel.Name = "SaveSettingsPanel";
            this.SaveSettingsPanel.Size = new System.Drawing.Size(376, 82);
            this.SaveSettingsPanel.TabIndex = 14;
            // 
            // VersionNumberLabel
            // 
            this.VersionNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VersionNumberLabel.AutoSize = true;
            this.VersionNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionNumberLabel.ForeColor = System.Drawing.Color.Transparent;
            this.VersionNumberLabel.Location = new System.Drawing.Point(7, 32);
            this.VersionNumberLabel.Name = "VersionNumberLabel";
            this.VersionNumberLabel.Size = new System.Drawing.Size(126, 40);
            this.VersionNumberLabel.TabIndex = 0;
            this.VersionNumberLabel.Text = "Random TV Show\r\nVersion: 1.0.0.0";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.DimGray;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Transparent;
            this.SaveButton.Location = new System.Drawing.Point(256, 20);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(111, 51);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.FormTooltip.SetToolTip(this.SaveButton, "Save these settings");
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.43818F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.56182F));
            this.tableLayoutPanel2.Controls.Add(this.MenuPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MainPanel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(461, 534);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuBar);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(85, 534);
            this.MenuPanel.TabIndex = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SettingsLayout);
            this.MainPanel.Controls.Add(this.ShowsLayout);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(85, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(376, 534);
            this.MainPanel.TabIndex = 3;
            // 
            // FormTooltip
            // 
            this.FormTooltip.BackColor = System.Drawing.Color.White;
            this.FormTooltip.ForeColor = System.Drawing.Color.Black;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Image = global::RandomTvShow.Properties.Resources.settings_icon_alt;
            this.SettingsLabel.Location = new System.Drawing.Point(0, 162);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(85, 81);
            this.SettingsLabel.TabIndex = 3;
            this.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTooltip.SetToolTip(this.SettingsLabel, "Settings");
            this.SettingsLabel.Click += new System.EventHandler(this.SettingsLabel_Click);
            this.SettingsLabel.MouseEnter += new System.EventHandler(this.HardDriveLabel_MouseEnter);
            this.SettingsLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // OnlineLabel
            // 
            this.OnlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.OnlineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnlineLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineLabel.ForeColor = System.Drawing.Color.Transparent;
            this.OnlineLabel.Image = global::RandomTvShow.Properties.Resources.online_icon_alt;
            this.OnlineLabel.Location = new System.Drawing.Point(0, 81);
            this.OnlineLabel.Margin = new System.Windows.Forms.Padding(0);
            this.OnlineLabel.Name = "OnlineLabel";
            this.OnlineLabel.Size = new System.Drawing.Size(85, 81);
            this.OnlineLabel.TabIndex = 2;
            this.OnlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTooltip.SetToolTip(this.OnlineLabel, "Random Show from the Web");
            this.OnlineLabel.Click += new System.EventHandler(this.OnlineLabel_Click);
            this.OnlineLabel.MouseEnter += new System.EventHandler(this.HardDriveLabel_MouseEnter);
            this.OnlineLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // HardDriveLabel
            // 
            this.HardDriveLabel.BackColor = System.Drawing.Color.Silver;
            this.HardDriveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HardDriveLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardDriveLabel.ForeColor = System.Drawing.Color.Transparent;
            this.HardDriveLabel.Image = ((System.Drawing.Image)(resources.GetObject("HardDriveLabel.Image")));
            this.HardDriveLabel.Location = new System.Drawing.Point(0, 0);
            this.HardDriveLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HardDriveLabel.Name = "HardDriveLabel";
            this.HardDriveLabel.Size = new System.Drawing.Size(85, 81);
            this.HardDriveLabel.TabIndex = 0;
            this.HardDriveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTooltip.SetToolTip(this.HardDriveLabel, "Random Show from Drive");
            this.HardDriveLabel.Click += new System.EventHandler(this.HardDriveLabel_Click);
            this.HardDriveLabel.MouseEnter += new System.EventHandler(this.HardDriveLabel_MouseEnter);
            this.HardDriveLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // CloseLabel2
            // 
            this.CloseLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.CloseLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseLabel2.Image = global::RandomTvShow.Properties.Resources.close_icon_alt;
            this.CloseLabel2.Location = new System.Drawing.Point(307, 0);
            this.CloseLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.CloseLabel2.Name = "CloseLabel2";
            this.CloseLabel2.Size = new System.Drawing.Size(69, 53);
            this.CloseLabel2.TabIndex = 1;
            this.FormTooltip.SetToolTip(this.CloseLabel2, "Close");
            this.CloseLabel2.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel2.MouseEnter += new System.EventHandler(this.MinimiseLabel_MouseEnter);
            this.CloseLabel2.MouseLeave += new System.EventHandler(this.MinimiseLabel_MouseLeave);
            // 
            // CloseLabel
            // 
            this.CloseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.CloseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseLabel.Image = global::RandomTvShow.Properties.Resources.close_icon_alt;
            this.CloseLabel.Location = new System.Drawing.Point(307, 0);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(69, 53);
            this.CloseLabel.TabIndex = 1;
            this.FormTooltip.SetToolTip(this.CloseLabel, "Close");
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.MinimiseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.MinimiseLabel_MouseLeave);
            // 
            // RefreshLabel
            // 
            this.RefreshLabel.BackColor = System.Drawing.Color.Transparent;
            this.RefreshLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshLabel.ForeColor = System.Drawing.Color.Transparent;
            this.RefreshLabel.Image = ((System.Drawing.Image)(resources.GetObject("RefreshLabel.Image")));
            this.RefreshLabel.Location = new System.Drawing.Point(222, 195);
            this.RefreshLabel.Name = "RefreshLabel";
            this.RefreshLabel.Size = new System.Drawing.Size(96, 96);
            this.RefreshLabel.TabIndex = 4;
            this.RefreshLabel.Visible = false;
            this.RefreshLabel.Click += new System.EventHandler(this.RefreshLabel_Click);
            // 
            // ShowPlayer
            // 
            this.ShowPlayer.Enabled = true;
            this.ShowPlayer.Location = new System.Drawing.Point(342, 48);
            this.ShowPlayer.Name = "ShowPlayer";
            this.ShowPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ShowPlayer.OcxState")));
            this.ShowPlayer.Size = new System.Drawing.Size(25, 23);
            this.ShowPlayer.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AcceptButton = this.GoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(461, 534);
            this.ControlBox = false;
            this.Controls.Add(this.DriveNotFoundLabel);
            this.Controls.Add(this.RefreshLabel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ShowPlayer);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(479, 552);
            this.Name = "MainForm";
            this.MenuBar.ResumeLayout(false);
            this.ShowsLayout.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.PlayShowPanel.ResumeLayout(false);
            this.PlayShowPanel.PerformLayout();
            this.SettingsLayout.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.HeaderLayoutPanel.ResumeLayout(false);
            this.SaveSettingsPanel.ResumeLayout(false);
            this.SaveSettingsPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ShowsList;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TableLayoutPanel MenuBar;
        private System.Windows.Forms.Label HardDriveLabel;
        private System.Windows.Forms.Label DriveNotFoundLabel;
        private System.Windows.Forms.Label RefreshLabel;
        private System.Windows.Forms.TableLayoutPanel ShowsLayout;
        private System.Windows.Forms.CheckBox AutoplayButton;
        private System.Windows.Forms.Label OnlineLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.TableLayoutPanel SettingsLayout;
        private System.Windows.Forms.Label MainDriveLabel;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox MainDriveTextbox;
        private System.Windows.Forms.Label BrowseMainButton;
        private System.Windows.Forms.FolderBrowserDialog folderBroswerDialog;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.TextBox Shortcut2Textbox;
        private System.Windows.Forms.Label BrowseS2Button;
        private System.Windows.Forms.Label Shortcut1Label;
        private System.Windows.Forms.Label Shortcut2Label;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TextBox Shortcut1Textbox;
        private System.Windows.Forms.Label BrowseS1Button;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label VersionNumberLabel;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ForestLabel;
        private System.Windows.Forms.Label AzureLabel;
        private System.Windows.Forms.Label MonolithLabel;
        private System.Windows.Forms.TableLayoutPanel HeaderLayoutPanel;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.Label MinimiseLabel2;
        private System.Windows.Forms.Label CloseLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label MinimiseLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Panel SaveSettingsPanel;
        private System.Windows.Forms.Panel PlayShowPanel;
        private System.Windows.Forms.ToolTip FormTooltip;
        private AxWMPLib.AxWindowsMediaPlayer ShowPlayer;
    }
}

