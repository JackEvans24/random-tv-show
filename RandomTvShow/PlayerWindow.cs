using System;
using System.Windows.Forms;

namespace RandomTvShow
{
    public partial class PlayerWindow : Form
    {
        Timer timer = new Timer();

        public PlayerWindow(string filepath)
        {
            InitializeComponent();
            Show();
            ShowPlayer.openPlayer(filepath);

            ShowPlayer.settings.autoStart = true;
            var show = ShowPlayer.newMedia(filepath);

            timer.Tick += Timer_Tick;
            timer.Interval = (int)(show.duration * 1000) + 1;

            ShowPlayer.currentMedia = show;

            while (ShowPlayer.openState != WMPLib.WMPOpenState.wmposMediaOpen || ShowPlayer.playState != WMPLib.WMPPlayState.wmppsPlaying) { }
            timer.Start();

            ShowPlayer.fullScreen = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ShowPlayer.playState != WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                timer.Stop();
                timer.Interval = (int)(ShowPlayer.currentMedia.duration - ShowPlayer.Ctlcontrols.currentPosition);
                timer.Start();
            }
            else
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
        }
    }
}
