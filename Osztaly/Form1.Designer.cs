namespace Osztaly
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
            DGV = new DataGridView();
            oktazon = new DataGridViewTextBoxColumn();
            nev = new DataGridViewTextBoxColumn();
            osztondij = new DataGridViewTextBoxColumn();
            kezddatum = new DataGridViewTextBoxColumn();
            befdatum = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tb_oktazon = new TextBox();
            label2 = new Label();
            tb_nev = new TextBox();
            label3 = new Label();
            tb_oszt = new TextBox();
            label4 = new Label();
            dtp_kezdes = new DateTimePicker();
            btn_ment = new Button();
            tb_nevkeres = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { oktazon, nev, osztondij, kezddatum, befdatum });
            DGV.Location = new Point(21, 41);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(535, 351);
            DGV.TabIndex = 0;
            // 
            // oktazon
            // 
            oktazon.HeaderText = "Oktatási azonosító";
            oktazon.Name = "oktazon";
            oktazon.ReadOnly = true;
            // 
            // nev
            // 
            nev.HeaderText = "Név";
            nev.Name = "nev";
            nev.ReadOnly = true;
            // 
            // osztondij
            // 
            osztondij.HeaderText = "Ösztöndíj";
            osztondij.Name = "osztondij";
            osztondij.ReadOnly = true;
            // 
            // kezddatum
            // 
            kezddatum.HeaderText = "Kezdés Dátuma";
            kezddatum.Name = "kezddatum";
            kezddatum.ReadOnly = true;
            // 
            // befdatum
            // 
            befdatum.HeaderText = "Befejezés Dátuma";
            befdatum.Name = "befdatum";
            befdatum.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 65);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Oktatási azonosító";
            // 
            // tb_oktazon
            // 
            tb_oktazon.Location = new Point(681, 62);
            tb_oktazon.Name = "tb_oktazon";
            tb_oktazon.Size = new Size(100, 23);
            tb_oktazon.TabIndex = 2;
            tb_oktazon.TextChanged += tb_oktazon_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 104);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Név";
            // 
            // tb_nev
            // 
            tb_nev.Location = new Point(605, 101);
            tb_nev.Name = "tb_nev";
            tb_nev.Size = new Size(176, 23);
            tb_nev.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 144);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Ösztöndíj";
            label3.Click += label3_Click;
            // 
            // tb_oszt
            // 
            tb_oszt.Location = new Point(634, 141);
            tb_oszt.Name = "tb_oszt";
            tb_oszt.Size = new Size(147, 23);
            tb_oszt.TabIndex = 2;
            tb_oszt.TextChanged += tb_oszt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 181);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 1;
            label4.Text = "Kezdés ideje";
            label4.Click += label3_Click;
            // 
            // dtp_kezdes
            // 
            dtp_kezdes.CustomFormat = "yyyy-MM-dd";
            dtp_kezdes.Format = DateTimePickerFormat.Custom;
            dtp_kezdes.Location = new Point(644, 175);
            dtp_kezdes.Name = "dtp_kezdes";
            dtp_kezdes.Size = new Size(137, 23);
            dtp_kezdes.TabIndex = 3;
            // 
            // btn_ment
            // 
            btn_ment.Location = new Point(641, 233);
            btn_ment.Name = "btn_ment";
            btn_ment.Size = new Size(75, 23);
            btn_ment.TabIndex = 4;
            btn_ment.Text = "Mentés";
            btn_ment.UseVisualStyleBackColor = true;
            btn_ment.Click += btn_ment_Click;
            // 
            // tb_nevkeres
            // 
            tb_nevkeres.Location = new Point(159, 12);
            tb_nevkeres.Name = "tb_nevkeres";
            tb_nevkeres.Size = new Size(100, 23);
            tb_nevkeres.TabIndex = 5;
            tb_nevkeres.TextChanged += tb_nevkeres_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_nevkeres);
            Controls.Add(btn_ment);
            Controls.Add(dtp_kezdes);
            Controls.Add(tb_oszt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_nev);
            Controls.Add(label2);
            Controls.Add(tb_oktazon);
            Controls.Add(label1);
            Controls.Add(DGV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private DataGridViewTextBoxColumn oktazon;
        private DataGridViewTextBoxColumn nev;
        private DataGridViewTextBoxColumn osztondij;
        private DataGridViewTextBoxColumn kezddatum;
        private DataGridViewTextBoxColumn befdatum;
        private Label label1;
        private TextBox tb_oktazon;
        private Label label2;
        private TextBox tb_nev;
        private Label label3;
        private TextBox tb_oszt;
        private Label label4;
        private DateTimePicker dtp_kezdes;
        private Button btn_ment;
        private TextBox tb_nevkeres;
    }
}
