namespace NoD
{
    partial class Validacion_de_cedula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validacion_de_cedula));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 39);
            label1.Name = "label1";
            label1.Size = new Size(187, 16);
            label1.TabIndex = 0;
            label1.Text = "Validación de cédula";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(613, 405);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 79);
            label2.Name = "label2";
            label2.Size = new Size(311, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el número de cédula a validar:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(51, 126);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 20);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 191);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Su cédula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(165, 191);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 5;
            label4.Text = "es valida.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(136, 191);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 6;
            label5.Text = "--";
            label5.TextChanged += textBox1_TextChanged;
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("MS Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(47, 349);
            button1.Name = "button1";
            button1.Size = new Size(87, 37);
            button1.TabIndex = 7;
            button1.Text = "⤸";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(51, 229);
            label6.Name = "label6";
            label6.Size = new Size(223, 15);
            label6.TabIndex = 8;
            label6.Text = "Su provincia de origen es: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(280, 229);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 9;
            label7.Text = "--";
            label7.TextChanged += textBox1_TextChanged;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(51, 290);
            label8.Name = "label8";
            label8.Size = new Size(47, 12);
            label8.TabIndex = 10;
            label8.Text = "Nota: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(101, 290);
            label9.Name = "label9";
            label9.Size = new Size(173, 12);
            label9.TabIndex = 11;
            label9.Text = "Pulse enter para actualizar.";
            // 
            // button2
            // 
            button2.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(166, 351);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 12;
            button2.Text = "☾ / ☼";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Validacion_de_cedula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(531, 419);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Validacion_de_cedula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validacion_de_cedula";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label6;
        private Label label7;
        public Label label5;
        private Label label8;
        private Label label9;
        private Button button2;
    }
}