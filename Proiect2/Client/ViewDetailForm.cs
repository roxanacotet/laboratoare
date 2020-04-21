using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotosManagerWCFService.Models;

namespace MyPhotosManagerApp
{
    public partial class ViewDetailForm : Form
    {
        InterfaceMyPhotoManagerClient client = new InterfaceMyPhotoManagerClient();
        public static PhotoModel editedPhoto;
        public ViewDetailForm()
        {
            InitializeComponent();
            if(UploadForm.selectedrb.Text == "isPhoto")
            {
                var path = client.GetPhotoByID(ResultsForm.photoID).Path;
                pictureBox1.Image = new Bitmap(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                (new VideoPlayer()).Show();
                this.Hide();
            }
           
            photo_name.Text = client.GetPhotoByID(ResultsForm.photoID).Name;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            PhotoModel deletedPhoto = new PhotoModel();
            deletedPhoto = client.GetPhotoByID(ResultsForm.photoID);
            deletedPhoto.IsDeleted = true;
            client.UpdatePhoto(deletedPhoto);
            MessageBox.Show("Photo was deleted successfully!");
            (new FirstForm()).Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            (new ResultsForm()).Show();
            this.Hide();
        }

        private void photo_name_Click(object sender, EventArgs e)
        {
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
               FileStream fs =(FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.pictureBox1.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        this.pictureBox1.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            editedPhoto = new PhotoModel();
            editedPhoto = client.GetPhotoByID(ResultsForm.photoID);
            //(new EditForm()).Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
