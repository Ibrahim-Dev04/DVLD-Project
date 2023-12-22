using PersonBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class ctrlFindPersonBy : UserControl
    {
        public ctrlFindPersonBy()
        {
            InitializeComponent();
        }

        private void ctrlFilterPersonBy_Load(object sender, EventArgs e)
        {

        }

        private void TbFilterByValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void TbFilterByValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            string FilterBy = CbFilterBy.SelectedItem.ToString();
            switch (FilterBy)
            {

                case "Person ID":
                    {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "National No":
                    {
                        if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "First Name":
                case "Second Name":
                case "Third Name":
                case "Last Name":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                            e.Handled = true;
                    }
                    break;
                case "Gender":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "Date Of Birth":
                    {
                        if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case "Nationality":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != ((char)Keys.Space) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "Phone":
                    {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "Email":
                    {
                        if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
