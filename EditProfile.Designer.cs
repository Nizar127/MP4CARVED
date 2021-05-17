
namespace MP4Carver
{
    partial class EditProfile
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
            this.nameInfo = new System.Windows.Forms.Label();
            this.matricNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMatricNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmitProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameInfo
            // 
            this.nameInfo.AutoSize = true;
            this.nameInfo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInfo.Location = new System.Drawing.Point(75, 104);
            this.nameInfo.Name = "nameInfo";
            this.nameInfo.Size = new System.Drawing.Size(49, 17);
            this.nameInfo.TabIndex = 19;
            this.nameInfo.Text = "Name:";
            // 
            // matricNo
            // 
            this.matricNo.AutoSize = true;
            this.matricNo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricNo.Location = new System.Drawing.Point(75, 151);
            this.matricNo.Name = "matricNo";
            this.matricNo.Size = new System.Drawing.Size(108, 17);
            this.matricNo.TabIndex = 20;
            this.matricNo.Text = "Matric Number:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMatricNumber);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnSubmitProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameInfo);
            this.panel1.Controls.Add(this.matricNo);
            this.panel1.Location = new System.Drawing.Point(143, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 264);
            this.panel1.TabIndex = 25;
            // 
            // txtMatricNumber
            // 
            this.txtMatricNumber.Location = new System.Drawing.Point(189, 148);
            this.txtMatricNumber.Name = "txtMatricNumber";
            this.txtMatricNumber.Size = new System.Drawing.Size(290, 20);
            this.txtMatricNumber.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 28;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSubmitProfile
            // 
            this.btnSubmitProfile.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSubmitProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmitProfile.Location = new System.Drawing.Point(179, 205);
            this.btnSubmitProfile.Name = "btnSubmitProfile";
            this.btnSubmitProfile.Size = new System.Drawing.Size(133, 36);
            this.btnSubmitProfile.TabIndex = 26;
            this.btnSubmitProfile.Text = "Submit";
            this.btnSubmitProfile.UseVisualStyleBackColor = false;
            this.btnSubmitProfile.Click += new System.EventHandler(this.btnSubmitProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Edit Profile";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EditProfile";
            this.Text = "EditProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nameInfo;
        private System.Windows.Forms.Label matricNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitProfile;
        private System.Windows.Forms.TextBox txtMatricNumber;
        private System.Windows.Forms.TextBox txtName;
    }
}