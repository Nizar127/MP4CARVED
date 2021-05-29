
namespace MP4Carver
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.TabControl();
            this.saveImgTab = new System.Windows.Forms.TabPage();
            this.DeleteImg = new System.Windows.Forms.Button();
            this.DGItems = new System.Windows.Forms.DataGridView();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.testmp4 = new System.Windows.Forms.TabPage();
            this.About = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viewedCarveFiled = new System.Windows.Forms.Panel();
            this.viewFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNumList = new System.Windows.Forms.Label();
            this.nameInfo = new System.Windows.Forms.Label();
            this.matricNo = new System.Windows.Forms.Label();
            this.EditName = new System.Windows.Forms.Button();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.upload_img = new System.Windows.Forms.Button();
            this.usernameProfile = new System.Windows.Forms.Label();
            this.carveFile = new System.Windows.Forms.Button();
            this.DGItem2 = new System.Windows.Forms.DataGridView();
            this.txtCarveFile = new System.Windows.Forms.TextBox();
            this.findFile = new System.Windows.Forms.Button();
            this.carveActivity = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mp4Btn = new System.Windows.Forms.Button();
            this.DGItem3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.Main.SuspendLayout();
            this.saveImgTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).BeginInit();
            this.testmp4.SuspendLayout();
            this.About.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGItem2)).BeginInit();
            this.carveActivity.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imageBox.Location = new System.Drawing.Point(33, 59);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(160, 233);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.carveActivity);
            this.Main.Controls.Add(this.saveImgTab);
            this.Main.Controls.Add(this.testmp4);
            this.Main.Controls.Add(this.About);
            this.Main.Location = new System.Drawing.Point(208, 59);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(580, 551);
            this.Main.TabIndex = 2;
            // 
            // saveImgTab
            // 
            this.saveImgTab.Controls.Add(this.DeleteImg);
            this.saveImgTab.Controls.Add(this.DGItems);
            this.saveImgTab.Controls.Add(this.txtFile);
            this.saveImgTab.Controls.Add(this.btnSaveData);
            this.saveImgTab.Controls.Add(this.btnSave);
            this.saveImgTab.Location = new System.Drawing.Point(4, 22);
            this.saveImgTab.Name = "saveImgTab";
            this.saveImgTab.Size = new System.Drawing.Size(572, 525);
            this.saveImgTab.TabIndex = 5;
            this.saveImgTab.Text = "Save MP4 Image";
            this.saveImgTab.UseVisualStyleBackColor = true;
            // 
            // DeleteImg
            // 
            this.DeleteImg.BackColor = System.Drawing.Color.Red;
            this.DeleteImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteImg.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteImg.Location = new System.Drawing.Point(317, 448);
            this.DeleteImg.Name = "DeleteImg";
            this.DeleteImg.Size = new System.Drawing.Size(141, 39);
            this.DeleteImg.TabIndex = 8;
            this.DeleteImg.Text = "Delete MP4 Image";
            this.DeleteImg.UseVisualStyleBackColor = false;
            this.DeleteImg.Click += new System.EventHandler(this.loadImg_Click);
            // 
            // DGItems
            // 
            this.DGItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGItems.Location = new System.Drawing.Point(3, 60);
            this.DGItems.Name = "DGItems";
            this.DGItems.Size = new System.Drawing.Size(566, 368);
            this.DGItems.TabIndex = 0;
            this.DGItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGItems_CellContentClick);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(12, 25);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(358, 20);
            this.txtFile.TabIndex = 7;
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveData.Location = new System.Drawing.Point(374, 15);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(96, 39);
            this.btnSaveData.TabIndex = 6;
            this.btnSaveData.Text = "Open Image";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(136, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save MP4 Image";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // testmp4
            // 
            this.testmp4.Controls.Add(this.panel1);
            this.testmp4.Location = new System.Drawing.Point(4, 22);
            this.testmp4.Name = "testmp4";
            this.testmp4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.testmp4.Size = new System.Drawing.Size(572, 525);
            this.testmp4.TabIndex = 1;
            this.testmp4.Text = "Test MP4";
            this.testmp4.UseVisualStyleBackColor = true;
            this.testmp4.Click += new System.EventHandler(this.file_Click);
            // 
            // About
            // 
            this.About.Controls.Add(this.panel6);
            this.About.Controls.Add(this.EditName);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.About.Size = new System.Drawing.Size(572, 525);
            this.About.TabIndex = 2;
            this.About.Text = "About Me";
            this.About.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.viewedCarveFiled);
            this.panel6.Controls.Add(this.viewFile);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.fileNumList);
            this.panel6.Controls.Add(this.nameInfo);
            this.panel6.Controls.Add(this.matricNo);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(429, 391);
            this.panel6.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 19;
            // 
            // viewedCarveFiled
            // 
            this.viewedCarveFiled.Location = new System.Drawing.Point(3, 217);
            this.viewedCarveFiled.Name = "viewedCarveFiled";
            this.viewedCarveFiled.Size = new System.Drawing.Size(423, 160);
            this.viewedCarveFiled.TabIndex = 18;
            // 
            // viewFile
            // 
            this.viewFile.BackColor = System.Drawing.Color.Green;
            this.viewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewFile.Location = new System.Drawing.Point(100, 175);
            this.viewFile.Name = "viewFile";
            this.viewFile.Size = new System.Drawing.Size(133, 36);
            this.viewFile.TabIndex = 15;
            this.viewFile.Text = "View Carve File";
            this.viewFile.UseVisualStyleBackColor = false;
            this.viewFile.Click += new System.EventHandler(this.viewFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "View File: ";
            // 
            // fileNumList
            // 
            this.fileNumList.AutoSize = true;
            this.fileNumList.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNumList.Location = new System.Drawing.Point(18, 123);
            this.fileNumList.Name = "fileNumList";
            this.fileNumList.Size = new System.Drawing.Size(137, 17);
            this.fileNumList.TabIndex = 14;
            this.fileNumList.Text = "Number of File List:";
            // 
            // nameInfo
            // 
            this.nameInfo.AutoSize = true;
            this.nameInfo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInfo.Location = new System.Drawing.Point(18, 29);
            this.nameInfo.Name = "nameInfo";
            this.nameInfo.Size = new System.Drawing.Size(49, 17);
            this.nameInfo.TabIndex = 4;
            this.nameInfo.Text = "Name:";
            this.nameInfo.Click += new System.EventHandler(this.label3_Click);
            // 
            // matricNo
            // 
            this.matricNo.AutoSize = true;
            this.matricNo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricNo.Location = new System.Drawing.Point(18, 76);
            this.matricNo.Name = "matricNo";
            this.matricNo.Size = new System.Drawing.Size(108, 17);
            this.matricNo.TabIndex = 13;
            this.matricNo.Text = "Matric Number:";
            // 
            // EditName
            // 
            this.EditName.BackColor = System.Drawing.Color.OrangeRed;
            this.EditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditName.Location = new System.Drawing.Point(441, 6);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(96, 39);
            this.EditName.TabIndex = 12;
            this.EditName.Text = "Edit Info";
            this.EditName.UseVisualStyleBackColor = false;
            this.EditName.Click += new System.EventHandler(this.EditName_Click);
            // 
            // upload_img
            // 
            this.upload_img.Location = new System.Drawing.Point(33, 338);
            this.upload_img.Name = "upload_img";
            this.upload_img.Size = new System.Drawing.Size(146, 38);
            this.upload_img.TabIndex = 3;
            this.upload_img.Text = "Change Image";
            this.upload_img.UseVisualStyleBackColor = true;
            this.upload_img.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameProfile
            // 
            this.usernameProfile.AutoSize = true;
            this.usernameProfile.Location = new System.Drawing.Point(40, 308);
            this.usernameProfile.Name = "usernameProfile";
            this.usernameProfile.Size = new System.Drawing.Size(84, 13);
            this.usernameProfile.TabIndex = 0;
            this.usernameProfile.Text = "UsernameProfile";
            // 
            // carveFile
            // 
            this.carveFile.BackColor = System.Drawing.Color.Green;
            this.carveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carveFile.ForeColor = System.Drawing.SystemColors.Control;
            this.carveFile.Location = new System.Drawing.Point(219, 392);
            this.carveFile.Name = "carveFile";
            this.carveFile.Size = new System.Drawing.Size(120, 53);
            this.carveFile.TabIndex = 1;
            this.carveFile.Text = "Carve File";
            this.carveFile.UseVisualStyleBackColor = false;
            this.carveFile.Click += new System.EventHandler(this.carveFile_Click);
            // 
            // DGItem2
            // 
            this.DGItem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGItem2.Location = new System.Drawing.Point(0, 0);
            this.DGItem2.Name = "DGItem2";
            this.DGItem2.Size = new System.Drawing.Size(557, 305);
            this.DGItem2.TabIndex = 0;
            // 
            // txtCarveFile
            // 
            this.txtCarveFile.BackColor = System.Drawing.SystemColors.Info;
            this.txtCarveFile.Location = new System.Drawing.Point(98, 48);
            this.txtCarveFile.Name = "txtCarveFile";
            this.txtCarveFile.Size = new System.Drawing.Size(348, 20);
            this.txtCarveFile.TabIndex = 8;
            // 
            // findFile
            // 
            this.findFile.BackColor = System.Drawing.Color.MidnightBlue;
            this.findFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findFile.ForeColor = System.Drawing.SystemColors.Control;
            this.findFile.Location = new System.Drawing.Point(452, 42);
            this.findFile.Name = "findFile";
            this.findFile.Size = new System.Drawing.Size(83, 33);
            this.findFile.TabIndex = 9;
            this.findFile.Text = "Find File";
            this.findFile.UseVisualStyleBackColor = false;
            this.findFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // carveActivity
            // 
            this.carveActivity.Controls.Add(this.DGItem3);
            this.carveActivity.Controls.Add(this.findFile);
            this.carveActivity.Controls.Add(this.txtCarveFile);
            this.carveActivity.Controls.Add(this.carveFile);
            this.carveActivity.Location = new System.Drawing.Point(4, 22);
            this.carveActivity.Name = "carveActivity";
            this.carveActivity.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.carveActivity.Size = new System.Drawing.Size(572, 525);
            this.carveActivity.TabIndex = 4;
            this.carveActivity.Text = "Carve Activity";
            this.carveActivity.UseVisualStyleBackColor = true;
            this.carveActivity.Click += new System.EventHandler(this.carveActivity_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.mp4Btn);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 525);
            this.panel1.TabIndex = 10;
            // 
            // mp4Btn
            // 
            this.mp4Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mp4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp4Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mp4Btn.Location = new System.Drawing.Point(189, 214);
            this.mp4Btn.Name = "mp4Btn";
            this.mp4Btn.Size = new System.Drawing.Size(195, 60);
            this.mp4Btn.TabIndex = 6;
            this.mp4Btn.Text = "Test MP4 Image";
            this.mp4Btn.UseVisualStyleBackColor = false;
            this.mp4Btn.Click += new System.EventHandler(this.mp4Btn_Click_1);
            // 
            // DGItem3
            // 
            this.DGItem3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGItem3.Location = new System.Drawing.Point(3, 74);
            this.DGItem3.Name = "DGItem3";
            this.DGItem3.Size = new System.Drawing.Size(569, 312);
            this.DGItem3.TabIndex = 10;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 609);
            this.Controls.Add(this.usernameProfile);
            this.Controls.Add(this.upload_img);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.imageBox);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.Main.ResumeLayout(false);
            this.saveImgTab.ResumeLayout(false);
            this.saveImgTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).EndInit();
            this.testmp4.ResumeLayout(false);
            this.About.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGItem2)).EndInit();
            this.carveActivity.ResumeLayout(false);
            this.carveActivity.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage testmp4;
        private System.Windows.Forms.Button upload_img;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.Label usernameProfile;
        private System.Windows.Forms.Button EditName;
        private System.Windows.Forms.Label nameInfo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label matricNo;
        private System.Windows.Forms.Button viewFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileNumList;
        private System.Windows.Forms.TabPage saveImgTab;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel viewedCarveFiled;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.DataGridView DGItems;
        private System.Windows.Forms.Button DeleteImg;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullpathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.TabPage carveActivity;
        private System.Windows.Forms.Button findFile;
        private System.Windows.Forms.TextBox txtCarveFile;
        private System.Windows.Forms.Button carveFile;
        private System.Windows.Forms.DataGridView DGItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mp4Btn;
        private System.Windows.Forms.DataGridView DGItem3;
    }
}