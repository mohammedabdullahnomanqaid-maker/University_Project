using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Project_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int counter = 0;
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            picFlag.Image = Properties.Resources.taiz_university;
            picSubmit.Image = Properties.Resources.addIcon;
            picEdit.Image = Properties.Resources.editIcon;
            picDelete.Image = Properties.Resources.deleteIcon;
            picStudent.Image = Properties.Resources.male;
            picMaleIcon.Image = Properties.Resources.male;
            picFemalIcon.Image = Properties.Resources.femal;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblClock.Text= DateTime.Now.ToString("hh:mm tt",CultureInfo.InvariantCulture);

        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            counter++;
            lbNumberOfStudent.Text = counter.ToString();
            tbName.Focus();
            string Gender;
      
            ListViewItem item = new ListViewItem(counter.ToString());
            if (rbMale.Checked)
            {
                item.ImageIndex = 1;
                Gender = "Male";
            }
            else
            {
                item.ImageIndex = 0;
                Gender = "Femal";
            }


            item.SubItems.Add(tbName.Text.Trim());
            item.SubItems.Add(cbMajor.SelectedItem.ToString());
            item.SubItems.Add(Gender.Trim());
            item.SubItems.Add(cbCity.SelectedItem.ToString());
            item.SubItems.Add(tbAge.Text.Trim());
            item.SubItems.Add(dtpRegister.Text.ToString());
            

            listView1.Items.Add(item);

            tbName.Focus();
            tbName.Clear();
            tbAge.Clear();
            cbCity.SelectedItem = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbView.SelectedItem.ToString())
            {
                case "Details":
                    listView1.View = View.Details;
                    break;

                case "List":
                    listView1.View = View.List;
                    break;

                case "Tile":
                    listView1.View = View.Tile;
                    break;

                case "Small Icon":
                    listView1.View = View.SmallIcon;
                    break;

                case "Large Icon":
                    listView1.View = View.LargeIcon;
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count>0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                counter--;
                lbNumberOfStudent.Text = counter.ToString();

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Gender;

            if (listView1.SelectedItems.Count > 0)
            {


                ListViewItem item = listView1.SelectedItems[0];





                lbName.Text = item.SubItems[1].Text;
                lbMajor.Text = item.SubItems[2].Text;
                lbGender.Text = item.SubItems[3].Text;
                lbCity.Text = item.SubItems[4].Text;
                lbAge.Text = item.SubItems[5].Text;
                lbRegisterDate.Text = item.SubItems[6].Text;
                picStudent.Image = listView1.LargeImageList.Images[item.ImageIndex];

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Gender;


            if (listView1.SelectedItems.Count > 0)

            {


                ListViewItem item = listView1.SelectedItems[0];



                if (rbMale.Checked)
                {
                    item.ImageIndex = 1;
                    Gender = "Male";
                }
                else
                {
                    item.ImageIndex = 0;
                    Gender = "Femal";
                }


                item.SubItems[1].Text = tbName.Text;
                item.SubItems[2].Text = cbMajor.SelectedItem.ToString();
                item.SubItems[3].Text = Gender.Trim();
                item.SubItems[4].Text = cbCity.SelectedItem.ToString();
                item.SubItems[5].Text = tbAge.Text.Trim();

            }
            tbName.Text = "";
            tbAge.Text = "";
            tbName.Focus();
        }
    }
}
