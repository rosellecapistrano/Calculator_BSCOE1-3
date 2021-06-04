
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contact_tracing_app));
            this.DONE = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.temperature = new System.Windows.Forms.Label();
            this.temperaturetxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DONE
            // 
            this.DONE.Location = new System.Drawing.Point(117, 300);
            this.DONE.Name = "DONE";
            this.DONE.Size = new System.Drawing.Size(130, 43);
            this.DONE.TabIndex = 0;
            this.DONE.Text = "DONE";
            this.DONE.UseVisualStyleBackColor = true;
            this.DONE.Click += new System.EventHandler(this.START_Click);
            // 
            // welcome
            // 
            this.welcome.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome.Location = new System.Drawing.Point(86, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(185, 51);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Contact Tracing App";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(61, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 15);
            this.name.TabIndex = 2;
            this.name.Text = "Name:";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(105, 107);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(206, 23);
            this.nametxt.TabIndex = 3;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(67, 139);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(32, 15);
            this.address.TabIndex = 4;
            this.address.Text = "Add:";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(105, 136);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(206, 23);
            this.addresstxt.TabIndex = 5;
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Location = new System.Drawing.Point(61, 168);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(39, 15);
            this.temperature.TabIndex = 6;
            this.temperature.Text = "Temp:";
            // 
            // temperaturetxt
            // 
            this.temperaturetxt.Location = new System.Drawing.Point(105, 165);
            this.temperaturetxt.Name = "temperaturetxt";
            this.temperaturetxt.Size = new System.Drawing.Size(206, 23);
            this.temperaturetxt.TabIndex = 7;
            // 
            // contact_tracing_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 355);
            this.Controls.Add(this.temperaturetxt);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.address);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.DONE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "contact_tracing_app";
            this.Text = "Contact Tracing App";
            this.Load += new System.EventHandler(this.contact_tracing_app_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DONE;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.TextBox temperaturetxt;
    }
}

