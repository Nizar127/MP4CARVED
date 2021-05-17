
namespace MP4Carver
{
    partial class AddImage
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
            this.changeImgBox = new System.Windows.Forms.PictureBox();
            this.browseImg = new System.Windows.Forms.Button();
            this.saveImgButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.changeImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // changeImgBox
            // 
            this.changeImgBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.changeImgBox.Location = new System.Drawing.Point(33, 45);
            this.changeImgBox.Name = "changeImgBox";
            this.changeImgBox.Size = new System.Drawing.Size(206, 176);
            this.changeImgBox.TabIndex = 0;
            this.changeImgBox.TabStop = false;
            this.changeImgBox.Click += new System.EventHandler(this.changeImgBox_Click);
            // 
            // browseImg
            // 
            this.browseImg.Location = new System.Drawing.Point(60, 227);
            this.browseImg.Name = "browseImg";
            this.browseImg.Size = new System.Drawing.Size(146, 38);
            this.browseImg.TabIndex = 4;
            this.browseImg.Text = "Browse Image";
            this.browseImg.UseVisualStyleBackColor = true;
            this.browseImg.Click += new System.EventHandler(this.browseImg_Click);
            // 
            // saveImgButton
            // 
            this.saveImgButton.Location = new System.Drawing.Point(60, 271);
            this.saveImgButton.Name = "saveImgButton";
            this.saveImgButton.Size = new System.Drawing.Size(146, 38);
            this.saveImgButton.TabIndex = 5;
            this.saveImgButton.Text = "Save Image";
            this.saveImgButton.UseVisualStyleBackColor = true;
            this.saveImgButton.Click += new System.EventHandler(this.saveImgButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Image";
            // 
            // AddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveImgButton);
            this.Controls.Add(this.browseImg);
            this.Controls.Add(this.changeImgBox);
            this.Name = "AddImage";
            this.Text = "AddImage";
            ((System.ComponentModel.ISupportInitialize)(this.changeImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox changeImgBox;
        private System.Windows.Forms.Button browseImg;
        private System.Windows.Forms.Button saveImgButton;
        private System.Windows.Forms.Label label1;
    }
}