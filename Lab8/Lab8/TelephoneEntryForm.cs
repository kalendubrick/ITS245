using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab8
{
    public partial class TelephoneEntryForm : Form
    {
        private ArrayList telephones;
        private Telephone telephone;
        private string numberToDial;

        public TelephoneEntryForm()
        {
            InitializeComponent();
            telephones = new ArrayList();
            // wire the buttons
            btnEnter.Click += btnEnter_Click;
            btnDial.Click += btnDial_Click;
            btnRedial.Click += btnRedial_Click;
            btnHangUp.Click += btnHangUp_Click;
            btnShowPhones.Click += btnShowPhones_Click;
        }

        private void TelephoneEntryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            telephone = new Telephone();
            telephone.Manufacturer = txtManufacturer.Text;
            telephone.Model = txtModel.Text;
            telephone.PhoneNumber = txtPhoneNum.Text;
            numberToDial = txtNumberToDial.Text;

            // save the object to the ArrayList
            telephones.Add(telephone);

            // display the data
            txtOutput.Text = telephone.ToString() + Environment.NewLine +
                                "Phone # to dial: " + numberToDial;

            // clear the fields
            txtManufacturer.Clear();
            txtModel.Clear();
            txtPhoneNum.Clear();
            txtNumberToDial.Clear();
        }

        private void btnDial_Click(object sender, EventArgs e)
        {
            txtOutput.Text = telephone.dial(numberToDial);
        }

        private void btnRedial_Click(object sender, EventArgs e)
        {
            txtOutput.Text = telephone.redial();
        }

        private void btnHangUp_Click(object sender, EventArgs e)
        {
            txtOutput.Text = telephone.hangUp();
        }

        private void btnShowPhones_Click(object sender, EventArgs e)
        {
            TelephoneListForm showPhonesForm = new TelephoneListForm();
            
            // populate the textbox with the phone info
            for (int i = 0; i < telephones.Count; i++)
            {
                showPhonesForm.txtPhonesEntered.AppendText("=== Telephone " + (i + 1).ToString() + " ===" + Environment.NewLine);
                showPhonesForm.txtPhonesEntered.AppendText(telephones[i].ToString());
                showPhonesForm.txtPhonesEntered.AppendText(Environment.NewLine);
            }
            showPhonesForm.txtPhonesEntered.AppendText("A total of " + telephones.Count.ToString() + " telephones.");

            // show the form
            showPhonesForm.Show();
        }
    }
}
