using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosManagerApp
{
    public partial class VideoPlayer : Form
    {
        InterfaceMyPhotoManagerClient client = new InterfaceMyPhotoManagerClient();
        public VideoPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new ResultsForm()).Show();
            this.Hide();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = client.GetPhotoByID(ResultsForm.photoID).Path;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = client.GetPhotoByID(ResultsForm.photoID).Path;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void MyPhotos_Click(object sender, EventArgs e)
        {

        }
    }
}
