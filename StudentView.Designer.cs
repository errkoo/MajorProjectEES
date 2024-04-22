namespace MajorProjectEES
{
    partial class StudentView
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
            this.refresh_button = new System.Windows.Forms.Button();
            this.studentid_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.classesComboBox = new System.Windows.Forms.ComboBox();
            this.Enroll = new System.Windows.Forms.Label();
            this.enroll_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(201, 349);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(106, 38);
            this.refresh_button.TabIndex = 13;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // studentid_box
            // 
            this.studentid_box.Location = new System.Drawing.Point(225, 66);
            this.studentid_box.Name = "studentid_box";
            this.studentid_box.Size = new System.Drawing.Size(58, 26);
            this.studentid_box.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(333, 162);
            this.dataGridView1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "My Classes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student ID:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(398, 69);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(201, 37);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Welcome \"\"!";
            // 
            // classesComboBox
            // 
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Location = new System.Drawing.Point(718, 182);
            this.classesComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(180, 28);
            this.classesComboBox.TabIndex = 14;
            // 
            // Enroll
            // 
            this.Enroll.AutoSize = true;
            this.Enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enroll.Location = new System.Drawing.Point(586, 182);
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(116, 25);
            this.Enroll.TabIndex = 15;
            this.Enroll.Text = "All Classes:";
            // 
            // enroll_button
            // 
            this.enroll_button.Location = new System.Drawing.Point(794, 248);
            this.enroll_button.Name = "enroll_button";
            this.enroll_button.Size = new System.Drawing.Size(106, 38);
            this.enroll_button.TabIndex = 16;
            this.enroll_button.Text = "Enroll";
            this.enroll_button.UseVisualStyleBackColor = true;
            this.enroll_button.Click += new System.EventHandler(this.enroll_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(385, 350);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(106, 38);
            this.logout_button.TabIndex = 17;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 498);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.enroll_button);
            this.Controls.Add(this.Enroll);
            this.Controls.Add(this.classesComboBox);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.studentid_box);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentView";
            this.Text = "StudentView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.TextBox studentid_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ComboBox classesComboBox;
        private System.Windows.Forms.Label Enroll;
        private System.Windows.Forms.Button enroll_button;
        private System.Windows.Forms.Button logout_button;
    }
}