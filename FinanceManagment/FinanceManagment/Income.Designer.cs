namespace FinanceManagment
{
    partial class Dochod
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dochod));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ListaPrzychodów = new Label();
            IncomeList = new Guna.UI2.WinForms.Guna2DataGridView();
            Usuń = new Button();
            Edytuj = new Button();
            Dodaj = new Button();
            IncValueBOX = new TextBox();
            CatIncBOX = new TextBox();
            DescIncBOX = new TextBox();
            Opis = new Label();
            Data = new Label();
            Kategoria = new Label();
            Wartość = new Label();
            Przychód = new Label();
            IncNameBOX = new TextBox();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            ZarzadzanieFinansami = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            Dashboard = new PictureBox();
            Income = new PictureBox();
            pictureBox1 = new PictureBox();
            DateTab = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)IncomeList).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Income).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ListaPrzychodów
            // 
            ListaPrzychodów.AutoSize = true;
            ListaPrzychodów.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ListaPrzychodów.ForeColor = Color.FromArgb(240, 236, 229);
            ListaPrzychodów.Location = new Point(791, 93);
            ListaPrzychodów.Name = "ListaPrzychodów";
            ListaPrzychodów.Size = new Size(177, 26);
            ListaPrzychodów.TabIndex = 33;
            ListaPrzychodów.Text = "Lista przychodów";
            // 
            // IncomeList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            IncomeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            IncomeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            IncomeList.ColumnHeadersHeight = 4;
            IncomeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            IncomeList.DefaultCellStyle = dataGridViewCellStyle3;
            IncomeList.GridColor = Color.FromArgb(231, 229, 255);
            IncomeList.Location = new Point(449, 162);
            IncomeList.Name = "IncomeList";
            IncomeList.RowHeadersVisible = false;
            IncomeList.RowHeadersWidth = 51;
            IncomeList.Size = new Size(862, 521);
            IncomeList.TabIndex = 32;
            IncomeList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            IncomeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            IncomeList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            IncomeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            IncomeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            IncomeList.ThemeStyle.BackColor = Color.White;
            IncomeList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            IncomeList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            IncomeList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            IncomeList.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            IncomeList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            IncomeList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            IncomeList.ThemeStyle.HeaderStyle.Height = 4;
            IncomeList.ThemeStyle.ReadOnly = false;
            IncomeList.ThemeStyle.RowsStyle.BackColor = Color.White;
            IncomeList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            IncomeList.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            IncomeList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            IncomeList.ThemeStyle.RowsStyle.Height = 29;
            IncomeList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            IncomeList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            IncomeList.CellContentClick += IncomeList_CellContentClick;
            // 
            // Usuń
            // 
            Usuń.Location = new Point(166, 575);
            Usuń.Name = "Usuń";
            Usuń.Size = new Size(129, 29);
            Usuń.TabIndex = 31;
            Usuń.Text = "Usuń";
            Usuń.UseVisualStyleBackColor = true;
            Usuń.Click += Usuń_Click;
            // 
            // Edytuj
            // 
            Edytuj.Location = new Point(233, 540);
            Edytuj.Name = "Edytuj";
            Edytuj.Size = new Size(124, 29);
            Edytuj.TabIndex = 30;
            Edytuj.Text = "Edytuj";
            Edytuj.UseVisualStyleBackColor = true;
            Edytuj.Click += Edytuj_Click;
            // 
            // Dodaj
            // 
            Dodaj.Location = new Point(105, 540);
            Dodaj.Name = "Dodaj";
            Dodaj.Size = new Size(122, 29);
            Dodaj.TabIndex = 29;
            Dodaj.Text = "Dodaj";
            Dodaj.UseVisualStyleBackColor = true;
            Dodaj.Click += Dodaj_Click;
            // 
            // IncValueBOX
            // 
            IncValueBOX.BackColor = Color.FromArgb(22, 26, 48);
            IncValueBOX.ForeColor = SystemColors.Menu;
            IncValueBOX.Location = new Point(106, 235);
            IncValueBOX.Name = "IncValueBOX";
            IncValueBOX.Size = new Size(252, 30);
            IncValueBOX.TabIndex = 28;
            // 
            // CatIncBOX
            // 
            CatIncBOX.BackColor = Color.FromArgb(22, 26, 48);
            CatIncBOX.ForeColor = SystemColors.Menu;
            CatIncBOX.Location = new Point(106, 319);
            CatIncBOX.Name = "CatIncBOX";
            CatIncBOX.Size = new Size(252, 30);
            CatIncBOX.TabIndex = 27;
            // 
            // DescIncBOX
            // 
            DescIncBOX.BackColor = Color.FromArgb(22, 26, 48);
            DescIncBOX.ForeColor = SystemColors.Menu;
            DescIncBOX.Location = new Point(105, 482);
            DescIncBOX.Name = "DescIncBOX";
            DescIncBOX.Size = new Size(252, 30);
            DescIncBOX.TabIndex = 25;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.ForeColor = Color.FromArgb(240, 236, 229);
            Opis.Location = new Point(106, 457);
            Opis.Name = "Opis";
            Opis.Size = new Size(48, 22);
            Opis.TabIndex = 24;
            Opis.Text = "Opis";
            // 
            // Data
            // 
            Data.AutoSize = true;
            Data.ForeColor = Color.FromArgb(240, 236, 229);
            Data.Location = new Point(106, 376);
            Data.Name = "Data";
            Data.Size = new Size(47, 22);
            Data.TabIndex = 23;
            Data.Text = "Data";
            // 
            // Kategoria
            // 
            Kategoria.AutoSize = true;
            Kategoria.ForeColor = Color.FromArgb(240, 236, 229);
            Kategoria.Location = new Point(105, 294);
            Kategoria.Name = "Kategoria";
            Kategoria.Size = new Size(88, 22);
            Kategoria.TabIndex = 22;
            Kategoria.Text = "Kategoria";
            // 
            // Wartość
            // 
            Wartość.AutoSize = true;
            Wartość.ForeColor = Color.FromArgb(240, 236, 229);
            Wartość.Location = new Point(105, 210);
            Wartość.Name = "Wartość";
            Wartość.Size = new Size(74, 22);
            Wartość.TabIndex = 21;
            Wartość.Text = "Wartość";
            // 
            // Przychód
            // 
            Przychód.AutoSize = true;
            Przychód.ForeColor = Color.FromArgb(240, 236, 229);
            Przychód.Location = new Point(106, 139);
            Przychód.Name = "Przychód";
            Przychód.Size = new Size(83, 22);
            Przychód.TabIndex = 20;
            Przychód.Text = "Przychód";
            // 
            // IncNameBOX
            // 
            IncNameBOX.BackColor = Color.FromArgb(22, 26, 48);
            IncNameBOX.ForeColor = SystemColors.Menu;
            IncNameBOX.Location = new Point(105, 162);
            IncNameBOX.Name = "IncNameBOX";
            IncNameBOX.Size = new Size(252, 30);
            IncNameBOX.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(182, 187, 196);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(ZarzadzanieFinansami);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(74, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1265, 65);
            panel2.TabIndex = 18;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(317, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(68, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // ZarzadzanieFinansami
            // 
            ZarzadzanieFinansami.AutoSize = true;
            ZarzadzanieFinansami.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ZarzadzanieFinansami.ForeColor = Color.FromArgb(240, 236, 229);
            ZarzadzanieFinansami.Location = new Point(31, 18);
            ZarzadzanieFinansami.Name = "ZarzadzanieFinansami";
            ZarzadzanieFinansami.Size = new Size(280, 34);
            ZarzadzanieFinansami.TabIndex = 4;
            ZarzadzanieFinansami.Text = "Zarzadzanie finansami";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 48, 77);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Dashboard);
            panel1.Controls.Add(Income);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 728);
            panel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 618);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Dashboard
            // 
            Dashboard.Image = (Image)resources.GetObject("Dashboard.Image");
            Dashboard.Location = new Point(0, 376);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(71, 62);
            Dashboard.SizeMode = PictureBoxSizeMode.Zoom;
            Dashboard.TabIndex = 3;
            Dashboard.TabStop = false;
            Dashboard.Click += Dashboard_Click;
            // 
            // Income
            // 
            Income.Image = (Image)resources.GetObject("Income.Image");
            Income.Location = new Point(0, 272);
            Income.Name = "Income";
            Income.Size = new Size(71, 62);
            Income.SizeMode = PictureBoxSizeMode.Zoom;
            Income.TabIndex = 5;
            Income.TabStop = false;
            Income.Click += Income_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DateTab
            // 
            DateTab.Checked = true;
            DateTab.CustomizableEdges = customizableEdges1;
            DateTab.FillColor = SystemColors.HighlightText;
            DateTab.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DateTab.Format = DateTimePickerFormat.Short;
            DateTab.Location = new Point(107, 401);
            DateTab.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTab.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTab.Name = "DateTab";
            DateTab.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DateTab.Size = new Size(250, 45);
            DateTab.TabIndex = 34;
            DateTab.Value = new DateTime(2023, 12, 17, 19, 50, 19, 566);
            // 
            // Dochod
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 48);
            ClientSize = new Size(1339, 728);
            Controls.Add(DateTab);
            Controls.Add(ListaPrzychodów);
            Controls.Add(IncomeList);
            Controls.Add(Usuń);
            Controls.Add(Edytuj);
            Controls.Add(Dodaj);
            Controls.Add(IncValueBOX);
            Controls.Add(CatIncBOX);
            Controls.Add(DescIncBOX);
            Controls.Add(Opis);
            Controls.Add(Data);
            Controls.Add(Kategoria);
            Controls.Add(Wartość);
            Controls.Add(Przychód);
            Controls.Add(IncNameBOX);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dochod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dochod";
            ((System.ComponentModel.ISupportInitialize)IncomeList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)Income).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ListaPrzychodów;
        private Guna.UI2.WinForms.Guna2DataGridView IncomeList;
        private Button Usuń;
        private Button Edytuj;
        private Button Dodaj;
        private TextBox IncValueBOX;
        private TextBox CatIncBOX;
        private TextBox DescIncBOX;
        private Label Opis;
        private Label Data;
        private Label Kategoria;
        private Label Wartość;
        private Label Przychód;
        private TextBox IncNameBOX;
        private Panel panel2;
        private PictureBox pictureBox6;
        private Label ZarzadzanieFinansami;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox Dashboard;
        private PictureBox Income;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTab;
    }
}