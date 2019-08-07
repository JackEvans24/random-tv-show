using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTvShow
{
    public class AppDesignProvider
    {
        public static void SetTheme(MainForm form, AppTheme theme)
        {
            Properties.Settings.Default.ThemeIndex = (int)theme;

            Label closeLabel = form.Controls.Find("CloseLabel", true).FirstOrDefault() as Label,
                closeLabel2 = form.Controls.Find("CloseLabel2", true).FirstOrDefault() as Label,
                closeLabel3 = form.Controls.Find("CloseLabel3", true).FirstOrDefault() as Label,
                refreshLabel = form.Controls.Find("RefreshLabel", true).FirstOrDefault() as Label;
            switch (theme)
            {
                case AppTheme.Monolith:
                    Properties.Settings.Default.AppColourBg = Color.Gray;
                    Properties.Settings.Default.AppColourHover = Color.FromArgb(120, 120, 120);
                    Properties.Settings.Default.AppColourMenu = Color.DimGray;
                    Properties.Settings.Default.AppColourMenuHover = Color.FromArgb(116, 116, 116);
                    Properties.Settings.Default.AppColourHighlight = Color.Silver;
                    Properties.Settings.Default.AppColourText = Color.WhiteSmoke;
                    closeLabel.Image = closeLabel2.Image = closeLabel3.Image = Properties.Resources.close_icon_alt;
                    refreshLabel.Image = Properties.Resources.refresh_icon_alt;
                    break;

                case AppTheme.Forest:
                    Properties.Settings.Default.AppColourBg = Color.PaleGreen;
                    Properties.Settings.Default.AppColourHover = Color.LightGreen;
                    Properties.Settings.Default.AppColourMenu = Color.LightGreen;
                    Properties.Settings.Default.AppColourMenuHover = Color.FromArgb(121, 225, 121);
                    Properties.Settings.Default.AppColourHighlight = Color.LimeGreen;
                    Properties.Settings.Default.AppColourText = Color.DarkGreen;
                    closeLabel.Image = closeLabel2.Image = closeLabel3.Image = Properties.Resources.close_icon;
                    refreshLabel.Image = Properties.Resources.refresh_icon;
                    break;

                case AppTheme.Azure:
                    Properties.Settings.Default.AppColourBg = Color.Azure;
                    Properties.Settings.Default.AppColourHover = Color.FromArgb(210, 255, 255);
                    Properties.Settings.Default.AppColourMenu = Color.LightCyan;
                    Properties.Settings.Default.AppColourMenuHover = Color.FromArgb(200, 255, 255);
                    Properties.Settings.Default.AppColourHighlight = Color.White;
                    Properties.Settings.Default.AppColourText = Color.DarkSlateGray;
                    closeLabel.Image = closeLabel2.Image = closeLabel3.Image = Properties.Resources.close_icon;
                    refreshLabel.Image = Properties.Resources.refresh_icon;
                    break;

                case AppTheme.Ghost:
                    Properties.Settings.Default.AppColourBg = Color.FromArgb(150, 127, 153);
                    Properties.Settings.Default.AppColourHover = Color.FromArgb(139, 127, 140);
                    Properties.Settings.Default.AppColourMenu = Color.FromArgb(172, 126, 178);
                    Properties.Settings.Default.AppColourMenuHover = Color.FromArgb(161, 127, 166);
                    Properties.Settings.Default.AppColourHighlight = Color.FromArgb(195, 126, 204);
                    Properties.Settings.Default.AppColourText = Color.White;
                    closeLabel.Image = closeLabel2.Image = closeLabel3.Image = Properties.Resources.close_icon_alt;
                    refreshLabel.Image = Properties.Resources.refresh_icon_alt;
                    break;
            }

            Properties.Settings.Default.Save();

            form.BackColor =
                form.Controls.Find("ShowsList", true).FirstOrDefault().BackColor =
                form.Controls.Find("MainDriveTextbox", true).FirstOrDefault().BackColor =
                form.Controls.Find("Shortcut1Textbox", true).FirstOrDefault().BackColor =
                form.Controls.Find("Shortcut2Textbox", true).FirstOrDefault().BackColor =
                Properties.Settings.Default.AppColourBg;

            form.Controls.Find("MenuPanel", true).FirstOrDefault().BackColor =
                form.Controls.Find("GoButton", true).FirstOrDefault().BackColor =
                form.Controls.Find("RerollButton", true).FirstOrDefault().BackColor =
                form.Controls.Find("SaveButton", true).FirstOrDefault().BackColor =
                Properties.Settings.Default.AppColourMenu;

            form.Controls.Find("TitleLabel", true).FirstOrDefault().BackColor =
                form.Controls.Find("TitleLabel2", true).FirstOrDefault().BackColor =
                form.Controls.Find("TitleLabel3", true).FirstOrDefault().BackColor =
                form.Controls.Find("MinimiseLabel", true).FirstOrDefault().BackColor =
                form.Controls.Find("MinimiseLabel2", true).FirstOrDefault().BackColor =
                form.Controls.Find("MinimiseLabel3", true).FirstOrDefault().BackColor =
                form.Controls.Find("CloseLabel", true).FirstOrDefault().BackColor =
                form.Controls.Find("CloseLabel2", true).FirstOrDefault().BackColor =
                form.Controls.Find("CloseLabel3", true).FirstOrDefault().BackColor =
                Properties.Settings.Default.AppColourMenuHover;


            Button GoButton = form.Controls.Find("GoButton", true).FirstOrDefault() as Button,
                SaveButton = form.Controls.Find("SaveButton", true).FirstOrDefault() as Button,
                RerollButton = form.Controls.Find("RerollButton", true).FirstOrDefault() as Button;

            form.ForeColor =
                form.Controls.Find("ErrorLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("ShowsList", true).FirstOrDefault().ForeColor =
                GoButton.ForeColor = GoButton.FlatAppearance.BorderColor =
                SaveButton.ForeColor = SaveButton.FlatAppearance.BorderColor =
                RerollButton.ForeColor = RerollButton.FlatAppearance.BorderColor =
                form.Controls.Find("AutoplayButton", true).FirstOrDefault().ForeColor =
                form.Controls.Find("TitleLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("TitleLabel2", true).FirstOrDefault().ForeColor =
                form.Controls.Find("TitleLabel3", true).FirstOrDefault().ForeColor =
                form.Controls.Find("MinimiseLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("MinimiseLabel2", true).FirstOrDefault().ForeColor =
                form.Controls.Find("MinimiseLabel3", true).FirstOrDefault().ForeColor =
                form.Controls.Find("MainDriveLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("MainDriveTextbox", true).FirstOrDefault().ForeColor =
                form.Controls.Find("BrowseMainButton", true).FirstOrDefault().ForeColor =
                form.Controls.Find("Shortcut1Label", true).FirstOrDefault().ForeColor =
                form.Controls.Find("Shortcut1Textbox", true).FirstOrDefault().ForeColor =
                form.Controls.Find("BrowseS1Button", true).FirstOrDefault().ForeColor =
                form.Controls.Find("Shortcut2Label", true).FirstOrDefault().ForeColor =
                form.Controls.Find("Shortcut2Textbox", true).FirstOrDefault().ForeColor =
                form.Controls.Find("BrowseS2Button", true).FirstOrDefault().ForeColor =
                form.Controls.Find("ThemeLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("MonolithLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("AzureLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("ForestLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("GhostLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("CastLabel", true).FirstOrDefault().ForeColor =
                form.Controls.Find("CastButton", true).FirstOrDefault().ForeColor =
                form.Controls.Find("VersionNumberLabel", true).FirstOrDefault().ForeColor =
                Properties.Settings.Default.AppColourText;

            SetThemeLabelFont(form, theme);

            form.Refresh();
        }

        public static void SetThemeLabelFont(MainForm form, AppTheme theme)
        {
            Label MonolithLabel = (Label)form.Controls.Find("MonolithLabel", true).FirstOrDefault(),
                AzureLabel = (Label)form.Controls.Find("AzureLabel", true).FirstOrDefault(),
                SwampLabel = (Label)form.Controls.Find("ForestLabel", true).FirstOrDefault(),
                GhostLabel = (Label)form.Controls.Find("GhostLabel", true).FirstOrDefault();

            MonolithLabel.Font = AzureLabel.Font = SwampLabel.Font = GhostLabel.Font = new Font(MonolithLabel.Font, FontStyle.Regular);
            switch (theme)
            {
                case AppTheme.Monolith:
                    MonolithLabel.Font = new Font(MonolithLabel.Font, FontStyle.Underline);
                    break;
                case AppTheme.Azure:
                    AzureLabel.Font = new Font(AzureLabel.Font, FontStyle.Underline);
                    break;
                case AppTheme.Forest:
                    SwampLabel.Font = new Font(SwampLabel.Font, FontStyle.Underline);
                    break;
                case AppTheme.Ghost:
                    GhostLabel.Font = new Font(GhostLabel.Font, FontStyle.Underline);
                    break;
                default:
                    break;
            }

        }

        public static void SetCurrentTab(MainForm form, AppTheme theme, AppTab currentTab)
        {
            Label HardDriveLabel = form.Controls.Find("HardDriveLabel", true).FirstOrDefault() as Label,
                PlayLabel = form.Controls.Find("PlayLabel", true).FirstOrDefault() as Label,
                OnlineLabel = form.Controls.Find("OnlineLabel", true).FirstOrDefault() as Label,
                SettingsLabel = form.Controls.Find("SettingsLabel", true).FirstOrDefault() as Label,
                TitleLabel = form.Controls.Find("TitleLabel", true).FirstOrDefault() as Label;

            if (theme == AppTheme.Azure)
            {
                HardDriveLabel.Image = Properties.Resources.hard_drive_icon;
                PlayLabel.Image = Properties.Resources.play_icon;
                OnlineLabel.Image = Properties.Resources.online_icon;
                SettingsLabel.Image = Properties.Resources.settings_icon;
            }
            else if (theme == AppTheme.Forest || theme == AppTheme.Ghost)
            {
                HardDriveLabel.Image = currentTab == AppTab.HardDrive ? Properties.Resources.hard_drive_icon_alt : Properties.Resources.hard_drive_icon;
                PlayLabel.Image = currentTab == AppTab.Player ? Properties.Resources.play_icon_alt : Properties.Resources.play_icon;
                OnlineLabel.Image = currentTab == AppTab.Online ? Properties.Resources.online_icon_alt : Properties.Resources.online_icon;
                SettingsLabel.Image = currentTab == AppTab.Settings ? Properties.Resources.settings_icon_alt : Properties.Resources.settings_icon;
            }
            else if (theme == AppTheme.Monolith)
            {
                HardDriveLabel.Image = currentTab == AppTab.HardDrive ? Properties.Resources.hard_drive_icon : Properties.Resources.hard_drive_icon_alt;
                PlayLabel.Image = currentTab == AppTab.Player ? Properties.Resources.play_icon : Properties.Resources.play_icon_alt;
                OnlineLabel.Image = currentTab == AppTab.Online ? Properties.Resources.online_icon : Properties.Resources.online_icon_alt;
                SettingsLabel.Image = currentTab == AppTab.Settings ? Properties.Resources.settings_icon : Properties.Resources.settings_icon_alt;
            }

            HardDriveLabel.BackColor = PlayLabel.BackColor = OnlineLabel.BackColor = SettingsLabel.BackColor = Color.Transparent;
            switch (currentTab)
            {
                case AppTab.HardDrive:
                    HardDriveLabel.BackColor = Properties.Settings.Default.AppColourHighlight;
                    TitleLabel.Text = "Drive";
                    break;
                case AppTab.Player:
                    PlayLabel.BackColor = Properties.Settings.Default.AppColourHighlight;
                    break;
                case AppTab.Online:
                    OnlineLabel.BackColor = Properties.Settings.Default.AppColourHighlight;
                    TitleLabel.Text = "Online";
                    break;
                case AppTab.Settings:
                    SettingsLabel.BackColor = Properties.Settings.Default.AppColourHighlight;
                    break;
            }
        }
    }

    public enum AppTab
    {
        HardDrive,
        Player,
        Online,
        Settings
    }

    public enum AppTheme
    {
        Monolith,
        Azure,
        Forest,
        Ghost,
    }
}
