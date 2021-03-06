﻿using System;
using System.Windows.Forms;

namespace POS
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 cashier = new Form2();
            cashier.Show();
            this.Hide();
            cashier.FormClosing += Cashier_Closing;
        }
        private void Cashier_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 userManagement = new Form4();
            userManagement.Show();
            this.Hide();
            userManagement.FormClosing += UserManagement_Closing;

        }
        private void UserManagement_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 registrationForm = new Form3();
            registrationForm.Show();
            this.Hide();
            registrationForm.FormClosing += RegistrationForm_Closing;
        }
        private void RegistrationForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 addMenu = new Form6();
            addMenu.Show();
            this.Hide();
            addMenu.FormClosing += AddMenu_Closing;
        }
        private void AddMenu_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 showProfile = new Form7();
            showProfile.Show();
            this.Hide();
            showProfile.FormClosing += ShowProfile_Closing;
        }
        private void ShowProfile_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
