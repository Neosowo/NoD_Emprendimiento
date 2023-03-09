namespace NoD
{
    partial class Developer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Developer));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(21, 65);
            label1.Name = "label1";
            label1.Size = new Size(420, 143);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(40, 252);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 1;
            button1.Text = "⤸";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(205, 23);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 2;
            label2.Text = "Dev";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(293, 252);
            label3.Name = "label3";
            label3.Size = new Size(61, 12);
            label3.TabIndex = 3;
            label3.Text = "Github: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 252);
            label4.Name = "label4";
            label4.Size = new Size(56, 13);
            label4.TabIndex = 4;
            label4.Text = "Neosowo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 272);
            label5.Name = "label5";
            label5.Size = new Size(56, 13);
            label5.TabIndex = 6;
            label5.Text = "@neow28";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(293, 273);
            label6.Name = "label6";
            label6.Size = new Size(61, 12);
            label6.TabIndex = 5;
            label6.Text = "Twitter:";
            // 
            // Developer
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(457, 319);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Developer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Developer";
            Load += Developer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}