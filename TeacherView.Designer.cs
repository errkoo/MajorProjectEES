namespace MajorProjectEES
{
    partial class TeacherView
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_class_button = new System.Windows.Forms.Button();
            this.teacherid_box = new System.Windows.Forms.TextBox();
            this.refresh_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(291, 43);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(201, 37);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome \"\"!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "My Classes:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(182, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(537, 162);
            this.dataGridView1.TabIndex = 3;
            // 
            // add_class_button
            // 
            this.add_class_button.Location = new System.Drawing.Point(212, 368);
            this.add_class_button.Name = "add_class_button";
            this.add_class_button.Size = new System.Drawing.Size(106, 38);
            this.add_class_button.TabIndex = 4;
            this.add_class_button.Text = "Add Class";
            this.add_class_button.UseVisualStyleBackColor = true;
            this.add_class_button.Click += new System.EventHandler(this.add_class_button_Click);
            // 
            // teacherid_box
            // 
            this.teacherid_box.Location = new System.Drawing.Point(118, 40);
            this.teacherid_box.Name = "teacherid_box";
            this.teacherid_box.Size = new System.Drawing.Size(58, 26);
            this.teacherid_box.TabIndex = 5;
            this.teacherid_box.TextChanged += new System.EventHandler(this.teacherid_box_TextChanged);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(372, 368);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(106, 38);
            this.refresh_button.TabIndex = 6;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(530, 368);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(106, 38);
            this.logout_button.TabIndex = 7;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.teacherid_box);
            this.Controls.Add(this.add_class_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "TeacherView";
            this.Text = "TeacherView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_class_button;
        private System.Windows.Forms.TextBox teacherid_box;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button logout_button;
    }
}