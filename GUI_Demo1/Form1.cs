using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI_Demo1
{
    public partial class Form1 : Form
    {
        //Defaut Constructor
        public Form1()
        {
            InitializeComponent();
        }
        //Form Load Event
        //private - only that class will only call that event 
        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String Result;
            Result = "\n Your Name is " + txtName.Text;
            Result = "\n Your Address is " + txtAddress.Text;
            Result = "\n Your Email Id is " + txtEmailId.Text;
            Result = "\n Your Password is " + txtPassword.Text;
            if (chkGraduate.Checked)
                Result += "\nYour are qualified as " + chkGraduate.Text;
            if (chkMasters.Checked)
                Result += "\nYour are qualified as " + chkMasters.Text;
            if (chkPhd.Checked)
                Result += "\nYour are qualified as " + chkGraduate.Text;
            if (rdFemale.Checked)
                Result += "\nYour Gender is " + rdFemale.Text;
            else
                Result += "\nYour Gender is " + rdMale.Text;

            Result += "\nYou stay in " + cmbCity.SelectedItem.ToString();
            lblResult.Text = Result;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblTITTLE_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(txtName.Text == "")
            {
                errorProvider1.SetError(txtName,"Please Enter Valid Value");
            }
            else
            {
                errorProvider1.SetError(txtName, "");
            }
        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                errorProvider2.SetError(txtAddress, "Please Enter Valid Address");
            }
            else
            {
                errorProvider2.SetError(txtAddress, "");
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider3.SetError(txtPassword, "Please enter correct Password");
            }
            else if (!Regex.IsMatch(txtPassword.Text,@"[Aa-zZ]{0}"))
            {
                errorProvider3.SetError(txtPassword, "Minimum length must be 8");
            }
            else
            {
                errorProvider3.SetError(txtPassword, "");
            }
        }
        
        private void txtEmailId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailId.Text))
            {
                errorProvider4.SetError(txtEmailId, "Please enter correct Email");
            }
            else if (!Regex.IsMatch(txtEmailId.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                errorProvider4.SetError(txtEmailId, "Email must be in correct format");
            }
            else
            {
                errorProvider4.SetError(txtEmailId, "");
            }
        }
    }
    }
