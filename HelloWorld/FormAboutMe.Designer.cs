
namespace HelloWorld
{
    partial class FormAboutMe
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
            this.lblAboutMe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAboutMe
            // 
            this.lblAboutMe.AutoSize = true;
            this.lblAboutMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblAboutMe.Location = new System.Drawing.Point(232, 193);
            this.lblAboutMe.Name = "lblAboutMe";
            this.lblAboutMe.Size = new System.Drawing.Size(265, 67);
            this.lblAboutMe.TabIndex = 0;
            this.lblAboutMe.Text = "AboutMe";
            // 
            // FormAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAboutMe);
            this.Name = "FormAboutMe";
            this.Text = "FormAboutMe";
            this.Load += new System.EventHandler(this.FormAboutMe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutMe;
    }
}