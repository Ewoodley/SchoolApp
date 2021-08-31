﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPushtoTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = txtName.Text;
            testSchool.Address = txtAddress.Text;
            testSchool.City = txtCity.Text;
            testSchool.State = txtState.Text;
            testSchool.Zip = txtZip.Text;
            testSchool.PhoneNumber = txtPhone.Text;
            try
            {

                testSchool.TwitterAddress = txtTwitter.Text;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            
            MessageBox.Show(testSchool.ToString());

            var teacher = new Teacher(); //for test only
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show("The Teacher Grade Average is " + gp);

        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var gp1 = student.ComputeGradeAverage();
            MessageBox.Show("The Student Grade Point is " + gp1);
        }
    }
}