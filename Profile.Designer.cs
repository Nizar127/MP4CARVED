
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FileCarved = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenFolderBox = new System.Windows.Forms.Button();
            this.carveActivity = new System.Windows.Forms.TabPage();
            this.findFile = new System.Windows.Forms.Button();
            this.txtCarveFile = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.carveFile = new System.Windows.Forms.Button();
            this.saveImgTab = new System.Windows.Forms.TabPage();
            this.DeleteImg = new System.Windows.Forms.Button();
            this.DGItems = new System.Windows.Forms.DataGridView();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.TabPage();
            this.deleteFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DataFile = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.historyTab = new System.Windows.Forms.TabPage();
            this.HistoryCarve = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.upload_img = new System.Windows.Forms.Button();
            this.usernameProfile = new System.Windows.Forms.Label();
            this.DGItem2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.Main.SuspendLayout();
            this.MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.carveActivity.SuspendLayout();
            this.panel7.SuspendLayout();
            this.saveImgTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).BeginInit();
            this.file.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.About.SuspendLayout();
            this.panel6.SuspendLayout();
            this.historyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGItem2)).BeginInit();
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
            this.Main.Controls.Add(this.MainTab);
            this.Main.Controls.Add(this.carveActivity);
            this.Main.Controls.Add(this.saveImgTab);
            this.Main.Controls.Add(this.file);
            this.Main.Controls.Add(this.About);
            this.Main.Controls.Add(this.historyTab);
            this.Main.Location = new System.Drawing.Point(208, 59);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(580, 551);
            this.Main.TabIndex = 2;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.pictureBox2);
            this.MainTab.Controls.Add(this.FileCarved);
            this.MainTab.Controls.Add(this.pictureBox1);
            this.MainTab.Controls.Add(this.OpenFolderBox);
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(572, 525);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(6, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(560, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // FileCarved
            // 
            this.FileCarved.AutoSize = true;
            this.FileCarved.Location = new System.Drawing.Point(18, 33);
            this.FileCarved.Name = "FileCarved";
            this.FileCarved.Size = new System.Drawing.Size(83, 13);
            this.FileCarved.TabIndex = 4;
            this.FileCarved.Text = "Last File Carved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(6, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // OpenFolderBox
            // 
            this.OpenFolderBox.BackColor = System.Drawing.Color.Lime;
            this.OpenFolderBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFolderBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OpenFolderBox.Location = new System.Drawing.Point(397, 52);
            this.OpenFolderBox.Name = "OpenFolderBox";
            this.OpenFolderBox.Size = new System.Drawing.Size(122, 44);
            this.OpenFolderBox.TabIndex = 0;
            this.OpenFolderBox.Text = "Open Folder";
            this.OpenFolderBox.UseVisualStyleBackColor = false;
            // 
            // carveActivity
            // 
            this.carveActivity.Controls.Add(this.findFile);
            this.carveActivity.Controls.Add(this.txtCarveFile);
            this.carveActivity.Controls.Add(this.panel7);
            this.carveActivity.Controls.Add(this.carveFile);
            this.carveActivity.Location = new System.Drawing.Point(4, 22);
            this.carveActivity.Name = "carveActivity";
            this.carveActivity.Padding = new System.Windows.Forms.Padding(3);
            this.carveActivity.Size = new System.Drawing.Size(572, 525);
            this.carveActivity.TabIndex = 4;
            this.carveActivity.Text = "Carve Activity";
            this.carveActivity.UseVisualStyleBackColor = true;
            this.carveActivity.Click += new System.EventHandler(this.carveActivity_Click);
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
            // txtCarveFile
            // 
            this.txtCarveFile.BackColor = System.Drawing.SystemColors.Info;
            this.txtCarveFile.Location = new System.Drawing.Point(98, 48);
            this.txtCarveFile.Name = "txtCarveFile";
            this.txtCarveFile.Size = new System.Drawing.Size(348, 20);
            this.txtCarveFile.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.DGItem2);
            this.panel7.Location = new System.Drawing.Point(6, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(560, 308);
            this.panel7.TabIndex = 3;
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
            // file
            // 
            this.file.Controls.Add(this.deleteFolder);
            this.file.Controls.Add(this.panel1);
            this.file.Controls.Add(this.button1);
            this.file.Location = new System.Drawing.Point(4, 22);
            this.file.Name = "file";
            this.file.Padding = new System.Windows.Forms.Padding(3);
            this.file.Size = new System.Drawing.Size(572, 525);
            this.file.TabIndex = 1;
            this.file.Text = "File";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // deleteFolder
            // 
            this.deleteFolder.BackColor = System.Drawing.Color.Red;
            this.deleteFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteFolder.Location = new System.Drawing.Point(406, 149);
            this.deleteFolder.Name = "deleteFolder";
            this.deleteFolder.Size = new System.Drawing.Size(96, 39);
            this.deleteFolder.TabIndex = 11;
            this.deleteFolder.Text = "Delete Folder";
            this.deleteFolder.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(6, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 239);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Location = new System.Drawing.Point(114, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 103);
            this.panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data File";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(68, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(16, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 103);
            this.panel3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(114, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 103);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data File";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DataFile);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(18, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(68, 103);
            this.panel5.TabIndex = 9;
            // 
            // DataFile
            // 
            this.DataFile.AutoSize = true;
            this.DataFile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DataFile.Location = new System.Drawing.Point(3, 74);
            this.DataFile.Name = "DataFile";
            this.DataFile.Size = new System.Drawing.Size(49, 13);
            this.DataFile.TabIndex = 4;
            this.DataFile.Text = "Data File";
            this.DataFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(406, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Folder";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // About
            // 
            this.About.Controls.Add(this.panel6);
            this.About.Controls.Add(this.EditName);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
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
            // historyTab
            // 
            this.historyTab.Controls.Add(this.HistoryCarve);
            this.historyTab.Controls.Add(this.listView1);
            this.historyTab.Controls.Add(this.listBox1);
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(572, 525);
            this.historyTab.TabIndex = 3;
            this.historyTab.Text = "Carve History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // HistoryCarve
            // 
            this.HistoryCarve.AutoSize = true;
            this.HistoryCarve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryCarve.Location = new System.Drawing.Point(239, 28);
            this.HistoryCarve.Name = "HistoryCarve";
            this.HistoryCarve.Size = new System.Drawing.Size(87, 29);
            this.HistoryCarve.TabIndex = 2;
            this.HistoryCarve.Text = "History";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(551, 184);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(563, 212);
            this.listBox1.TabIndex = 0;
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
            // DGItem2
            // 
            this.DGItem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGItem2.Location = new System.Drawing.Point(0, 0);
            this.DGItem2.Name = "DGItem2";
            this.DGItem2.Size = new System.Drawing.Size(557, 305);
            this.DGItem2.TabIndex = 0;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 653);
            this.Controls.Add(this.usernameProfile);
            this.Controls.Add(this.upload_img);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.imageBox);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.Main.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.carveActivity.ResumeLayout(false);
            this.carveActivity.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.saveImgTab.ResumeLayout(false);
            this.saveImgTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).EndInit();
            this.file.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.About.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.historyTab.ResumeLayout(false);
            this.historyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage file;
        private System.Windows.Forms.Button upload_img;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.Label usernameProfile;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label FileCarved;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OpenFolderBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label DataFile;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button EditName;
        private System.Windows.Forms.Label nameInfo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label matricNo;
        private System.Windows.Forms.Button viewFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileNumList;
        private System.Windows.Forms.Label HistoryCarve;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage carveActivity;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button carveFile;
        private System.Windows.Forms.TabPage saveImgTab;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button findFile;
        private System.Windows.Forms.TextBox txtCarveFile;
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
        private System.Windows.Forms.DataGridView DGItem2;
    }
}