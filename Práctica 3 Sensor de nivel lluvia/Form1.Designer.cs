namespace Practica_3_Sensor_de_nivel_de_agua
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            BotonComenzar = new Button();
            BotonSalir = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 41);
            label1.Name = "label1";
            label1.Size = new Size(412, 26);
            label1.TabIndex = 0;
            label1.Text = "Sensor de nivel de agua o lluvia\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(64, 191);
            label2.Name = "label2";
            label2.Size = new Size(232, 26);
            label2.TabIndex = 0;
            label2.Text = "Estado del sensor";
            label2.Click += label1_Click;
            // 
            // BotonComenzar
            // 
            BotonComenzar.BackColor = SystemColors.ActiveCaption;
            BotonComenzar.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonComenzar.Location = new Point(39, 355);
            BotonComenzar.Name = "BotonComenzar";
            BotonComenzar.Size = new Size(182, 50);
            BotonComenzar.TabIndex = 1;
            BotonComenzar.Text = "Comenzar";
            BotonComenzar.UseVisualStyleBackColor = false;
            BotonComenzar.Click += BotonComenzar_Click;
            // 
            // BotonSalir
            // 
            BotonSalir.BackColor = Color.Red;
            BotonSalir.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonSalir.Location = new Point(265, 355);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(182, 50);
            BotonSalir.TabIndex = 1;
            BotonSalir.Text = "Salir";
            BotonSalir.UseVisualStyleBackColor = false;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(410, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 161);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(751, 450);
            Controls.Add(pictureBox1);
            Controls.Add(BotonSalir);
            Controls.Add(BotonComenzar);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Sensor de nivel de agua o lluvia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BotonComenzar;
        private Button BotonSalir;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
