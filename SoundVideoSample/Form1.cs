using System;
using System.Windows.Forms;

namespace SoundVideoSample
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer mediaPlayer1 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer mediaPlayer2 = new WMPLib.WindowsMediaPlayer();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private System.Media.SoundPlayer player = null;

        public Form1()
        {
            InitializeComponent();

            mediaPlayer1.uiMode = "none";
            mediaPlayer1.stretchToFit = true;

            mediaPlayer2.uiMode = "none";
            mediaPlayer2.stretchToFit = true;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)  //マウスの左ボタン
            //{
            //    if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        string fileName = this.openFileDialog1.FileName;
            //        mediaPlayer.uiMode = "none";
            //        mediaPlayer.URL = fileName;
            //    }
            //}
            //if (e.Button == MouseButtons.Right) //マウスの右ボタン
            //{   //再生を停止する
            //    mediaPlayer.controls.stop();
            //}
        }

        private void Sound1Play_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.openFileDialog.FileName;
                mediaPlayer1.uiMode = "none";
                mediaPlayer1.URL = fileName;
            }
        }


        private void Sound2Play_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.openFileDialog.FileName;
                mediaPlayer2.uiMode = "none";
                mediaPlayer2.URL = fileName;
            }
        }

        private void Sound1Stop_Click(object sender, EventArgs e)
        {
            mediaPlayer1.controls.stop();
        }

        private void Sound2Stop_Click(object sender, EventArgs e)
        {
            mediaPlayer2.controls.stop();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    string fileName = this.openFileDialog1.FileName;
            //    axWindowsMediaPlayer1.uiMode = "none";
            //    axWindowsMediaPlayer1.URL = fileName;
            //}
            //axWindowsMediaPlayer1.Visible = true;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.openFileDialog.FileName;
                player = new System.Media.SoundPlayer(fileName);
                player.Play();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }

        private void VideoPlay_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.openFileDialog.FileName;
                axWindowsMediaPlayer1.uiMode = "none";
                axWindowsMediaPlayer1.URL = fileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void VideoStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void VideoPause_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.status.Contains("再生中"))
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                VideoPause.Text = "ビデオ　レジューム";
                return;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
            VideoPause.Text = "ビデオ　ポーズ";
        }
    }
}
