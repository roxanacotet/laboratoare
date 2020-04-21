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
    public partial class ResultsForm : Form
    {
        public static PhotoModel selectedPhoto;
        public static int photoID;
        public ResultsForm()
        {
            InitializeComponent();
            if (SearchForm.resultList.Count == 0)
            {
                MessageBox.Show("No result were found!");
            }
            else
            {
                for (var i = 0; i < SearchForm.resultList.Count; i++)
                {
                    resultListBox.Items.Add(SearchForm.resultList.ElementAt(i).Name.ToString());
                    photoID = SearchForm.resultList.ElementAt(i).Id;
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            (new SearchForm()).Show();
            this.Hide();
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPhoto = new PhotoModel();
            selectedPhoto.Name = resultListBox.SelectedItem.ToString();
                (new ViewDetailForm()).Show();
                this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
