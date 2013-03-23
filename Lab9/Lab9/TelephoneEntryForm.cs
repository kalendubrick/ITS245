using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab9
{
    public partial class TelephoneEntryForm : Form
    {
        private Telephone telephone;
        private string numberToDial, filePath, fileName = "";
        private FileStream fs;
        private BinaryWriter w;
        private BinaryReader r;

        public TelephoneEntryForm()
        {
            InitializeComponent();
            // wire the buttons
            btnSave.Click += btnSave_Click;
            btnDial.Click += btnDial_Click;
            btnRedial.Click += btnRedial_Click;
            btnHangUp.Click += btnHangUp_Click;
            btnShowPhones.Click += btnShowPhones_Click;
            this.FormClosing += TelephoneEntryForm_FormClosing;
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            dialToolStripMenuItem.Click += dialToolStripMenuItem_Click;
            redialToolStripMenuItem.Click += redialToolStripMenuItem_Click;
            hangUpToolStripMenuItem.Click += hangUpToolStripMenuItem_Click;
            phoneListToolStripMenuItem.Click += phonesToolStripMenuItem_Click;
        }

        private void TelephoneEntryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            telephone = new Telephone();

            telephone.Manufacturer = txtManufacturer.Text;
            telephone.Model = txtModel.Text;
            telephone.PhoneNumber = txtPhoneNum.Text;
            numberToDial = txtNumberToDial.Text;

            // have the user pick a file if they have not done so already
            if (fileName == "")
            {
                if (saveFileDialogTelephoneEntryForm.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialogTelephoneEntryForm.FileName;
                }
            }

            // open the file
            fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            w = new BinaryWriter(fs);
            // write the data to the file
            telephone.saveDataTo(w);
            // close the file in case we need to open for reading
            w.Close();
            fs.Close();

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
            int i = 0;

            TelephoneListForm showPhonesForm = new TelephoneListForm();

            if (openFileDialogTelephoneEntryForm.ShowDialog() == DialogResult.OK)
            {
                fs = (FileStream)openFileDialogTelephoneEntryForm.OpenFile();
                r = new BinaryReader(fs);

                while (r.BaseStream.Position < r.BaseStream.Length)
                {
                    telephone = new Telephone();
                    telephone.readDataFrom(r);
                    showPhonesForm.txtPhonesEntered.AppendText("=== Telephone " + (i + 1).ToString() + " ===" + Environment.NewLine);
                    showPhonesForm.txtPhonesEntered.AppendText(telephone.ToString() + Environment.NewLine);
                    showPhonesForm.txtPhonesEntered.AppendText(Environment.NewLine);
                    i++;
                }

                showPhonesForm.toolStripStatusLabelTelephoneListForm.Text = "A total of " + i.ToString() + " telephones.";
            }

            // show the form
            showPhonesForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelephoneEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "ITS 245 Lab09 (KD)", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void phonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShowPhones_Click(sender, e);
        }

        private void dialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Text = telephone.dial(numberToDial);
        }

        private void redialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Text = telephone.redial();
        }

        private void hangUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Text = telephone.hangUp();
        }


    }
}
