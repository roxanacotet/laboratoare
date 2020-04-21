using MyPhotosManagerWCFService.Models;
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

namespace MyPhotosManagerApp
{
    public partial class UploadForm : Form
    {
        InterfaceMyPhotoManagerClient client = new InterfaceMyPhotoManagerClient();
        public static RadioButton selectedrb;
        private String creationDate;
        private bool result;
        public UploadForm()
        {
            InitializeComponent();
        }

        private void isPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if (isPhoto.Checked)
            {
                selectedrb = isPhoto;
            }
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select image to be upload.";
            openFileDialog1.Filter = "Image and Video Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png, *.mp4)|*.jpg; *.jpeg; *.gif; *.bmp; *.png, *.mp4";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (selectedrb == isPhoto) {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (openFileDialog1.CheckFileExists)
                        {
                            string path = Path.GetFullPath(openFileDialog1.FileName);
                            pathTextBox.Text = path;
                            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            FileInfo file = new FileInfo(openFileDialog1.FileName);
                            creationDate = file.CreationTime.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Upload image or video.");
                    }
                }
                else
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = Path.GetFullPath(openFileDialog.FileName);
                        pathTextBox.Text = path;
                        FileInfo file = new FileInfo(openFileDialog1.FileName);
                        creationDate = file.CreationTime.ToString();
                    }
                }
            }  
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid image.");
                }
                else
                { 
                    client.CreatePhoto(setPhoto());
                    client.CreateEvent(setEvent());
                    client.CreatePeople(setPeople());
                    MessageBox.Show("Image uploaded successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Already exits");
            }
        }

        private void isVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (isVideo.Checked)
            {
                selectedrb = isVideo;
            }
        }

        public PhotoModel setPhoto()
        { 
            if(selectedrb == isVideo)
            {
                 result = true;
            }
            else
            {
                 result = false;
            }
            var photo = new PhotoModel()
            {
                Name = nameTextBox.Text,
                Path = pathTextBox.Text,
                Location = locationTextBox.Text,
                CreationDate = creationDate,
                IsVideo = result,
                IsDeleted = false 
            };
            return photo;
        }
        public EventModel setEvent()
        {
            var events = new EventModel()
            {
                Name = eventTextBox.Text,
                IdPhoto = setPhoto().Id
            };

            return events;
        }

        public PeopleModel setPeople()
        {
            var people = new PeopleModel()
            {
                Name = peoplesTextBox.Text,
                IdPhoto = setPhoto().Id
            };

            return people;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            (new FirstForm()).Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
