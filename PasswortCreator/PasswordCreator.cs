using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordCreator
{
    public partial class PasswordCreatorDialog : Form
    {
        Random rnd;
        string UppercaseChar = "ABCDEFGHIJKMNOPQRSTUVWX";
        string UppercaseCharYZ = "ILOYZ";
        string NumbersCharZero = "0";
        string Numbers = "123456789";
        string Special = "!?=+*&$#";

        public PasswordCreatorDialog()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private string GetCharFrom(string CharSet)
        {
            return CharSet.Substring(rnd.Next(CharSet.Length),1);
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            string UppercaseCharSet;
            string NumberCharSet;
            string LowercaseCharSet;
            string SpecialCharSet;
            string AllCharSet;
            string Password;
            bool   CorrectPassword;

            UppercaseCharSet = UppercaseChar;

            SpecialCharSet = this.txtSpecial.Text;
            int iLength = (int) this.numLength.Value;

            NumberCharSet = Numbers;
            if (cbYZ.Checked)
            {
                UppercaseCharSet += UppercaseCharYZ;
                NumberCharSet += NumbersCharZero;
            }
            LowercaseCharSet = UppercaseCharSet.ToLower(System.Globalization.CultureInfo.GetCultureInfo("de-CH"));

            AllCharSet = UppercaseCharSet + SpecialCharSet;
            if (cbNumbers.Checked)
                AllCharSet += Numbers;

            int iInterations = 0;
            do // try until we have a correct password
            {
                bool hasLowercase = false;
                bool hasNumber = false;
                bool hasSpecial = false;

                Password = GetCharFrom(UppercaseCharSet);
                for (int i = 1; i < iLength; i++)
                {
                    string c;
                    c = GetCharFrom(AllCharSet);

                    if (cbInclLowercase.Checked)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            c = c.ToLower();
                        }
                    }

                    if (LowercaseCharSet.Contains(c)) hasLowercase = true;
                    if (Numbers.Contains(c)) hasNumber = true;
                    if (SpecialCharSet.Contains(c)) hasSpecial = true;

                    Password += c;
                }
                CorrectPassword = true; // assume it's good

                if (cbInclLowercase.Checked && !hasLowercase) CorrectPassword = false;
                if (cbNumbers.Checked && !hasNumber) CorrectPassword = false;
                if (SpecialCharSet.Length > 0 && !hasSpecial) CorrectPassword = false;

                iInterations++;
            } while (!CorrectPassword && iInterations < 1000);

            if (!CorrectPassword)
            {
                MessageBox.Show("Cannot generate such a password after 1000 interations. Pls. change settings or retry", "No password created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.txtPassword.Text = Password;
            Clipboard.SetText (Password);
        }

        private void PasswordCreator_Load(object sender, EventArgs e)
        {
            Config cnf = new Config();

            this.UppercaseChar = cnf.UppercaseChar;
            this.UppercaseCharYZ = cnf.UppercaseCharYZ;
            this.Special = cnf.Special;
            this.Numbers = cnf.Numbers;
            this.NumbersCharZero = cnf.NumbersZero;

            this.numLength.Value = cnf.Length;
            this.txtSpecial.Text = Special;
        }

    }
}