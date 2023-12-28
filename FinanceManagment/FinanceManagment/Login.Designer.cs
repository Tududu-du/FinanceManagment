namespace FinanceManagment
{
    partial class LoginBtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginBtn));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            ZarzadzanieFinansami = new Label();
            Wydatki = new Label();
            Przychód = new Label();
            pictureBox1 = new PictureBox();
            Loginlbl = new Label();
            Password = new Label();
            LoginBtt = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            UserNameTab = new Guna.UI2.WinForms.Guna2TextBox();
            PasswordTab = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 48, 77);
            panel1.Controls.Add(ZarzadzanieFinansami);
            panel1.Controls.Add(Wydatki);
            panel1.Controls.Add(Przychód);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 495);
            panel1.TabIndex = 0;
            // 
            // ZarzadzanieFinansami
            // 
            ZarzadzanieFinansami.AutoSize = true;
            ZarzadzanieFinansami.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ZarzadzanieFinansami.ForeColor = Color.FromArgb(240, 236, 229);
            ZarzadzanieFinansami.Location = new Point(0, 74);
            ZarzadzanieFinansami.Name = "ZarzadzanieFinansami";
            ZarzadzanieFinansami.Size = new Size(200, 23);
            ZarzadzanieFinansami.TabIndex = 23;
            ZarzadzanieFinansami.Text = "Zarzadzanie finansami";
            // 
            // Wydatki
            // 
            Wydatki.AutoSize = true;
            Wydatki.ForeColor = Color.FromArgb(240, 236, 229);
            Wydatki.Location = new Point(59, 193);
            Wydatki.Name = "Wydatki";
            Wydatki.Size = new Size(75, 22);
            Wydatki.TabIndex = 22;
            Wydatki.Text = "Wydatki";
            // 
            // Przychód
            // 
            Przychód.AutoSize = true;
            Przychód.ForeColor = Color.FromArgb(240, 236, 229);
            Przychód.Location = new Point(59, 129);
            Przychód.Name = "Przychód";
            Przychód.Size = new Size(81, 22);
            Przychód.TabIndex = 21;
            Przychód.Text = "Dochody";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Loginlbl
            // 
            Loginlbl.AutoSize = true;
            Loginlbl.Location = new Point(377, 129);
            Loginlbl.Name = "Loginlbl";
            Loginlbl.Size = new Size(168, 22);
            Loginlbl.TabIndex = 4;
            Loginlbl.Text = "Nazwa użytkownika";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(432, 237);
            Password.Name = "Password";
            Password.Size = new Size(57, 22);
            Password.TabIndex = 5;
            Password.Text = "Hasło";
            // 
            // LoginBtt
            // 
            LoginBtt.CustomizableEdges = customizableEdges1;
            LoginBtt.DisabledState.BorderColor = Color.DarkGray;
            LoginBtt.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginBtt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginBtt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginBtt.FillColor = Color.FromArgb(0, 0, 64);
            LoginBtt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoginBtt.ForeColor = Color.White;
            LoginBtt.Location = new Point(352, 361);
            LoginBtt.Name = "LoginBtt";
            LoginBtt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LoginBtt.Size = new Size(225, 56);
            LoginBtt.TabIndex = 6;
            LoginBtt.Text = "Login";
            LoginBtt.Click += LoginBtt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(735, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 46);
            label1.TabIndex = 7;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // UserNameTab
            // 
            UserNameTab.CustomizableEdges = customizableEdges3;
            UserNameTab.DefaultText = "";
            UserNameTab.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UserNameTab.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UserNameTab.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UserNameTab.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UserNameTab.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UserNameTab.Font = new Font("Segoe UI", 9F);
            UserNameTab.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UserNameTab.Location = new Point(268, 155);
            UserNameTab.Margin = new Padding(3, 4, 3, 4);
            UserNameTab.Name = "UserNameTab";
            UserNameTab.PasswordChar = '\0';
            UserNameTab.PlaceholderText = "";
            UserNameTab.SelectedText = "";
            UserNameTab.ShadowDecoration.CustomizableEdges = customizableEdges4;
            UserNameTab.Size = new Size(388, 60);
            UserNameTab.TabIndex = 1;
            // 
            // PasswordTab
            // 
            PasswordTab.CustomizableEdges = customizableEdges5;
            PasswordTab.DefaultText = "";
            PasswordTab.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTab.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTab.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTab.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTab.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTab.Font = new Font("Segoe UI", 9F);
            PasswordTab.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTab.Location = new Point(268, 274);
            PasswordTab.Margin = new Padding(3, 4, 3, 4);
            PasswordTab.Name = "PasswordTab";
            PasswordTab.PasswordChar = '●';
            PasswordTab.PlaceholderText = "";
            PasswordTab.ReadOnly = true;
            PasswordTab.SelectedText = "";
            PasswordTab.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PasswordTab.Size = new Size(388, 60);
            PasswordTab.TabIndex = 8;
            PasswordTab.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 495);
            Controls.Add(PasswordTab);
            Controls.Add(label1);
            Controls.Add(LoginBtt);
            Controls.Add(Password);
            Controls.Add(Loginlbl);
            Controls.Add(pictureBox1);
            Controls.Add(UserNameTab);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginBtn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox UserNameTab;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTab;
        private PictureBox pictureBox1;
        private Label Loginlbl;
        private Label Password;
        private Guna.UI2.WinForms.Guna2Button LoginBtt;
        private Label Przychód;
        private Label Wydatki;
        private Label ZarzadzanieFinansami;
        private Label label1;
    }
}