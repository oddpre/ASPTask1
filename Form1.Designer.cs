namespace WindowsFormAPPTask1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            studName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            studId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(434, 95);
            label1.Name = "label1";
            label1.Size = new Size(99, 22);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(410, 161);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // studName
            // 
            studName.AcceptsTab = true;
            studName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studName.Location = new Point(543, 161);
            studName.Name = "studName";
            studName.Size = new Size(226, 26);
            studName.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(694, 239);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(694, 287);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ScrollBar;
            linkLabel1.BorderStyle = BorderStyle.Fixed3D;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(543, 284);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Padding = new Padding(5);
            linkLabel1.Size = new Size(145, 28);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Contact Administrator";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 298);
            label4.Name = "label4";
            label4.Size = new Size(248, 15);
            label4.TabIndex = 9;
            label4.Text = "Developed for Utrecht University by @Oddpre";
            // 
            // studId
            // 
            studId.AcceptsTab = true;
            studId.AccessibleName = "";
            studId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studId.Location = new Point(543, 93);
            studId.Name = "studId";
            studId.Size = new Size(226, 26);
            studId.TabIndex = 3;
            studId.TextChanged += studId_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 338);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(studName);
            Controls.Add(studId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(817, 378);
            MinimumSize = new Size(816, 376);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox studName;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private Label label4;
        private TextBox studId;
    }
}
