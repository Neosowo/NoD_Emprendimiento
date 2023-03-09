namespace NoD
{
    partial class Estadisticas_descriptivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas_descriptivas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label12 = new Label();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 38);
            label1.Name = "label1";
            label1.Size = new Size(232, 16);
            label1.TabIndex = 0;
            label1.Text = "Estadísticas descriptivas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 75);
            label2.Name = "label2";
            label2.Size = new Size(455, 15);
            label2.TabIndex = 1;
            label2.Text = "Es una técnica utilizada en la estadística para resumir ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 99);
            label3.Name = "label3";
            label3.Size = new Size(559, 15);
            label3.TabIndex = 2;
            label3.Text = "y describir un conjunto de datos en términos de sus medidas centrales";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(325, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 20);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 188);
            label5.Name = "label5";
            label5.Size = new Size(255, 15);
            label5.TabIndex = 6;
            label5.Text = "Ingrese los números a calcular:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 346);
            label6.Name = "label6";
            label6.Size = new Size(70, 13);
            label6.TabIndex = 7;
            label6.Text = "Promedio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 392);
            label7.Name = "label7";
            label7.Size = new Size(56, 13);
            label7.TabIndex = 8;
            label7.Text = "Mínimo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(57, 297);
            label8.Name = "label8";
            label8.Size = new Size(35, 13);
            label8.TabIndex = 9;
            label8.Text = "Max:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(98, 297);
            label9.Name = "label9";
            label9.Size = new Size(23, 13);
            label9.TabIndex = 10;
            label9.Text = "--";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(117, 392);
            label10.Name = "label10";
            label10.Size = new Size(23, 13);
            label10.TabIndex = 11;
            label10.Text = "--";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(131, 346);
            label11.Name = "label11";
            label11.Size = new Size(23, 13);
            label11.TabIndex = 12;
            label11.Text = "--";
            // 
            // button1
            // 
            button1.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(485, 178);
            button1.Name = "button1";
            button1.Size = new Size(57, 34);
            button1.TabIndex = 13;
            button1.Text = ",";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(548, 140);
            button2.Name = "button2";
            button2.Size = new Size(85, 39);
            button2.TabIndex = 14;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(112, 245);
            label4.Name = "label4";
            label4.Size = new Size(23, 13);
            label4.TabIndex = 16;
            label4.Text = "--";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(55, 245);
            label12.Name = "label12";
            label12.Size = new Size(49, 13);
            label12.TabIndex = 15;
            label12.Text = "Total:";
            // 
            // button3
            // 
            button3.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(55, 455);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 17;
            button3.Text = "⤸";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(548, 209);
            button4.Name = "button4";
            button4.Size = new Size(85, 36);
            button4.TabIndex = 18;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(263, 279);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 243);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(152, 455);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 20;
            button5.Text = "☾ / ☼";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Estadisticas_descriptivas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(692, 520);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label12);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Estadisticas_descriptivas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas_descriptivas";
            Load += Estadisticas_descriptivas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label12;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button5;
    }
}