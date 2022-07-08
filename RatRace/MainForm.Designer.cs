namespace RatRace
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nikolikBtn = new System.Windows.Forms.Button();
            this.serjikBtn = new System.Windows.Forms.Button();
            this.robikBtn = new System.Windows.Forms.Button();
            this.finishLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nikolikBtn
            // 
            this.nikolikBtn.Location = new System.Drawing.Point(23, 156);
            this.nikolikBtn.Name = "nikolikBtn";
            this.nikolikBtn.Size = new System.Drawing.Size(94, 29);
            this.nikolikBtn.TabIndex = 0;
            this.nikolikBtn.Text = "Nikolik";
            this.nikolikBtn.UseVisualStyleBackColor = true;
            // 
            // serjikBtn
            // 
            this.serjikBtn.Location = new System.Drawing.Point(23, 274);
            this.serjikBtn.Name = "serjikBtn";
            this.serjikBtn.Size = new System.Drawing.Size(94, 29);
            this.serjikBtn.TabIndex = 1;
            this.serjikBtn.Text = "Serjik";
            this.serjikBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.serjikBtn.UseVisualStyleBackColor = true;
            // 
            // robikBtn
            // 
            this.robikBtn.Location = new System.Drawing.Point(23, 393);
            this.robikBtn.Name = "robikBtn";
            this.robikBtn.Size = new System.Drawing.Size(94, 29);
            this.robikBtn.TabIndex = 2;
            this.robikBtn.Text = "Robik";
            this.robikBtn.UseVisualStyleBackColor = true;
            // 
            // finishLabel
            // 
            this.finishLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.finishLabel.Location = new System.Drawing.Point(770, 156);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(2, 271);
            this.finishLabel.TabIndex = 4;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(321, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(94, 29);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.finishLabel);
            this.Controls.Add(this.robikBtn);
            this.Controls.Add(this.serjikBtn);
            this.Controls.Add(this.nikolikBtn);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Rat Race MultiThreading";
            this.ResumeLayout(false);

        }

        #endregion

        private Button nikolikBtn;
        private Button serjikBtn;
        private Button robikBtn;
        private Label finishLabel;
        private Button startBtn;
    }
}