﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness_Craft.AdministratorUC;

namespace Wellness_Craft
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count==0)
            {
                if (txtUsername.Text=="root" && txtPassword.Text=="root")
                {
                    Adminstrator admin = new Adminstrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username ='" + txtUsername.Text + "'and pass = '" + txtPassword.Text + "'";
                ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role=="Administrator")
                    {
                        Adminstrator admin = new Adminstrator(txtUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role== "Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



















            /*if (txtUsername.Text=="shrimani" && txtPassword.Text=="shri12")
            {
                Adminstrator am = new Adminstrator();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
