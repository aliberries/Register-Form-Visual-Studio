using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Array_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                comboBox2.Items.Add(day);
                comboBox2.Text = "-Day-";
            }
            for (int year = 1900; year <= 2020; year++)
            {
                comboBox3.Items.Add(year);
                comboBox3.Text = "-Year-";
            }
            String[] months_array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (String month in months_array)
            {
                comboBox1_Array.Items.Add(month);
            }
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        String gender;
        private void button1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                gender = "Male";
            }
            else if (rbtn2.Checked)
            {
                gender = "Female";
            }
            string firstname;
            string lastname;
            string middlename;
            firstname = textBox2.Text;
            lastname = textBox1.Text;
            middlename = textBox3.Text;
            MessageBox.Show("Student Name: " + lastname + " " + firstname + " " + middlename + "\n" + "Gender: " + gender + "\n" + "Date of Birth: " + comboBox2.Text + "/" + comboBox1_Array.Text + "/" + comboBox3.Text + "\n" + "Program: " + comboBox4_ArrayList.Text);
        }
    }
}
