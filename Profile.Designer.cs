
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
            this.Main = new System.Windows.Forms.TabControl();
            this.carveActivity = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.findFile = new System.Windows.Forms.Button();
            this.txtCarveFile = new System.Windows.Forms.TextBox();
            this.carveFile = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EditName = new System.Windows.Forms.Button();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DGItem2 = new System.Windows.Forms.DataGridView();
            this.logutBtnFile = new System.Windows.Forms.Button();
            this.mp4Btn = new System.Windows.Forms.Button();
            this.matricNo = new System.Windows.Forms.Label();
            this.nameInfo = new System.Windows.Forms.Label();
            this.nameUsr = new System.Windows.Forms.TextBox();
            this.matricNoUsr = new System.Windows.Forms.TextBox();
            this.DisplayName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idUsr = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Main.SuspendLayout();
            this.carveActivity.SuspendLayout();
            this.About.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.carveActivity);
            this.Main.Controls.Add(this.About);
            this.Main.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.Location = new System.Drawing.Point(193, 69);
            this.Main.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(457, 273);
            this.Main.TabIndex = 2;
            // 
            // carveActivity
            // 
            this.carveActivity.Controls.Add(this.button3);
            this.carveActivity.Controls.Add(this.button2);
            this.carveActivity.Controls.Add(this.button1);
            this.carveActivity.Controls.Add(this.findFile);
            this.carveActivity.Controls.Add(this.txtCarveFile);
            this.carveActivity.Controls.Add(this.carveFile);
            this.carveActivity.Location = new System.Drawing.Point(4, 21);
            this.carveActivity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.carveActivity.Name = "carveActivity";
            this.carveActivity.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.carveActivity.Size = new System.Drawing.Size(449, 248);
            this.carveActivity.TabIndex = 4;
            this.carveActivity.Text = "Carve Activity";
            this.carveActivity.UseVisualStyleBackColor = true;
            this.carveActivity.Click += new System.EventHandler(this.carveActivity_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(234, 119);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 25);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(310, 119);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(147, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Play Video";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // findFile
            // 
            this.findFile.BackColor = System.Drawing.Color.MidnightBlue;
            this.findFile.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findFile.ForeColor = System.Drawing.SystemColors.Control;
            this.findFile.Location = new System.Drawing.Point(367, 86);
            this.findFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.findFile.Name = "findFile";
            this.findFile.Size = new System.Drawing.Size(77, 28);
            this.findFile.TabIndex = 9;
            this.findFile.Text = "Open File";
            this.findFile.UseVisualStyleBackColor = false;
            this.findFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCarveFile
            // 
            this.txtCarveFile.BackColor = System.Drawing.SystemColors.Info;
            this.txtCarveFile.Location = new System.Drawing.Point(61, 91);
            this.txtCarveFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCarveFile.Name = "txtCarveFile";
            this.txtCarveFile.Size = new System.Drawing.Size(291, 20);
            this.txtCarveFile.TabIndex = 8;
            // 
            // carveFile
            // 
            this.carveFile.BackColor = System.Drawing.Color.Green;
            this.carveFile.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carveFile.ForeColor = System.Drawing.SystemColors.Control;
            this.carveFile.Location = new System.Drawing.Point(49, 120);
            this.carveFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.carveFile.Name = "carveFile";
            this.carveFile.Size = new System.Drawing.Size(81, 24);
            this.carveFile.TabIndex = 1;
            this.carveFile.Text = "Carve File";
            this.carveFile.UseVisualStyleBackColor = false;
            this.carveFile.Click += new System.EventHandler(this.carveFile_Click);
            // 
            // About
            // 
            this.About.Controls.Add(this.panel6);
            this.About.Controls.Add(this.EditName);
            this.About.Location = new System.Drawing.Point(4, 21);
            this.About.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.About.Size = new System.Drawing.Size(449, 248);
            this.About.TabIndex = 2;
            this.About.Text = "User Manual";
            this.About.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listBox1);
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 331);
            this.panel6.TabIndex = 14;
            // 
            // EditName
            // 
            this.EditName.BackColor = System.Drawing.Color.OrangeRed;
            this.EditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditName.Location = new System.Drawing.Point(367, 5);
            this.EditName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(80, 33);
            this.EditName.TabIndex = 12;
            this.EditName.Text = "Edit Info";
            this.EditName.UseVisualStyleBackColor = false;
            this.EditName.Click += new System.EventHandler(this.EditName_Click);
            // 
            // DGItem2
            // 
            this.DGItem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGItem2.Location = new System.Drawing.Point(0, 0);
            this.DGItem2.Name = "DGItem2";
            this.DGItem2.Size = new System.Drawing.Size(557, 305);
            this.DGItem2.TabIndex = 0;
            // 
            // logutBtnFile
            // 
            this.logutBtnFile.BackColor = System.Drawing.Color.MidnightBlue;
            this.logutBtnFile.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logutBtnFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logutBtnFile.Location = new System.Drawing.Point(529, 344);
            this.logutBtnFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logutBtnFile.Name = "logutBtnFile";
            this.logutBtnFile.Size = new System.Drawing.Size(122, 32);
            this.logutBtnFile.TabIndex = 25;
            this.logutBtnFile.Text = "LOGOUT";
            this.logutBtnFile.UseVisualStyleBackColor = false;
            this.logutBtnFile.Click += new System.EventHandler(this.logutBtnFile_Click);
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
            // matricNo
            // 
            this.matricNo.AutoSize = true;
            this.matricNo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricNo.Location = new System.Drawing.Point(21, 118);
            this.matricNo.Name = "matricNo";
            this.matricNo.Size = new System.Drawing.Size(108, 17);
            this.matricNo.TabIndex = 13;
            this.matricNo.Click += new System.EventHandler(this.matricNo_Click);
            // 
            // nameInfo
            // 
            this.nameInfo.AutoSize = true;
            this.nameInfo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInfo.Location = new System.Drawing.Point(21, 71);
            this.nameInfo.Name = "nameInfo";
            this.nameInfo.Size = new System.Drawing.Size(49, 17);
            this.nameInfo.TabIndex = 4;
            this.nameInfo.Click += new System.EventHandler(this.label3_Click);
            // 
            // nameUsr
            // 
            this.nameUsr.Location = new System.Drawing.Point(164, 70);
            this.nameUsr.Name = "nameUsr";
            this.nameUsr.Size = new System.Drawing.Size(237, 20);
            this.nameUsr.TabIndex = 19;
            this.nameUsr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // matricNoUsr
            // 
            this.matricNoUsr.Location = new System.Drawing.Point(164, 118);
            this.matricNoUsr.Name = "matricNoUsr";
            this.matricNoUsr.Size = new System.Drawing.Size(237, 20);
            this.matricNoUsr.TabIndex = 20;
            this.matricNoUsr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DisplayName
            // 
            this.DisplayName.BackColor = System.Drawing.Color.Green;
            this.DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayName.Location = new System.Drawing.Point(190, 169);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(133, 36);
            this.DisplayName.TabIndex = 21;
            this.DisplayName.Text = "Display Data";
            this.DisplayName.UseVisualStyleBackColor = false;
            this.DisplayName.Click += new System.EventHandler(this.DisplayName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 22;
            // 
            // idUsr
            // 
            this.idUsr.Location = new System.Drawing.Point(164, 30);
            this.idUsr.Name = "idUsr";
            this.idUsr.Size = new System.Drawing.Size(159, 20);
            this.idUsr.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "**********************************************************",
            "                                                                                 " +
                "               MP4KARVER MANUAL",
            "**********************************************************",
            "",
            "",
            "                                1. New user have to create a new account in the r" +
                "egister page, user need to click on the register button in the",
            "                                    start page.",
            "",
            "                                2. If user already has an account, the user can l" +
                "og into the tool by clicking the login button in the start page",
            "                                ",
            "                                3. User will be redirected to main page of the Mp" +
                "4Karver tool on the first tab which is Mp4Karver, user will have",
            "                                    access on adding raw file, save file, display" +
                "ing file and logout button.",
            "",
            "                                4. User can choose any USB disk image in raw exte" +
                "nsion from file explorer by clicking the find file button, the",
            "                                    file name will be displayed.",
            "",
            "                                5. User have to click on Carve file button and us" +
                "er will see the process of the tool carving data.",
            "",
            "                                6. When the carving process is done, user can cli" +
                "ck on Play video button to display the retrieved video.",
            "",
            "                                7. User can save the video file by clicking on th" +
                "e Save file button. ",
            "",
            "                                8. User can find the video file on local disk (C:" +
                ")//Users//User//Mp4Karver",
            "",
            "                                9. User can either choose to continue carving ano" +
                "ther USB disk image or exit the tool. In order to exit, user can",
            "                                    click on Exit button.",
            "",
            "                                10. Finish. ",
            "",
            "",
            "**********************************************************",
            "          MP4KARVER: MP4 CARVER TOOL USING HEADER/EMBEDDED LENGTH CARVING TECHNIQ" +
                "UE",
            "          The application use and involved to develop this tool is visual studio " +
                "2019, FTK Imager and xampp ",
            "          The language use is C# and C",
            "          The databases use is mySQLs",
            "**********************************************************"});
            this.listBox1.Location = new System.Drawing.Point(27, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 232);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 515);
            this.Controls.Add(this.logutBtnFile);
            this.Controls.Add(this.Main);
            this.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Main.ResumeLayout(false);
            this.carveActivity.ResumeLayout(false);
            this.carveActivity.PerformLayout();
            this.About.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Main;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logutBtnFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button EditName;
        private System.Windows.Forms.Button mp4Btn;
        private System.Windows.Forms.Label matricNo;
        private System.Windows.Forms.Label nameInfo;
        private System.Windows.Forms.TextBox nameUsr;
        private System.Windows.Forms.TextBox matricNoUsr;
        private System.Windows.Forms.Button DisplayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idUsr;
        private System.Windows.Forms.ListBox listBox1;
    }
}