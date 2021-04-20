
namespace MP4Carver
{
    partial class SplashScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 22);
            this.panel1.TabIndex = 0;
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loading.Location = new System.Drawing.Point(212, 186);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(147, 29);
            this.loading.TabIndex = 2;
            this.loading.Text = "LOADING...";
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Lime;
            this.bar.Location = new System.Drawing.Point(1, 321);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(11, 22);
            this.bar.TabIndex = 1;
            this.bar.Paint += new System.Windows.Forms.PaintEventHandler(this.progressbar_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bowlby One SC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(189, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 42);
            this.label2.TabIndex = 45;
            this.label2.Text = "MP4CARVER";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(599, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}