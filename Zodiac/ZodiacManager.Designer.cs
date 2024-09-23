namespace Zodiac
{
    partial class ZodiacManager
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
            lblWelcome = new Label();
            btnShowImage = new Button();
            picImage = new PictureBox();
            pnlImage = new Panel();
            btnCheckZodiac = new Button();
            btnQuit = new Button();
            lblDay = new Label();
            lblMonth = new Label();
            lblResult = new Label();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            lblCopyRight = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnlImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblWelcome.ForeColor = Color.Yellow;
            lblWelcome.Location = new Point(28, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(658, 106);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Zodiac Calculator";
            // 
            // btnShowImage
            // 
            btnShowImage.FlatStyle = FlatStyle.Flat;
            btnShowImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnShowImage.ForeColor = Color.Yellow;
            btnShowImage.Location = new Point(53, 258);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(136, 52);
            btnShowImage.TabIndex = 2;
            btnShowImage.Text = "Show Image";
            btnShowImage.UseVisualStyleBackColor = true;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // picImage
            // 
            picImage.BackColor = Color.Lime;
            picImage.Location = new Point(3, 3);
            picImage.Name = "picImage";
            picImage.Size = new Size(737, 723);
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            picImage.Click += picImage_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BackColor = Color.Cyan;
            pnlImage.Controls.Add(picImage);
            pnlImage.Location = new Point(745, 12);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(743, 729);
            pnlImage.TabIndex = 3;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.FlatStyle = FlatStyle.Flat;
            btnCheckZodiac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnCheckZodiac.ForeColor = Color.Yellow;
            btnCheckZodiac.Location = new Point(195, 258);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(169, 52);
            btnCheckZodiac.TabIndex = 3;
            btnCheckZodiac.Text = "Check Zodiac";
            btnCheckZodiac.UseVisualStyleBackColor = true;
            btnCheckZodiac.Click += btnCheckZodiac_Click;
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnQuit.ForeColor = Color.Yellow;
            btnQuit.Location = new Point(370, 258);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(136, 52);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblDay.ForeColor = Color.Yellow;
            lblDay.Location = new Point(46, 130);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(157, 31);
            lblDay.TabIndex = 6;
            lblDay.Text = "Your birth day";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblMonth.ForeColor = Color.Yellow;
            lblMonth.Location = new Point(46, 186);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(187, 31);
            lblMonth.TabIndex = 7;
            lblMonth.Text = "Your birth month";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            lblResult.ForeColor = Color.Yellow;
            lblResult.Location = new Point(28, 505);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(327, 46);
            lblResult.TabIndex = 8;
            lblResult.Text = "Your zodiac sign is ";
            lblResult.Click += lblResult_Click_1;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(209, 134);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(125, 27);
            txtDay.TabIndex = 0;
            txtDay.Text = "1";
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(239, 190);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(125, 27);
            txtMonth.TabIndex = 1;
            txtMonth.Text = "1";
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblCopyRight.ForeColor = Color.Yellow;
            lblCopyRight.Location = new Point(53, 627);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(251, 31);
            lblCopyRight.TabIndex = 9;
            lblCopyRight.Text = "© 2024 GaHocCode215";
            lblCopyRight.Click += label1_Click;
            // 
            // ZodiacManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Red;
            ClientSize = new Size(1500, 753);
            Controls.Add(lblCopyRight);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(lblResult);
            Controls.Add(lblMonth);
            Controls.Add(lblDay);
            Controls.Add(btnQuit);
            Controls.Add(btnCheckZodiac);
            Controls.Add(pnlImage);
            Controls.Add(btnShowImage);
            Controls.Add(lblWelcome);
            Name = "ZodiacManager";
            Text = "ZodiacManager";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnShowImage;
        private PictureBox picImage;
        private Panel pnlImage;
        private Button btnCheckZodiac;
        private Button btnQuit;
        private Label lblDay;
        private Label lblMonth;
        private Label lblResult;
        private TextBox txtDay;
        private TextBox txtMonth;
        private Label lblCopyRight;
    }
}
