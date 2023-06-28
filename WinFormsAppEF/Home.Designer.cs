namespace WinFormsAppEF
{
    partial class Home
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
            userBtn = new Button();
            panel2 = new Panel();
            productBtn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // userBtn
            // 
            userBtn.BackColor = Color.FromArgb(34, 45, 50);
            userBtn.Cursor = Cursors.Hand;
            userBtn.FlatStyle = FlatStyle.Flat;
            userBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userBtn.ForeColor = Color.White;
            userBtn.Location = new Point(0, 0);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(270, 57);
            userBtn.TabIndex = 1;
            userBtn.Text = "Users";
            userBtn.UseVisualStyleBackColor = false;
            userBtn.Click += userBtn_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(productBtn);
            panel2.Controls.Add(userBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1103, 55);
            panel2.TabIndex = 4;
            // 
            // productBtn
            // 
            productBtn.BackColor = Color.FromArgb(34, 45, 50);
            productBtn.Cursor = Cursors.Hand;
            productBtn.FlatStyle = FlatStyle.Flat;
            productBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productBtn.ForeColor = Color.White;
            productBtn.Location = new Point(266, 0);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(270, 57);
            productBtn.TabIndex = 2;
            productBtn.Text = "Products";
            productBtn.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 712);
            Controls.Add(panel2);
            IsMdiContainer = true;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Button userBtn;
        private Panel panel2;
        public Button productBtn;
    }
}