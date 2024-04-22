namespace MajorProjectEES
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.student_button = new System.Windows.Forms.RadioButton();
            this.browse_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.teacher_button = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(118, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(123, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(264, 149);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(132, 26);
            this.username.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(264, 201);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(132, 26);
            this.password.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(455, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Image:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(539, 151);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(157, 119);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // student_button
            // 
            this.student_button.AutoSize = true;
            this.student_button.Checked = true;
            this.student_button.Location = new System.Drawing.Point(158, 350);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(91, 24);
            this.student_button.TabIndex = 9;
            this.student_button.TabStop = true;
            this.student_button.Text = "Student";
            this.student_button.UseVisualStyleBackColor = true;
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(512, 286);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(98, 36);
            this.browse_button.TabIndex = 10;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click_1);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(616, 286);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(98, 36);
            this.save_button.TabIndex = 11;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // teacher_button
            // 
            this.teacher_button.AutoSize = true;
            this.teacher_button.Location = new System.Drawing.Point(264, 350);
            this.teacher_button.Name = "teacher_button";
            this.teacher_button.Size = new System.Drawing.Size(92, 24);
            this.teacher_button.TabIndex = 12;
            this.teacher_button.Text = "Teacher";
            this.teacher_button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(113, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(112, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "First Name:";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(264, 286);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(132, 26);
            this.last_name.TabIndex = 16;
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(264, 244);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(132, 26);
            this.first_name.TabIndex = 15;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(402, 402);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(98, 36);
            this.register_button.TabIndex = 17;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.teacher_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.student_button);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton student_button;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.RadioButton teacher_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button button1;
    }
}