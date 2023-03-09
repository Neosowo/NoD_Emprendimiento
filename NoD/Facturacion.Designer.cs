namespace NoD
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 34);
            label1.Name = "label1";
            label1.Size = new Size(106, 16);
            label1.TabIndex = 0;
            label1.Text = "Facturación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 99);
            label2.Name = "label2";
            label2.Size = new Size(255, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese los números a calcular:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 19);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(506, 63);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 3;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(506, 122);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 4;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(39, 323);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 5;
            button3.Text = "⤸";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 156);
            label3.Name = "label3";
            label3.Size = new Size(70, 13);
            label3.TabIndex = 6;
            label3.Text = "Subtotal:";
            // 
            // button4
            // 
            button4.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(460, 92);
            button4.Name = "button4";
            button4.Size = new Size(40, 30);
            button4.TabIndex = 8;
            button4.Text = ",";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 192);
            label4.Name = "label4";
            label4.Size = new Size(98, 13);
            label4.TabIndex = 9;
            label4.Text = "I.V.A. (12%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 230);
            label5.Name = "label5";
            label5.Size = new Size(77, 13);
            label5.TabIndex = 10;
            label5.Text = "Retención:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(39, 268);
            label7.Name = "label7";
            label7.Size = new Size(105, 13);
            label7.TabIndex = 11;
            label7.Text = "Total a pagar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(160, 268);
            label6.Name = "label6";
            label6.Size = new Size(23, 13);
            label6.TabIndex = 15;
            label6.Text = "--";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(132, 230);
            label8.Name = "label8";
            label8.Size = new Size(23, 13);
            label8.TabIndex = 14;
            label8.Text = "--";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(160, 192);
            label9.Name = "label9";
            label9.Size = new Size(23, 13);
            label9.TabIndex = 13;
            label9.Text = "--";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(132, 156);
            label10.Name = "label10";
            label10.Size = new Size(23, 13);
            label10.TabIndex = 12;
            label10.Text = "--";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 363);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(137, 323);
            button5.Name = "button5";
            button5.Size = new Size(75, 27);
            button5.TabIndex = 17;
            button5.Text = "☾ / ☼";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(631, 383);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Facturacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturacion";
            Load += Facturacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private Button button5;
    }
}