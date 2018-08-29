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
        public static void SetTheme(Form1 form, AppTheme theme)
        {
            Properties.Settings.Default.ThemeIndex = (int)theme;

            Label closeLabel = form.Controls.Find("CloseLabel", true).FirstOrDefault() as Label,
                closeLabel2 = form.Controls.Find("CloseLabel2", true).FirstOrDefault() as Label;
            switch (theme)
            {
                case AppTheme.Monolith:
                    Properties.Settings.Default.AppColourBg = Color.Gray;
                    Properties.Settings.Default.AppColourMenu = Color.DimGray;
                    Properties.Settings.Default.AppColourHighlight = Color.Silver;
                    Properties.Settings.Default.AppColourText = Color.WhiteSmoke;
                    closeLabel.Image = closeLabel2.Image = Properties.Resources.close_icon_alt;
                    break;

                case AppTheme.Forest:
                    Properties.Settings.Default.AppColourBg = Color.PaleGreen;
                    Properties.Settings.Default.AppColourMenu = Color.LightGreen;
                    Properties.Settings.Default.AppColourHighlight = Color.LimeGreen;
                    Properties.Settings.Default.AppColourText = Color.DarkGreen;
                    closeLabel.Image = closeLabel2.Image = Properties.Resources.close_icon;
                    break;

                default:
                    Properties.Settings.Default.AppColourBg = Color.Azure;
                    Properties.Settings.Default.AppColourMenu = Color.LightCyan;
                    Properties.Settings.Default.AppColourHighlight = Color.White;
                    Properties.Settings.Default.AppColourText = Color.DarkSlateGray;
                    closeLabel.Image = closeLabel2.Image = Properties.Resources.close_icon;
                    break;
            }

            Properties.Settings.Default.Save();

            form.BackColor =
                form.Controls.Find("ShowsList", true).FirstOrDefault().BackColor =
                form.Controls.Find("MainDriveTextbox", true).FirstOrDefault().BackColor =
                form.Controls.Find("Shortcut1Textbox", true).FirstOrDefault().BackColor =
                form.Controls.Find("Shortcut2Textbox", true).FirstOrDefault().BackColor =
                Properties.Settings.Default.AppColourBg;

            SplitContainer mainSplitContainer = form.Controls.Find("splitContainer3", true).FirstOrDefault() as SplitContainer;
            mainSplitContainer.Panel1.BackColor =
                form.Controls.Find("GoButton", true).FirstOrDefault().BackColor =
                form.Controls.Find("SaveButton", true).FirstOrDefault().BackColor =
                form.Controls.Find("CloseLabel", true).FirstOrDefault().BackColor =
                form.Controls.Find("CloseLabel2", true).FirstOrDefault().BackColor =
                Properties.Settings.Default.AppColourMenu;

            Button GoButton = form.Controls.Find("GoButton", true).FirstOrDefault() as Button,
                SaveButton = form.Controls.Find("SaveButton", true).FirstOrDefault() as Button;

            form.ForeColor =
                form.Controls.Find("ShowsList", true).FirstOrDefault().ForeColor =
                GoButton.ForeColor = GoButton.FlatAppearance.BorderColor =
                SaveButton.ForeColor = SaveButton.FlatAppearance.BorderColor =
                form.Controls.Find("AutoplayButton", true).FirstOrDefault().ForeColor =
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
                form.Controls.Find("VersionNumberLabel", true).FirstOrDefault().ForeColor =
                Properties.Settings.Default.AppColourText;

            SetThemeLabelFont(form, theme);

            form.Refresh();
        }

        public static void SetThemeLabelFont(Form1 form, AppTheme theme)
        {
            Label MonolithLabel = (Label)form.Controls.Find("MonolithLabel", true).FirstOrDefault(),
                AzureLabel = (Label)form.Controls.Find("AzureLabel", true).FirstOrDefault(),
                SwampLabel = (Label)form.Controls.Find("ForestLabel", true).FirstOrDefault();

            MonolithLabel.Font = AzureLabel.Font = SwampLabel.Font = new Font(MonolithLabel.Font, FontStyle.Regular);
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
                default:
                    break;
            }

        }

        public static void SetCurrentTab(Form1 form, AppTheme theme, AppTab currentTab)
        {
            Label HardDriveLabel = form.Controls.Find("HardDriveLabel", true).FirstOrDefault() as Label,
                OnlineLabel = form.Controls.Find("OnlineLabel", true).FirstOrDefault() as Label,
                SettingsLabel = form.Controls.Find("SettingsLabel", true).FirstOrDefault() as Label;

            if (theme == AppTheme.Azure)
            {
                HardDriveLabel.Image = Properties.Resources.hard_drive_icon;
                OnlineLabel.Image = Properties.Resources.online_icon;
                SettingsLabel.Image = Properties.Resources.settings_icon;
            }
            else if (theme == AppTheme.Forest)
            {
                HardDriveLabel.Image = currentTab == AppTab.HardDrive ? Properties.Resources.hard_drive_icon_alt : Properties.Resources.hard_drive_icon;
                OnlineLabel.Image = currentTab == AppTab.Online ? Properties.Resources.online_icon_alt : Properties.Resources.online_icon;
                SettingsLabel.Image = currentTab == AppTab.Settings ? Properties.Resources.settings_icon_alt : Properties.Resources.settings_icon;
            }
            else
            {
                HardDriveLabel.Image = currentTab == AppTab.HardDrive ? Properties.Resources.hard_drive_icon : Properties.Resources.hard_drive_icon_alt;
                OnlineLabel.Image = currentTab == AppTab.Online ? Properties.Resources.online_icon : Properties.Resources.online_icon_alt;
                SettingsLabel.Image = currentTab == AppTab.Settings ? Properties.Resources.settings_icon : Properties.Resources.settings_icon_alt;
            }

            HardDriveLabel.BackColor = OnlineLabel.BackColor = SettingsLabel.BackColor = Color.Transparent;
            switch (currentTab)
            {
                case AppTab.HardDrive:
                    HardDriveLabel.BackColor = Properties.Settings.Default.AppColourHighlight;
                    break;
                case AppTab.Online:
                    OnlineLabel.BackColor = Properties.Settings.Default.AppColourHighlight;
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
        Online,
        Settings
    }

    public enum AppTheme
    {
        Monolith,
        Azure,
        Forest
    }
}
