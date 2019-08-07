using SharpCaster.Models;
using SharpCaster.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTvShow
{
    public partial class CastingOptions : Form
    {
        public CastingOptions()
        {
            InitializeComponent();
            this.DeviceNameLabel.Text = Properties.Settings.Default.ChromecastName;
        }

        private async void ScanButton_Click(object sender, EventArgs e)
        {
            this.ScanButton.Enabled = false;
            this.ScanningLabel.Visible = true;

            var chromecasts = await ChromecastService.Current.StartLocatingDevices(MainForm.GetLocalIPAddress());
            this.DeviceDataGrid.DataSource = chromecasts;
            this.DeviceDataGrid.Update();

            this.ScanningLabel.Visible = false;
            this.ScanButton.Enabled = true;
        }

        private void DeviceDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            this.SetDeviceButton.Enabled = DeviceDataGrid.SelectedRows != null;
        }

        private void SetDeviceButton_Click(object sender, EventArgs e)
        {
            var chromecast = (Chromecast)DeviceDataGrid.SelectedRows[0].DataBoundItem;
            Properties.Settings.Default.ChromecastName = chromecast.FriendlyName;
            Properties.Settings.Default.ChromecastURI = chromecast.DeviceUri;
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
