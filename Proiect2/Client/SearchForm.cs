using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotosManagerApi.Controllers;
using MyPhotosManagerWCFService.Models;

namespace MyPhotosManagerApp
{
    public partial class SearchForm : Form
    {
        InterfaceMyPhotoManagerClient client = new InterfaceMyPhotoManagerClient();
        public static List<PhotoModel> resultList = new List<PhotoModel>();
        public static RadioButton selectedrb;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            resultList = new List<PhotoModel>();
            if(searchTextBox.Text == null)
            {
                MessageBox.Show("Please add something!");
            }
                if(client.SearchPhotoByName(searchTextBox.Text).Length != 0)
                {
                    for(var i = 0; i < client.SearchPhotoByName(searchTextBox.Text).Length; i++)
                    {
                        var photo = client.SearchPhotoByName(searchTextBox.Text);
                        if(photo.ElementAt(i).IsDeleted == false) 
                        { 
                             resultList.Add(photo.ElementAt(i)); 
                        }
                       
                    }
                }
                if (client.SearchByLocation(searchTextBox.Text).Length != 0)
                {
                    for (var i = 0; i < client.SearchByLocation(searchTextBox.Text).Length; i++)
                    {
                        var photo = client.SearchByLocation(searchTextBox.Text);
                        if (photo.ElementAt(i).IsDeleted == false)
                        {
                            resultList.Add(photo.ElementAt(i));
                        }
                    }
                }
                if (client.SearchByCreationDate(searchTextBox.Text).Length != 0)
                {
                    for (var i = 0; i < client.SearchByCreationDate(searchTextBox.Text).Length; i++)
                    {
                        var photo = client.SearchByCreationDate(searchTextBox.Text);
                        if (photo.ElementAt(i).IsDeleted == false)
                        {
                            resultList.Add(photo.ElementAt(i));
                        }
                    }
                }
                if (client.SearchEventByName(searchTextBox.Text).Length != 0)
                {
                    for (var i = 0; i < client.SearchEventByName(searchTextBox.Text).Length; i++)
                    {
                        var events = client.SearchEventByName(searchTextBox.Text);
                        var photo = client.GetPhotoByID(events.ElementAt(i).Id);
                        if(photo.IsDeleted == false)
                        {
                            resultList.Add(photo);
                        } 
                    }
                }
                if (client.SearchPeopleByName(searchTextBox.Text).Length != 0)
                {
                    for (var i = 0; i < client.SearchPeopleByName(searchTextBox.Text).Length; i++)
                    {
                        var people = client.SearchPeopleByName(searchTextBox.Text);
                        var photo = client.GetPhotoByID(people.ElementAt(i).Id);
                        if (photo.IsDeleted == false)
                        {
                            resultList.Add(photo);
                        }
                    }
                }
                if (client.SearchByKey(searchTextBox.Text).Length != 0)
                {
                    for (var i = 0; i < client.SearchByKey(searchTextBox.Text).Length; i++)
                    {
                        var people = client.SearchByKey(searchTextBox.Text);
                        var photo = client.GetPhotoByID(people.ElementAt(i).Id);
                        if (photo.IsDeleted == false)
                        {
                            resultList.Add(photo);
                        }
                    }
                }
                if (client.SearchByValue(searchTextBox.Text).Length != 0)
                {
                    for (var i = 0; i < client.SearchByValue(searchTextBox.Text).Length; i++)
                    {
                        var people = client.SearchByValue(searchTextBox.Text);
                        var photo = client.GetPhotoByID(people.ElementAt(i).Id);
                        if (photo.IsDeleted == false)
                        {
                            resultList.Add(photo);
                        }
                    }
                }
            (new ResultsForm()).Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            (new FirstForm()).Show();
            this.Hide();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {        
        }

        private void isVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (isVideo.Checked)
            {
                UploadForm.selectedrb = isVideo;
            }
        }

        private void isPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if (isPhoto.Checked)
            {
                UploadForm.selectedrb = isPhoto;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
