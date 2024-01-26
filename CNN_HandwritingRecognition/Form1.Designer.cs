namespace CNN_HandwritingRecognition
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(108, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 420);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(236, 47);
            label1.Name = "label1";
            label1.Size = new Size(700, 59);
            label1.TabIndex = 1;
            label1.Text = "CNN Handwriting Recognition";
            // 
            // button1
            // 
            button1.Font = new Font("Bell MT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(593, 149);
            button1.Name = "button1";
            button1.Size = new Size(463, 56);
            button1.TabIndex = 2;
            button1.Text = "Mode : Enlarging the Database";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            panel.Location = new Point(593, 229);
            panel.Name = "panel";
            panel.Size = new Size(463, 340);
            panel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 643);
            Controls.Add(panel);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Panel panel;
    }
}