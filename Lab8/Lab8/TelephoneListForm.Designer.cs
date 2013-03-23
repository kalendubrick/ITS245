namespace Lab8
{
    partial class TelephoneListForm
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
            this.lblPhonesEntered = new System.Windows.Forms.Label();
            this.txtPhonesEntered = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhonesEntered
            // 
            this.lblPhonesEntered.AutoSize = true;
            this.lblPhonesEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonesEntered.Location = new System.Drawing.Point(13, 13);
            this.lblPhonesEntered.Name = "lblPhonesEntered";
            this.lblPhonesEntered.Size = new System.Drawing.Size(125, 13);
            this.lblPhonesEntered.TabIndex = 0;
            this.lblPhonesEntered.Text = "Telephones Entered:";
            // 
            // txtPhonesEntered
            // 
            this.txtPhonesEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhonesEntered.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPhonesEntered.Location = new System.Drawing.Point(16, 41);
            this.txtPhonesEntered.Multiline = true;
            this.txtPhonesEntered.Name = "txtPhonesEntered";
            this.txtPhonesEntered.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhonesEntered.Size = new System.Drawing.Size(322, 231);
            this.txtPhonesEntered.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(132, 295);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Close";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // TelephoneListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 345);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPhonesEntered);
            this.Controls.Add(this.lblPhonesEntered);
            this.Name = "TelephoneListForm";
            this.Text = "ITS 245 - Lab08 (KD)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhonesEntered;
        private System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.TextBox txtPhonesEntered;
    }
}