namespace NoD
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
            UserBOX = new TextBox();
            PassBOX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonI = new Button();
            close = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserBOX
            // 
            UserBOX.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UserBOX.Location = new Point(120, 285);
            UserBOX.Margin = new Padding(4, 2, 4, 2);
            UserBOX.Name = "UserBOX";
            UserBOX.Size = new Size(149, 20);
            UserBOX.TabIndex = 1;
            UserBOX.TextChanged += textBox1_TextChanged;
            // 
            // PassBOX
            // 
            PassBOX.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PassBOX.Location = new Point(120, 380);
            PassBOX.Margin = new Padding(4, 2, 4, 2);
            PassBOX.Name = "PassBOX";
            PassBOX.PasswordChar = '*';
            PassBOX.Size = new Size(149, 20);
            PassBOX.TabIndex = 2;
            PassBOX.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 256);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 2;
            label1.Text = "User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(120, 353);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 16);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // buttonI
            // 
            buttonI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonI.BackColor = Color.FromArgb(128, 128, 255);
            buttonI.FlatStyle = FlatStyle.Flat;
            buttonI.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonI.ForeColor = SystemColors.ControlLightLight;
            buttonI.Location = new Point(295, 445);
            buttonI.Margin = new Padding(4, 2, 4, 2);
            buttonI.Name = "buttonI";
            buttonI.Size = new Size(75, 30);
            buttonI.TabIndex = 3;
            buttonI.Text = "Ingresar";
            buttonI.UseVisualStyleBackColor = false;
            buttonI.Click += buttonI_Click;
            // 
            // close
            // 
            close.BackColor = SystemColors.ControlLightLight;
            close.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            close.Location = new Point(49, 445);
            close.Margin = new Padding(4, 2, 4, 2);
            close.Name = "close";
            close.Size = new Size(75, 30);
            close.TabIndex = 4;
            close.Text = "Close";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-173, -48);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(757, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("MS Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(311, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "☾ / ☼";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(415, 526);
            Controls.Add(button1);
            Controls.Add(UserBOX);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(buttonI);
            Controls.Add(PassBOX);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserBOX;
        private TextBox PassBOX;
        private Label label1;
        private Label label2;
        private Button buttonI;
        private Button close;
        private PictureBox pictureBox1;
        private Button button1;
    }
}