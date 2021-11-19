using ShoppingFormAppT110.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingFormAppT110
{
    public partial class RegisterForm : Form
    {
        ShopDBT110Context db = new ShopDBT110Context();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPas = txtConfirmPas.Text;
            string[] myEmpty = new string[] { fullname, username, password, confirmPas };
            if (Utilities.IsEmpty(myEmpty))
            {
                User selectedUser = db.Users.FirstOrDefault(x => x.Username == username);
                if (selectedUser == null)
                {
                    if (password == confirmPas)
                    {
                        User newUser = new()
                        {
                            Fullname = fullname,
                            Username = username,
                            Password = password,
                            CreateDate = DateTime.Now
                        };
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        MessageBox.Show("User created successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        LoginForm lg = new LoginForm();
                        lg.ShowDialog();
                    }
                    else
                    {
                        lblError.Text = "Password and confirm password isn't same!";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "User alread exist!";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Please all the fill!";
                lblError.Visible = true;
            }
        }
    }
}
