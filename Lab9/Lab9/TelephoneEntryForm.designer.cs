using System;

namespace Lab9
{
    partial class TelephoneEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelephoneEntryForm));
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtNumberToDial = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNumberToDial = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowPhones = new System.Windows.Forms.Button();
            this.btnDial = new System.Windows.Forms.Button();
            this.btnRedial = new System.Windows.Forms.Button();
            this.btnHangUp = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.statusStripTelephoneEntryForm = new System.Windows.Forms.StatusStrip();
            this.menuStripTelephoneEntryForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hangUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogTelephoneEntryForm = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTelephoneEntryForm = new System.Windows.Forms.OpenFileDialog();
            this.menuStripTelephoneEntryForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(120, 35);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(136, 20);
            this.txtManufacturer.TabIndex = 0;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.Location = new System.Drawing.Point(21, 35);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(86, 13);
            this.lblManufacturer.TabIndex = 1;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(120, 61);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(136, 20);
            this.txtModel.TabIndex = 2;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(121, 87);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(136, 20);
            this.txtPhoneNum.TabIndex = 3;
            // 
            // txtNumberToDial
            // 
            this.txtNumberToDial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberToDial.Location = new System.Drawing.Point(121, 113);
            this.txtNumberToDial.Name = "txtNumberToDial";
            this.txtNumberToDial.Size = new System.Drawing.Size(136, 20);
            this.txtNumberToDial.TabIndex = 4;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(21, 64);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 13);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(21, 90);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(59, 13);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone #:";
            // 
            // lblNumberToDial
            // 
            this.lblNumberToDial.AutoSize = true;
            this.lblNumberToDial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberToDial.Location = new System.Drawing.Point(21, 116);
            this.lblNumberToDial.Name = "lblNumberToDial";
            this.lblNumberToDial.Size = new System.Drawing.Size(100, 13);
            this.lblNumberToDial.TabIndex = 7;
            this.lblNumberToDial.Text = "Phone # to Dial:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(24, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnShowPhones
            // 
            this.btnShowPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPhones.Location = new System.Drawing.Point(105, 150);
            this.btnShowPhones.Name = "btnShowPhones";
            this.btnShowPhones.Size = new System.Drawing.Size(151, 23);
            this.btnShowPhones.TabIndex = 9;
            this.btnShowPhones.Text = "Show Telephones";
            this.btnShowPhones.UseVisualStyleBackColor = true;
            // 
            // btnDial
            // 
            this.btnDial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDial.Location = new System.Drawing.Point(24, 179);
            this.btnDial.Name = "btnDial";
            this.btnDial.Size = new System.Drawing.Size(75, 23);
            this.btnDial.TabIndex = 10;
            this.btnDial.Text = "Dial";
            this.btnDial.UseVisualStyleBackColor = true;
            // 
            // btnRedial
            // 
            this.btnRedial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedial.Location = new System.Drawing.Point(105, 179);
            this.btnRedial.Name = "btnRedial";
            this.btnRedial.Size = new System.Drawing.Size(70, 23);
            this.btnRedial.TabIndex = 11;
            this.btnRedial.Text = "Redial";
            this.btnRedial.UseVisualStyleBackColor = true;
            // 
            // btnHangUp
            // 
            this.btnHangUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangUp.Location = new System.Drawing.Point(192, 179);
            this.btnHangUp.Name = "btnHangUp";
            this.btnHangUp.Size = new System.Drawing.Size(64, 23);
            this.btnHangUp.TabIndex = 12;
            this.btnHangUp.Text = "HangUp";
            this.btnHangUp.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Control;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Red;
            this.txtOutput.Location = new System.Drawing.Point(23, 208);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(233, 119);
            this.txtOutput.TabIndex = 13;
            // 
            // statusStripTelephoneEntryForm
            // 
            this.statusStripTelephoneEntryForm.Location = new System.Drawing.Point(0, 347);
            this.statusStripTelephoneEntryForm.Name = "statusStripTelephoneEntryForm";
            this.statusStripTelephoneEntryForm.Size = new System.Drawing.Size(290, 22);
            this.statusStripTelephoneEntryForm.TabIndex = 14;
            this.statusStripTelephoneEntryForm.Text = "statusStrip1";
            // 
            // menuStripTelephoneEntryForm
            // 
            this.menuStripTelephoneEntryForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.telephoneToolStripMenuItem});
            this.menuStripTelephoneEntryForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripTelephoneEntryForm.Name = "menuStripTelephoneEntryForm";
            this.menuStripTelephoneEntryForm.Size = new System.Drawing.Size(290, 24);
            this.menuStripTelephoneEntryForm.TabIndex = 15;
            this.menuStripTelephoneEntryForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phoneListToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // phoneListToolStripMenuItem
            // 
            this.phoneListToolStripMenuItem.Name = "phoneListToolStripMenuItem";
            this.phoneListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.phoneListToolStripMenuItem.Text = "&Phone List";
            // 
            // telephoneToolStripMenuItem
            // 
            this.telephoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dialToolStripMenuItem,
            this.redialToolStripMenuItem,
            this.hangUpToolStripMenuItem});
            this.telephoneToolStripMenuItem.Name = "telephoneToolStripMenuItem";
            this.telephoneToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.telephoneToolStripMenuItem.Text = "&Telephone";
            // 
            // dialToolStripMenuItem
            // 
            this.dialToolStripMenuItem.Name = "dialToolStripMenuItem";
            this.dialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dialToolStripMenuItem.Text = "&Dial";
            // 
            // redialToolStripMenuItem
            // 
            this.redialToolStripMenuItem.Name = "redialToolStripMenuItem";
            this.redialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redialToolStripMenuItem.Text = "&Redial";
            // 
            // hangUpToolStripMenuItem
            // 
            this.hangUpToolStripMenuItem.Name = "hangUpToolStripMenuItem";
            this.hangUpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hangUpToolStripMenuItem.Text = "&Hang Up";
            // 
            // saveFileDialogTelephoneEntryForm
            // 
            this.saveFileDialogTelephoneEntryForm.Filter = "Data files|*.dat|All files|*.*";
            this.saveFileDialogTelephoneEntryForm.InitialDirectory = "C:\\Users\\Kalen\\Desktop";
            // 
            // openFileDialogTelephoneEntryForm
            // 
            this.openFileDialogTelephoneEntryForm.DefaultExt = "dat";
            this.openFileDialogTelephoneEntryForm.Filter = "Data files|*.dat|All files|*.*";
            this.openFileDialogTelephoneEntryForm.InitialDirectory = "C:\\Users\\Kalen\\Desktop";
            // 
            // TelephoneEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 369);
            this.Controls.Add(this.statusStripTelephoneEntryForm);
            this.Controls.Add(this.menuStripTelephoneEntryForm);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnHangUp);
            this.Controls.Add(this.btnRedial);
            this.Controls.Add(this.btnDial);
            this.Controls.Add(this.btnShowPhones);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNumberToDial);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtNumberToDial);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtManufacturer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTelephoneEntryForm;
            this.Name = "TelephoneEntryForm";
            this.Text = "ITS245 - Lab09 (KD)";
            this.Load += new System.EventHandler(this.TelephoneEntryForm_Load);
            this.menuStripTelephoneEntryForm.ResumeLayout(false);
            this.menuStripTelephoneEntryForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtNumberToDial;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNumberToDial;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowPhones;
        private System.Windows.Forms.Button btnDial;
        private System.Windows.Forms.Button btnRedial;
        private System.Windows.Forms.Button btnHangUp;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.StatusStrip statusStripTelephoneEntryForm;
        private System.Windows.Forms.MenuStrip menuStripTelephoneEntryForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telephoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hangUpToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTelephoneEntryForm;
        private System.Windows.Forms.OpenFileDialog openFileDialogTelephoneEntryForm;
    }
}

