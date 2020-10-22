namespace GroupProjectFall2020ContemporaryProgramming
{
    partial class Form1
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lbleMailAddress = new System.Windows.Forms.Label();
            this.clbFavoriteLanguages = new System.Windows.Forms.CheckedListBox();
            this.lblFavoriteLanguages = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(177, 35);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(177, 58);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lbleMailAddress
            // 
            this.lbleMailAddress.AutoSize = true;
            this.lbleMailAddress.Location = new System.Drawing.Point(180, 92);
            this.lbleMailAddress.Name = "lbleMailAddress";
            this.lbleMailAddress.Size = new System.Drawing.Size(73, 13);
            this.lbleMailAddress.TabIndex = 2;
            this.lbleMailAddress.Text = "eMail Address";
            // 
            // clbFavoriteLanguages
            // 
            this.clbFavoriteLanguages.FormattingEnabled = true;
            this.clbFavoriteLanguages.Location = new System.Drawing.Point(287, 119);
            this.clbFavoriteLanguages.Name = "clbFavoriteLanguages";
            this.clbFavoriteLanguages.Size = new System.Drawing.Size(120, 94);
            this.clbFavoriteLanguages.TabIndex = 3;
            // 
            // lblFavoriteLanguages
            // 
            this.lblFavoriteLanguages.AutoSize = true;
            this.lblFavoriteLanguages.Location = new System.Drawing.Point(177, 119);
            this.lblFavoriteLanguages.Name = "lblFavoriteLanguages";
            this.lblFavoriteLanguages.Size = new System.Drawing.Size(101, 13);
            this.lblFavoriteLanguages.TabIndex = 4;
            this.lblFavoriteLanguages.Text = "Favorite Languages";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(713, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblFavoriteLanguages);
            this.Controls.Add(this.clbFavoriteLanguages);
            this.Controls.Add(this.lbleMailAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lbleMailAddress;
        private System.Windows.Forms.CheckedListBox clbFavoriteLanguages;
        private System.Windows.Forms.Label lblFavoriteLanguages;
        private System.Windows.Forms.Button btnOK;
    }
}

