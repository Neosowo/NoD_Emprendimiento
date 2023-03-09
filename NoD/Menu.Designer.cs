namespace NoD
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            label3 = new Label();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            button3 = new Button();
            radioButton8 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 36);
            label1.Name = "label1";
            label1.Size = new Size(207, 19);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido/a a NoD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 83);
            label2.Name = "label2";
            label2.Size = new Size(350, 13);
            label2.TabIndex = 1;
            label2.Text = "Un programa sencillo para cálculos en tu negocio.";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(365, 309);
            button1.Name = "button1";
            button1.Size = new Size(99, 33);
            button1.TabIndex = 2;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MS Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(60, 311);
            button2.Name = "button2";
            button2.Size = new Size(99, 31);
            button2.TabIndex = 3;
            button2.Text = "⤸";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(60, 146);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(186, 17);
            radioButton1.TabIndex = 4;
            radioButton1.Text = "Operaciones matemáticas";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += OM_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(60, 182);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(165, 17);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Validación de cédula";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(60, 216);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(158, 17);
            radioButton3.TabIndex = 6;
            radioButton3.Text = "Punto de equilibrio\n";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(264, 146);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(116, 17);
            radioButton4.TabIndex = 7;
            radioButton4.Text = "Ganancia neta\n";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton5.Location = new Point(264, 182);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(109, 17);
            radioButton5.TabIndex = 8;
            radioButton5.Text = "Depreciación";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 113);
            label3.Name = "label3";
            label3.Size = new Size(189, 13);
            label3.TabIndex = 9;
            label3.Text = "Elige una de las opciones:";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton6.Location = new Point(58, 251);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(200, 17);
            radioButton6.TabIndex = 10;
            radioButton6.TabStop = true;
            radioButton6.Text = "Estadísticas descriptivas";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton7.Location = new Point(264, 216);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(102, 17);
            radioButton7.TabIndex = 11;
            radioButton7.TabStop = true;
            radioButton7.Text = "Facturación";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(365, 31);
            button3.Name = "button3";
            button3.Size = new Size(99, 33);
            button3.TabIndex = 12;
            button3.Text = "☾ / ☼";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton8.Location = new Point(264, 251);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(88, 17);
            radioButton8.TabIndex = 13;
            radioButton8.TabStop = true;
            radioButton8.Text = "Developer";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(499, 384);
            Controls.Add(radioButton8);
            Controls.Add(button3);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Label label3;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private Button button3;
        private RadioButton radioButton8;
    }
}