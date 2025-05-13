namespace Practica_2_Arduino_HumedadyTemperatura
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
            pictureBox2 = new PictureBox();
            listBox1 = new ListBox();
            temperaturaLabel = new Label();
            humedadLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.very_hot_high_temperature;
            pictureBox1.Location = new Point(39, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox2.Image = Properties.Resources._5fe330eb8d8ed15eb710e23946503a49;
            pictureBox2.Location = new Point(39, 294);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(274, 195);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(410, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(486, 452);
            listBox1.TabIndex = 2;
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            temperaturaLabel.Location = new Point(49, 232);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new Size(216, 32);
            temperaturaLabel.TabIndex = 3;
            temperaturaLabel.Text = "temperaturaLabel";
            // 
            // humedadLabel
            // 
            humedadLabel.AutoSize = true;
            humedadLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            humedadLabel.Location = new Point(39, 492);
            humedadLabel.Name = "humedadLabel";
            humedadLabel.Size = new Size(181, 32);
            humedadLabel.TabIndex = 4;
            humedadLabel.Text = "humedadLabel";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(39, 548);
            button1.Name = "button1";
            button1.Size = new Size(248, 56);
            button1.TabIndex = 5;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(618, 535);
            button2.Name = "button2";
            button2.Size = new Size(210, 56);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(918, 616);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(humedadLabel);
            Controls.Add(temperaturaLabel);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Practica 2 Arduino HumedadyTemperatura";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox listBox1;
        private Label temperaturaLabel;
        private Label humedadLabel;
        private Button button1;
        private Button button2;
    }
}
