namespace NoD
{
    partial class Depreciacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depreciacion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            Calcular = new Button();
            button2 = new Button();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 35);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Depreciación";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 71);
            label2.Name = "label2";
            label2.Size = new Size(525, 13);
            label2.TabIndex = 1;
            label2.Text = "Es la disminución del valor de un activo con el tiempo debido al desgaste.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 117);
            label3.Name = "label3";
            label3.Size = new Size(252, 13);
            label3.TabIndex = 2;
            label3.Text = "Escoge la categoria de tu producto:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(60, 160);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 17);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Inmuebles";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(178, 160);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 17);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Maquinaria";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(303, 160);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(88, 17);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Vehículos";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(414, 160);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(165, 17);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Equipos informáticos";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 222);
            label4.Name = "label4";
            label4.Size = new Size(182, 13);
            label4.TabIndex = 7;
            label4.Text = "Ingrese el año de compra:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 218);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(54, 273);
            label5.Name = "label5";
            label5.Size = new Size(133, 13);
            label5.TabIndex = 9;
            label5.Text = "Ingrese el precio:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(594, 218);
            textBox3.MaxLength = 4;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(392, 222);
            label6.Name = "label6";
            label6.Size = new Size(196, 13);
            label6.TabIndex = 11;
            label6.Text = "Ingrese el año a depreciar:";
            // 
            // Calcular
            // 
            Calcular.BackColor = Color.FromArgb(128, 128, 255);
            Calcular.FlatStyle = FlatStyle.Flat;
            Calcular.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Calcular.ForeColor = SystemColors.ControlLightLight;
            Calcular.Location = new Point(629, 374);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(95, 33);
            Calcular.TabIndex = 13;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += Calcular_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(54, 374);
            button2.Name = "button2";
            button2.Size = new Size(95, 33);
            button2.TabIndex = 14;
            button2.Text = "⤸";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(54, 318);
            label7.Name = "label7";
            label7.Size = new Size(126, 13);
            label7.TabIndex = 15;
            label7.Text = "Valor depreciado:";
            // 
            // button1
            // 
            button1.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(299, 269);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = ",";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(197, 318);
            label8.Name = "label8";
            label8.Size = new Size(23, 13);
            label8.TabIndex = 17;
            label8.Text = "--";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(495, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(813, 415);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(178, 374);
            button3.Name = "button3";
            button3.Size = new Size(75, 33);
            button3.TabIndex = 19;
            button3.Text = "☾ / ☼";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Depreciacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(782, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(Calcular);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Depreciacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Depreciacion";
            Load += Depreciacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Button Calcular;
        private Button button2;
        private Label label7;
        private Button button1;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button3;
    }
}