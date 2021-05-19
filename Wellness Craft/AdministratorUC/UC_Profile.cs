using System;
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
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        String query;

        public UC_Profile()
        {
            InitializeComponent();
        }
        
        public String ID
        {
            set { txtusername.Text = value; }
        }



        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = '"+txtusername.Text+"'";
            DataSet ds = fn.GetData(query);
            txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDOB.Text = ds.Tables[0].Rows[0][3].ToString();
            txtmob.Text = ds.Tables[0].Rows[0][4].ToString();
            txtemail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtpassword.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtmob.Text);
            String email = txtemail.Text;
            String username = txtusername.Text;
            String pass = txtpassword.Text;

            query = "update users set userRole ='" + role + "', name = '" + name + "',dob = '" + dob + "',mobile = " + mobile + ",email ='" + email + "',pass ='" + pass + "' where username ='" + username + "'";
            fn.SetData(query, "Profile Updation Successfully.");
        }
    }
}
