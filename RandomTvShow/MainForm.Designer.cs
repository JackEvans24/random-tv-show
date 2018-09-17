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
            this.HardDriveLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.OnlineLabel = new System.Windows.Forms.Label();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ShowsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MinimiseLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
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
            this.CloseLabel2 = new System.Windows.Forms.Label();
            this.SaveSettingsPanel = new System.Windows.Forms.Panel();
            this.VersionNumberLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.folderBroswerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PlayerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ShowPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MinimiseLabel3 = new System.Windows.Forms.Label();
            this.TitleLabel3 = new System.Windows.Forms.Label();
            this.CloseLabel3 = new System.Windows.Forms.Label();
            this.RerollButton = new System.Windows.Forms.Button();
            this.FormTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.RefreshLabel = new System.Windows.Forms.Label();
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
            this.PlayerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPlayer)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.ShowsList.Location = new System.Drawing.Point(11, 60);
            this.ShowsList.Margin = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.ShowsList.Name = "ShowsList";
            this.ShowsList.Size = new System.Drawing.Size(350, 402);
            this.ShowsList.TabIndex = 0;
            this.ShowsList.SelectedIndexChanged += new System.EventHandler(this.ShowsList_SelectedIndexChanged);
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoButton.BackColor = System.Drawing.Color.DimGray;
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.ForeColor = System.Drawing.Color.Transparent;
            this.GoButton.Location = new System.Drawing.Point(11, 6);
            this.GoButton.Margin = new System.Windows.Forms.Padding(11, 2, 3, 2);
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
            this.MenuBar.Controls.Add(this.HardDriveLabel, 0, 0);
            this.MenuBar.Controls.Add(this.SettingsLabel, 0, 3);
            this.MenuBar.Controls.Add(this.OnlineLabel, 0, 2);
            this.MenuBar.Controls.Add(this.PlayLabel, 0, 1);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RowCount = 4;
            this.MenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuBar.Size = new System.Drawing.Size(91, 345);
            this.MenuBar.TabIndex = 2;
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
            this.HardDriveLabel.Size = new System.Drawing.Size(91, 86);
            this.HardDriveLabel.TabIndex = 0;
            this.HardDriveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTooltip.SetToolTip(this.HardDriveLabel, "Random Show from Drive");
            this.HardDriveLabel.Click += new System.EventHandler(this.HardDriveLabel_Click);
            this.HardDriveLabel.MouseEnter += new System.EventHandler(this.HardDriveLabel_MouseEnter);
            this.HardDriveLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Image = global::RandomTvShow.Properties.Resources.settings_icon_alt;
            this.SettingsLabel.Location = new System.Drawing.Point(0, 258);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(91, 87);
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
            this.OnlineLabel.Location = new System.Drawing.Point(0, 172);
            this.OnlineLabel.Margin = new System.Windows.Forms.Padding(0);
            this.OnlineLabel.Name = "OnlineLabel";
            this.OnlineLabel.Size = new System.Drawing.Size(91, 86);
            this.OnlineLabel.TabIndex = 2;
            this.OnlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTooltip.SetToolTip(this.OnlineLabel, "Random Show from the Web");
            this.OnlineLabel.Click += new System.EventHandler(this.OnlineLabel_Click);
            this.OnlineLabel.MouseEnter += new System.EventHandler(this.HardDriveLabel_MouseEnter);
            this.OnlineLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // PlayLabel
            // 
            this.PlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayLabel.ForeColor = System.Drawing.Color.Transparent;
            this.PlayLabel.Image = global::RandomTvShow.Properties.Resources.play_icon_alt;
            this.PlayLabel.Location = new System.Drawing.Point(0, 86);
            this.PlayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(91, 86);
            this.PlayLabel.TabIndex = 3;
            this.PlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTooltip.SetToolTip(this.PlayLabel, "Random Show from the Web");
            this.PlayLabel.Click += new System.EventHandler(this.PlayLabel_Click);
            this.PlayLabel.MouseEnter += new System.EventHandler(this.HardDriveLabel_MouseEnter);
            this.PlayLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Location = new System.Drawing.Point(93, 140);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(367, 69);
            this.ErrorLabel.TabIndex = 3;
            this.ErrorLabel.Text = "Drive could not be found...";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ErrorLabel.Visible = false;
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
            this.ShowsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ShowsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ShowsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.ShowsLayout.Size = new System.Drawing.Size(372, 537);
            this.ShowsLayout.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.Controls.Add(this.MinimiseLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TitleLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CloseLabel, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 50);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // MinimiseLabel
            // 
            this.MinimiseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.MinimiseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimiseLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimiseLabel.Location = new System.Drawing.Point(236, 0);
            this.MinimiseLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MinimiseLabel.Name = "MinimiseLabel";
            this.MinimiseLabel.Size = new System.Drawing.Size(68, 50);
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
            this.TitleLabel.Size = new System.Drawing.Size(236, 50);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Drive";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // CloseLabel
            // 
            this.CloseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.CloseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseLabel.Image = global::RandomTvShow.Properties.Resources.close_icon_alt;
            this.CloseLabel.Location = new System.Drawing.Point(304, 0);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(68, 50);
            this.CloseLabel.TabIndex = 1;
            this.FormTooltip.SetToolTip(this.CloseLabel, "Close");
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.MinimiseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.MinimiseLabel_MouseLeave);
            // 
            // PlayShowPanel
            // 
            this.PlayShowPanel.Controls.Add(this.AutoplayButton);
            this.PlayShowPanel.Controls.Add(this.GoButton);
            this.PlayShowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayShowPanel.Location = new System.Drawing.Point(0, 469);
            this.PlayShowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PlayShowPanel.Name = "PlayShowPanel";
            this.PlayShowPanel.Size = new System.Drawing.Size(372, 68);
            this.PlayShowPanel.TabIndex = 15;
            // 
            // AutoplayButton
            // 
            this.AutoplayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoplayButton.AutoSize = true;
            this.AutoplayButton.BackColor = System.Drawing.Color.Transparent;
            this.AutoplayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoplayButton.ForeColor = System.Drawing.Color.Transparent;
            this.AutoplayButton.Location = new System.Drawing.Point(229, 14);
            this.AutoplayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutoplayButton.Name = "AutoplayButton";
            this.AutoplayButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.AutoplayButton.Size = new System.Drawing.Size(125, 32);
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
            this.SettingsLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsLayout.Location = new System.Drawing.Point(0, 0);
            this.SettingsLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.SettingsLayout.Size = new System.Drawing.Size(372, 537);
            this.SettingsLayout.TabIndex = 5;
            this.SettingsLayout.Visible = false;
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThemeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ThemeLabel.Location = new System.Drawing.Point(3, 347);
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
            this.splitContainer7.Location = new System.Drawing.Point(0, 281);
            this.splitContainer7.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.Shortcut2Textbox);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.BrowseS2Button);
            this.splitContainer7.Size = new System.Drawing.Size(372, 66);
            this.splitContainer7.SplitterDistance = 295;
            this.splitContainer7.SplitterWidth = 1;
            this.splitContainer7.TabIndex = 8;
            // 
            // Shortcut2Textbox
            // 
            this.Shortcut2Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shortcut2Textbox.BackColor = System.Drawing.Color.Gray;
            this.Shortcut2Textbox.ForeColor = System.Drawing.Color.Transparent;
            this.Shortcut2Textbox.Location = new System.Drawing.Point(11, 10);
            this.Shortcut2Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Shortcut2Textbox.Name = "Shortcut2Textbox";
            this.Shortcut2Textbox.Size = new System.Drawing.Size(37, 22);
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
            this.MainDriveLabel.Size = new System.Drawing.Size(366, 28);
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
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.BrowseMainButton);
            this.splitContainer4.Size = new System.Drawing.Size(372, 66);
            this.splitContainer4.SplitterDistance = 295;
            this.splitContainer4.SplitterWidth = 1;
            this.splitContainer4.TabIndex = 1;
            // 
            // MainDriveTextbox
            // 
            this.MainDriveTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDriveTextbox.BackColor = System.Drawing.Color.Gray;
            this.MainDriveTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.MainDriveTextbox.Location = new System.Drawing.Point(11, 10);
            this.MainDriveTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.MainDriveTextbox.Name = "MainDriveTextbox";
            this.MainDriveTextbox.Size = new System.Drawing.Size(37, 22);
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
            this.Shortcut2Label.Location = new System.Drawing.Point(3, 253);
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
            this.splitContainer6.Location = new System.Drawing.Point(0, 187);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.Shortcut1Textbox);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.BrowseS1Button);
            this.splitContainer6.Size = new System.Drawing.Size(372, 66);
            this.splitContainer6.SplitterDistance = 295;
            this.splitContainer6.SplitterWidth = 1;
            this.splitContainer6.TabIndex = 7;
            // 
            // Shortcut1Textbox
            // 
            this.Shortcut1Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shortcut1Textbox.BackColor = System.Drawing.Color.Gray;
            this.Shortcut1Textbox.ForeColor = System.Drawing.Color.Transparent;
            this.Shortcut1Textbox.Location = new System.Drawing.Point(11, 10);
            this.Shortcut1Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Shortcut1Textbox.Name = "Shortcut1Textbox";
            this.Shortcut1Textbox.Size = new System.Drawing.Size(37, 22);
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
            this.Shortcut1Label.Location = new System.Drawing.Point(3, 159);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 375);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 80);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // ForestLabel
            // 
            this.ForestLabel.AutoSize = true;
            this.ForestLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForestLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ForestLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForestLabel.Location = new System.Drawing.Point(266, 0);
            this.ForestLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ForestLabel.Name = "ForestLabel";
            this.ForestLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ForestLabel.Size = new System.Drawing.Size(85, 30);
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
            this.AzureLabel.Location = new System.Drawing.Point(143, 0);
            this.AzureLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.AzureLabel.Name = "AzureLabel";
            this.AzureLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.AzureLabel.Size = new System.Drawing.Size(83, 30);
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
            this.MonolithLabel.Size = new System.Drawing.Size(83, 30);
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
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.HeaderLayoutPanel.Controls.Add(this.MinimiseLabel2, 1, 0);
            this.HeaderLayoutPanel.Controls.Add(this.TitleLabel2, 0, 0);
            this.HeaderLayoutPanel.Controls.Add(this.CloseLabel2, 2, 0);
            this.HeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderLayoutPanel.Name = "HeaderLayoutPanel";
            this.HeaderLayoutPanel.RowCount = 1;
            this.HeaderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderLayoutPanel.Size = new System.Drawing.Size(372, 53);
            this.HeaderLayoutPanel.TabIndex = 13;
            // 
            // MinimiseLabel2
            // 
            this.MinimiseLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.MinimiseLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimiseLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimiseLabel2.Location = new System.Drawing.Point(236, 0);
            this.MinimiseLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.MinimiseLabel2.Name = "MinimiseLabel2";
            this.MinimiseLabel2.Size = new System.Drawing.Size(68, 53);
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
            this.TitleLabel2.Size = new System.Drawing.Size(236, 53);
            this.TitleLabel2.TabIndex = 0;
            this.TitleLabel2.Text = "Settings";
            this.TitleLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // CloseLabel2
            // 
            this.CloseLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.CloseLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseLabel2.Image = global::RandomTvShow.Properties.Resources.close_icon_alt;
            this.CloseLabel2.Location = new System.Drawing.Point(304, 0);
            this.CloseLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.CloseLabel2.Name = "CloseLabel2";
            this.CloseLabel2.Size = new System.Drawing.Size(68, 53);
            this.CloseLabel2.TabIndex = 1;
            this.FormTooltip.SetToolTip(this.CloseLabel2, "Close");
            this.CloseLabel2.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel2.MouseEnter += new System.EventHandler(this.MinimiseLabel_MouseEnter);
            this.CloseLabel2.MouseLeave += new System.EventHandler(this.MinimiseLabel_MouseLeave);
            // 
            // SaveSettingsPanel
            // 
            this.SaveSettingsPanel.Controls.Add(this.VersionNumberLabel);
            this.SaveSettingsPanel.Controls.Add(this.SaveButton);
            this.SaveSettingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveSettingsPanel.Location = new System.Drawing.Point(0, 455);
            this.SaveSettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SaveSettingsPanel.Name = "SaveSettingsPanel";
            this.SaveSettingsPanel.Size = new System.Drawing.Size(372, 82);
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
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Transparent;
            this.SaveButton.Location = new System.Drawing.Point(252, 20);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 20, 20);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(111, 50);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.MenuPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MainPanel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(463, 537);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuBar);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(91, 537);
            this.MenuPanel.TabIndex = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SaveSettingsPanel);
            this.MainPanel.Controls.Add(this.SettingsLayout);
            this.MainPanel.Controls.Add(this.PlayerLayout);
            this.MainPanel.Controls.Add(this.ShowsLayout);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(91, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(372, 537);
            this.MainPanel.TabIndex = 3;
            // 
            // PlayerLayout
            // 
            this.PlayerLayout.ColumnCount = 1;
            this.PlayerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlayerLayout.Controls.Add(this.ShowPlayer, 0, 1);
            this.PlayerLayout.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.PlayerLayout.Controls.Add(this.RerollButton, 0, 2);
            this.PlayerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerLayout.Location = new System.Drawing.Point(0, 0);
            this.PlayerLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerLayout.Name = "PlayerLayout";
            this.PlayerLayout.RowCount = 3;
            this.PlayerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.PlayerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlayerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.PlayerLayout.Size = new System.Drawing.Size(372, 537);
            this.PlayerLayout.TabIndex = 3;
            // 
            // ShowPlayer
            // 
            this.ShowPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowPlayer.Enabled = true;
            this.ShowPlayer.Location = new System.Drawing.Point(3, 55);
            this.ShowPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowPlayer.Name = "ShowPlayer";
            this.ShowPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ShowPlayer.OcxState")));
            this.ShowPlayer.Size = new System.Drawing.Size(366, 408);
            this.ShowPlayer.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel4.Controls.Add(this.MinimiseLabel3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.TitleLabel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.CloseLabel3, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(372, 53);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // MinimiseLabel3
            // 
            this.MinimiseLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.MinimiseLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimiseLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimiseLabel3.Location = new System.Drawing.Point(236, 0);
            this.MinimiseLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.MinimiseLabel3.Name = "MinimiseLabel3";
            this.MinimiseLabel3.Size = new System.Drawing.Size(68, 53);
            this.MinimiseLabel3.TabIndex = 2;
            this.MinimiseLabel3.Text = "__";
            this.MinimiseLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTooltip.SetToolTip(this.MinimiseLabel3, "Close");
            this.MinimiseLabel3.Click += new System.EventHandler(this.CloseLabel_Click);
            this.MinimiseLabel3.MouseEnter += new System.EventHandler(this.MinimiseLabel_MouseEnter);
            this.MinimiseLabel3.MouseLeave += new System.EventHandler(this.MinimiseLabel_MouseLeave);
            // 
            // TitleLabel3
            // 
            this.TitleLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.TitleLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel3.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel3.Name = "TitleLabel3";
            this.TitleLabel3.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.TitleLabel3.Size = new System.Drawing.Size(236, 53);
            this.TitleLabel3.TabIndex = 0;
            this.TitleLabel3.Text = "Player";
            this.TitleLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // CloseLabel3
            // 
            this.CloseLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.CloseLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseLabel3.Image = global::RandomTvShow.Properties.Resources.close_icon_alt;
            this.CloseLabel3.Location = new System.Drawing.Point(304, 0);
            this.CloseLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.CloseLabel3.Name = "CloseLabel3";
            this.CloseLabel3.Size = new System.Drawing.Size(68, 53);
            this.CloseLabel3.TabIndex = 1;
            this.FormTooltip.SetToolTip(this.CloseLabel3, "Close");
            this.CloseLabel3.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel3.MouseEnter += new System.EventHandler(this.MinimiseLabel_MouseEnter);
            this.CloseLabel3.MouseLeave += new System.EventHandler(this.MinimiseLabel_MouseLeave);
            // 
            // RerollButton
            // 
            this.RerollButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RerollButton.BackColor = System.Drawing.Color.DimGray;
            this.RerollButton.FlatAppearance.BorderSize = 2;
            this.RerollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RerollButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RerollButton.ForeColor = System.Drawing.Color.Transparent;
            this.RerollButton.Location = new System.Drawing.Point(11, 476);
            this.RerollButton.Margin = new System.Windows.Forms.Padding(11, 2, 3, 12);
            this.RerollButton.Name = "RerollButton";
            this.RerollButton.Size = new System.Drawing.Size(111, 49);
            this.RerollButton.TabIndex = 16;
            this.RerollButton.Text = "Reroll!";
            this.FormTooltip.SetToolTip(this.RerollButton, "Pick another random video using the previous selection");
            this.RerollButton.UseVisualStyleBackColor = false;
            this.RerollButton.Click += new System.EventHandler(this.RerollButton_Click);
            // 
            // FormTooltip
            // 
            this.FormTooltip.BackColor = System.Drawing.Color.White;
            this.FormTooltip.ForeColor = System.Drawing.Color.Black;
            // 
            // RefreshLabel
            // 
            this.RefreshLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshLabel.BackColor = System.Drawing.Color.Transparent;
            this.RefreshLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshLabel.ForeColor = System.Drawing.Color.Transparent;
            this.RefreshLabel.Image = ((System.Drawing.Image)(resources.GetObject("RefreshLabel.Image")));
            this.RefreshLabel.Location = new System.Drawing.Point(221, 180);
            this.RefreshLabel.Name = "RefreshLabel";
            this.RefreshLabel.Size = new System.Drawing.Size(96, 96);
            this.RefreshLabel.TabIndex = 4;
            this.RefreshLabel.Visible = false;
            this.RefreshLabel.Click += new System.EventHandler(this.RefreshLabel_Click);
            this.RefreshLabel.MouseEnter += new System.EventHandler(this.AutoplayButton_MouseEnter);
            this.RefreshLabel.MouseLeave += new System.EventHandler(this.HardDriveLabel_MouseLeave);
            // 
            // MainForm
            // 
            this.AcceptButton = this.GoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(463, 537);
            this.ControlBox = false;
            this.Controls.Add(this.RefreshLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(478, 552);
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
            this.PlayerLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPlayer)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ShowsList;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TableLayoutPanel MenuBar;
        private System.Windows.Forms.Label HardDriveLabel;
        private System.Windows.Forms.Label ErrorLabel;
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
        private System.Windows.Forms.TableLayoutPanel PlayerLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label MinimiseLabel3;
        private System.Windows.Forms.Label TitleLabel3;
        private System.Windows.Forms.Label CloseLabel3;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Button RerollButton;
    }
}

