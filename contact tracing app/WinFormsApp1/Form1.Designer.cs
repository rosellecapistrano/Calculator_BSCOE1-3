
namespace WinFormsApp1
{
    partial class contact_tracing_app
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
            this.START = new System.Windows.Forms.Button();
            this.userinput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(120, 293);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(130, 43);
            this.START.TabIndex = 0;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(46, 60);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(294, 96);
            this.userinput.TabIndex = 1;
            this.userinput.Text = "";
            this.userinput.TextChanged += new System.EventHandler(this.userinput_TextChanged);
            // 
            // contact_tracing_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 355);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.START);
            this.Name = "contact_tracing_app";
            this.Text = "Contact Tracing App";
            this.Load += new System.EventHandler(this.contact_tracing_app_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button START;
        private System.Windows.Forms.RichTextBox userinput;
    }
}

