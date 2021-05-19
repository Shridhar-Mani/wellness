using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wellness_Craft.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {

        function fn = new function();
        string query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userRole = txtUserRole.Text;
            string name = txtName.Text;
            string dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtMobileNumber.Text);
            string email = txtEmailAddress.Text;
            string username = txtUserName.Text;
            string pass = txtPassword.Text;

            try
            {
                query = "insert into users(userRole,name,dob,mobile,email,username,pass) values ('" + userRole + "','" + name + "','" + dob + "','" + mobile + "','" + email + "','" + username + "','" + pass + "')";
                fn.SetData(query, "Sign Up Successful.");
            }
            catch (Exception)
            {
                MessageBox.Show("username Allready exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {


        }


        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtName.Clear();
            txtDOB.ResetText();
            txtUserRole.SelectedIndex = -1;
            txtEmailAddress.Clear();
            txtMobileNumber.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtUserName.Text + "'";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count==0)
            {
                pictureBox1.ImageLocation = @"C:\Users\user\Downloads\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\user\Downloads\Pharmacy Management System in C#\no.png";
            }
        }

        private void txtDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }



}
