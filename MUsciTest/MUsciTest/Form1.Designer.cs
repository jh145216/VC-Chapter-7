namespace MUsciTest
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
            this.btnsimpleSound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsimpleSound
            // 
            this.btnsimpleSound.Location = new System.Drawing.Point(154, 81);
            this.btnsimpleSound.Name = "btnsimpleSound";
            this.btnsimpleSound.Size = new System.Drawing.Size(75, 23);
            this.btnsimpleSound.TabIndex = 0;
            this.btnsimpleSound.Text = "simpleSound";
            this.btnsimpleSound.UseVisualStyleBackColor = true;
            this.btnsimpleSound.Click += new System.EventHandler(this.btnsimpleSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 305);
            this.Controls.Add(this.btnsimpleSound);
            this.Name = "Form1";
            this.Text = "MP3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsimpleSound;


    }
}

