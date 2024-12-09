
namespace RoomieFinal
{
    partial class AdminAnnounceManage
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
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(2, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "N";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(39, 46);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "A";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(99, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "S";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(167, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 30);
            this.button5.TabIndex = 20;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Announcements";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Subject";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "No Classes\r\n\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Admin";
            // 
            // AdminAnnounceManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Name = "AdminAnnounceManage";
            this.Text = "AdminAnnounceManage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}