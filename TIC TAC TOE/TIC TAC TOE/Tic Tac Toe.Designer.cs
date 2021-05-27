
namespace WinFormsApp1
{
    partial class TICTACTOE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TICTACTOE));
            this.box1 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box1.Location = new System.Drawing.Point(8, 42);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(89, 89);
            this.box1.TabIndex = 0;
            this.box1.UseVisualStyleBackColor = true;
            this.box1.Click += new System.EventHandler(this.box_Click);
            // 
            // box2
            // 
            this.box2.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box2.Location = new System.Drawing.Point(103, 42);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(89, 89);
            this.box2.TabIndex = 1;
            this.box2.UseVisualStyleBackColor = true;
            this.box2.Click += new System.EventHandler(this.box_Click);
            // 
            // box3
            // 
            this.box3.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box3.Location = new System.Drawing.Point(198, 42);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(89, 89);
            this.box3.TabIndex = 2;
            this.box3.UseVisualStyleBackColor = true;
            this.box3.Click += new System.EventHandler(this.box_Click);
            // 
            // box4
            // 
            this.box4.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box4.Location = new System.Drawing.Point(8, 137);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(89, 89);
            this.box4.TabIndex = 3;
            this.box4.UseVisualStyleBackColor = true;
            this.box4.Click += new System.EventHandler(this.box_Click);
            // 
            // box5
            // 
            this.box5.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box5.Location = new System.Drawing.Point(103, 137);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(89, 89);
            this.box5.TabIndex = 4;
            this.box5.UseVisualStyleBackColor = true;
            this.box5.Click += new System.EventHandler(this.box_Click);
            // 
            // box6
            // 
            this.box6.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box6.Location = new System.Drawing.Point(198, 137);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(89, 89);
            this.box6.TabIndex = 5;
            this.box6.UseVisualStyleBackColor = true;
            this.box6.Click += new System.EventHandler(this.box_Click);
            // 
            // box7
            // 
            this.box7.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box7.Location = new System.Drawing.Point(8, 232);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(89, 89);
            this.box7.TabIndex = 6;
            this.box7.UseVisualStyleBackColor = true;
            this.box7.Click += new System.EventHandler(this.box_Click);
            // 
            // box8
            // 
            this.box8.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box8.Location = new System.Drawing.Point(103, 232);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(89, 89);
            this.box8.TabIndex = 7;
            this.box8.UseVisualStyleBackColor = true;
            this.box8.Click += new System.EventHandler(this.box_Click);
            // 
            // box9
            // 
            this.box9.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box9.Location = new System.Drawing.Point(198, 232);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(89, 89);
            this.box9.TabIndex = 8;
            this.box9.UseVisualStyleBackColor = true;
            this.box9.Click += new System.EventHandler(this.box_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "TURN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(130, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 36);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewGame.Location = new System.Drawing.Point(8, 12);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(77, 21);
            this.NewGame.TabIndex = 11;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit.Location = new System.Drawing.Point(91, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(77, 21);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit Game";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.About.Location = new System.Drawing.Point(174, 12);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(77, 21);
            this.About.TabIndex = 13;
            this.About.Text = "About Game";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // TICTACTOE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 372);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TICTACTOE";
            this.Text = "Tic Tac Toe ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button box1;
        private System.Windows.Forms.Button box2;
        private System.Windows.Forms.Button box3;
        private System.Windows.Forms.Button box4;
        private System.Windows.Forms.Button box5;
        private System.Windows.Forms.Button box6;
        private System.Windows.Forms.Button box7;
        private System.Windows.Forms.Button box8;
        private System.Windows.Forms.Button box9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button About;
    }
}

