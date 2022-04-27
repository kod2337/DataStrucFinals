using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStrucFinals
{
    public partial class Form1 : Form
    {
        private int autoID = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textUpdateNo.Text = MyListView.FocusedItem.SubItems[0].Text;
            textUpdateID.Text = MyListView.FocusedItem.SubItems[1].Text;
            textUpdateName.Text = MyListView.FocusedItem.SubItems[2].Text;
            textUpdateBirth.Text = MyListView.FocusedItem.SubItems[3].Text;
            textUpdateYear.Text = MyListView.FocusedItem.SubItems[4].Text;
            textUpdateCourse.Text = MyListView.FocusedItem.SubItems[5].Text;

            MyListView.View = View.Details;
            MyListView.GridLines = true;
            MyListView.FullRowSelect = true;

            
            MyListView.Columns.Add("ID No.", 100, HorizontalAlignment.Center);
            MyListView.Columns.Add("Name", 100, HorizontalAlignment.Center);
            MyListView.Columns.Add("Date of Birth", 100, HorizontalAlignment.Center);
            MyListView.Columns.Add("Year", 100, HorizontalAlignment.Center);
            MyListView.Columns.Add("Course/Program", 100, HorizontalAlignment.Center);

        }
        private void addtoListView(String idno, String name, String birth, String year, String course)
        {
            ListViewItem eachRow = new ListViewItem("" + autoID);
            ListViewItem.ListViewSubItem rowidno = new ListViewItem.ListViewSubItem(eachRow, idno);
            ListViewItem.ListViewSubItem rowname = new ListViewItem.ListViewSubItem(eachRow, name);
            ListViewItem.ListViewSubItem rowbirth = new ListViewItem.ListViewSubItem(eachRow, birth);
            ListViewItem.ListViewSubItem rowyear = new ListViewItem.ListViewSubItem(eachRow, year);
            ListViewItem.ListViewSubItem rowcourse = new ListViewItem.ListViewSubItem(eachRow, course);

            eachRow.SubItems.Add(idno);
            eachRow.SubItems.Add(name);
            eachRow.SubItems.Add(birth);
            eachRow.SubItems.Add(year);
            eachRow.SubItems.Add(course);


            MyListView.Items.Add(eachRow);
            this.autoID++;
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string userID = this.txtIdNo.Text.ToString();
            string userName = this.txtName.Text.ToString();
            string userBirth = this.txtBirth.Text.ToString();
            string userYear = this.txtYear.Text.ToString();
            string userCourse = this.txtCourse.Text.ToString();
            
            if((userID.Length >1) && (userName.Length > 1) && (userBirth.Length>1) && (userYear.Length > 1) && (userCourse.Length > 1))
            {
            addtoListView(userID, userName, userBirth, userYear, userCourse);

            }
            else
                MessageBox.Show("Please enter the following details: ");

        }

        private void txtIdNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textUpdateNo.Text);
            int index = id - 1;

            MyListView.Items[index].SubItems[1].Text = textUpdateID.Text;
            MyListView.Items[index].SubItems[2].Text = textUpdateName.Text;
            MyListView.Items[index].SubItems[3].Text = textUpdateBirth.Text;
            MyListView.Items[index].SubItems[4].Text = textUpdateYear.Text;
            MyListView.Items[index].SubItems[5].Text = textUpdateCourse.Text;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textUpdateNo.Text);
            int index = id - 1;
            MyListView.Items[index].Remove();
        }
    }
}
