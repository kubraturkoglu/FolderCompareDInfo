
namespace WindowsFormsApp1
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
            this.btn_foler1 = new System.Windows.Forms.Button();
            this.checkbox_dif = new System.Windows.Forms.CheckBox();
            this.listBox_folder1 = new System.Windows.Forms.ListBox();
            this.listBox_folder2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_folder1 = new System.Windows.Forms.Label();
            this.btn_foler2 = new System.Windows.Forms.Button();
            this.compare = new System.Windows.Forms.Button();
            this.lbl_folder2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_extime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_foler1
            // 
            this.btn_foler1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_foler1.Location = new System.Drawing.Point(510, 15);
            this.btn_foler1.Name = "btn_foler1";
            this.btn_foler1.Size = new System.Drawing.Size(69, 47);
            this.btn_foler1.TabIndex = 0;
            this.btn_foler1.Text = "...";
            this.btn_foler1.UseVisualStyleBackColor = true;
            this.btn_foler1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkbox_dif
            // 
            this.checkbox_dif.AutoSize = true;
            this.checkbox_dif.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkbox_dif.Location = new System.Drawing.Point(607, 37);
            this.checkbox_dif.Name = "checkbox_dif";
            this.checkbox_dif.Size = new System.Drawing.Size(118, 25);
            this.checkbox_dif.TabIndex = 1;
            this.checkbox_dif.Text = "Difference";
            this.checkbox_dif.UseVisualStyleBackColor = true;
            // 
            // listBox_folder1
            // 
            this.listBox_folder1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_folder1.FormattingEnabled = true;
            this.listBox_folder1.ItemHeight = 21;
            this.listBox_folder1.Location = new System.Drawing.Point(12, 135);
            this.listBox_folder1.Name = "listBox_folder1";
            this.listBox_folder1.Size = new System.Drawing.Size(598, 487);
            this.listBox_folder1.Sorted = true;
            this.listBox_folder1.TabIndex = 2;
            this.listBox_folder1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // listBox_folder2
            // 
            this.listBox_folder2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_folder2.FormattingEnabled = true;
            this.listBox_folder2.ItemHeight = 21;
            this.listBox_folder2.Location = new System.Drawing.Point(644, 135);
            this.listBox_folder2.Name = "listBox_folder2";
            this.listBox_folder2.Size = new System.Drawing.Size(604, 487);
            this.listBox_folder2.TabIndex = 3;
            this.listBox_folder2.SelectedIndexChanged += new System.EventHandler(this.listBox_folder2_SelectedIndexChanged);
            this.listBox_folder2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 4;
            // 
            // lbl_folder1
            // 
            this.lbl_folder1.BackColor = System.Drawing.Color.White;
            this.lbl_folder1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_folder1.Location = new System.Drawing.Point(15, 16);
            this.lbl_folder1.Name = "lbl_folder1";
            this.lbl_folder1.Size = new System.Drawing.Size(489, 50);
            this.lbl_folder1.TabIndex = 5;
            this.lbl_folder1.Text = "Folder1";
            this.lbl_folder1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_foler2
            // 
            this.btn_foler2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_foler2.Location = new System.Drawing.Point(740, 12);
            this.btn_foler2.Name = "btn_foler2";
            this.btn_foler2.Size = new System.Drawing.Size(69, 47);
            this.btn_foler2.TabIndex = 6;
            this.btn_foler2.Text = "...";
            this.btn_foler2.UseVisualStyleBackColor = true;
            this.btn_foler2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // compare
            // 
            this.compare.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.compare.Location = new System.Drawing.Point(607, 76);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(119, 41);
            this.compare.TabIndex = 7;
            this.compare.Text = "Compare";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click_1);
            // 
            // lbl_folder2
            // 
            this.lbl_folder2.BackColor = System.Drawing.Color.White;
            this.lbl_folder2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_folder2.Location = new System.Drawing.Point(815, 15);
            this.lbl_folder2.Name = "lbl_folder2";
            this.lbl_folder2.Size = new System.Drawing.Size(433, 48);
            this.lbl_folder2.TabIndex = 8;
            this.lbl_folder2.Text = "Folder1";
            this.lbl_folder2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.load2;
            this.pictureBox2.Location = new System.Drawing.Point(986, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.load2;
            this.pictureBox1.Location = new System.Drawing.Point(237, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_extime
            // 
            this.lbl_extime.AutoSize = true;
            this.lbl_extime.Location = new System.Drawing.Point(519, 97);
            this.lbl_extime.Name = "lbl_extime";
            this.lbl_extime.Size = new System.Drawing.Size(27, 20);
            this.lbl_extime.TabIndex = 11;
            this.lbl_extime.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 632);
            this.Controls.Add(this.lbl_extime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_folder2);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.btn_foler2);
            this.Controls.Add(this.lbl_folder1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_folder2);
            this.Controls.Add(this.listBox_folder1);
            this.Controls.Add(this.checkbox_dif);
            this.Controls.Add(this.btn_foler1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_foler1;
        private System.Windows.Forms.CheckBox checkbox_dif;
        private System.Windows.Forms.ListBox listBox_folder1;
        private System.Windows.Forms.ListBox listBox_folder2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_folder1;
        private System.Windows.Forms.Button btn_foler2;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Label lbl_folder2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_extime;
    }
}

