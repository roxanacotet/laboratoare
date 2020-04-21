using MyPhotosManagerApi.Controllers;
using MyPhotosManagerWCFService.Models;
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
    public partial class EditForm : Form
    {
        InterfaceMyPhotoManagerClient client = new InterfaceMyPhotoManagerClient();
        public EditForm()
        {
            InitializeComponent();
            setEditForm();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            (new ViewDetailForm()).Show();
            this.Hide();
        }

        public void setEditForm()
        {
            nameEditTextBox.Text = ViewDetailForm.editedPhoto.Name;
            locationEditTextBox.Text = ViewDetailForm.editedPhoto.Location;
            var events = client.GetEventByPhotoId(ViewDetailForm.editedPhoto.Id);
            if(events.Name != null)
            {
                eventEditTextBox.Text = events.Name;
            }
            else
            {
                throw new NullReferenceException();
            }
          
            var people = client.GetPeopleByPhotoId(ViewDetailForm.editedPhoto.Id);
            if(people.Name != null)
            {
                peoplesEditTextBox.Text = people.Name;
            }
           
            var detail = client.GetDetailsByPhotoId(ViewDetailForm.editedPhoto.Id);
            if (detail != null)
            {
                keyDetailEdit.Text = detail.DetailKey;
                valueEdit.Text = detail.DetailValue;
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            PhotoModel updatePhoto = new PhotoModel()
            {
                Name = nameEditTextBox.Text,
                Location = locationEditTextBox.Text
            };

            EventModel updatedEvent = new EventModel()
            {
                Name = eventEditTextBox.Text,
                IdPhoto = ViewDetailForm.editedPhoto.Id
            };

            PeopleModel peopleUpdate = new PeopleModel()
            {
                Name = peoplesEditTextBox.Text,
                IdPhoto = ViewDetailForm.editedPhoto.Id
            };

            DetailModel detailUpdate = new DetailModel()
            {
                DetailKey = keyDetailEdit.Text,
                DetailValue = valueEdit.Text,
                IdPhoto = ViewDetailForm.editedPhoto.Id
            };

            client.UpdatePhoto(updatePhoto);
            client.UpdateEvent(updatedEvent);
            client.UpdatePeople(peopleUpdate);
            client.UpdateDetail(detailUpdate);
            MessageBox.Show("Updated successfully!");
        }

        private void nameEditTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
