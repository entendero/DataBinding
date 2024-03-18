
namespace DemoDataBinding1
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
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            label3 = new Label();
            textBoxMail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            checkBoxCurs3 = new CheckBox();
            checkBoxCurs2 = new CheckBox();
            checkBoxCurs1 = new CheckBox();
            label9 = new Label();
            radioHorariTarda = new RadioButton();
            radioHorariMati = new RadioButton();
            buttonEsborrar = new Button();
            buttonAfegir = new Button();
            label8 = new Label();
            textBoxNom = new TextBox();
            grid = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxDataNaix = new TextBox();
            textBoxCognom = new TextBox();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(669, 523);
            tabControl1.TabIndex = 2;
            tabControl1.KeyDown += tabControl1_KeyDown;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(textBoxMail);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(checkBoxCurs3);
            tabPage3.Controls.Add(checkBoxCurs2);
            tabPage3.Controls.Add(checkBoxCurs1);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(radioHorariTarda);
            tabPage3.Controls.Add(radioHorariMati);
            tabPage3.Controls.Add(buttonEsborrar);
            tabPage3.Controls.Add(buttonAfegir);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(textBoxNom);
            tabPage3.Controls.Add(grid);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBoxDataNaix);
            tabPage3.Controls.Add(textBoxCognom);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(661, 490);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "grid";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 425);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 30;
            label3.Text = "Data Naixement";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(20, 388);
            textBoxMail.Margin = new Padding(3, 4, 3, 4);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(158, 27);
            textBoxMail.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(246, 221);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 28;
            label2.Text = "Cursos";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(393, 221);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 27;
            label1.Text = "Horari";
            // 
            // checkBoxCurs3
            // 
            checkBoxCurs3.AutoSize = true;
            checkBoxCurs3.Location = new Point(241, 352);
            checkBoxCurs3.Name = "checkBoxCurs3";
            checkBoxCurs3.Size = new Size(71, 24);
            checkBoxCurs3.TabIndex = 26;
            checkBoxCurs3.Text = "Curs 3";
            checkBoxCurs3.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurs2
            // 
            checkBoxCurs2.AutoSize = true;
            checkBoxCurs2.Location = new Point(241, 314);
            checkBoxCurs2.Name = "checkBoxCurs2";
            checkBoxCurs2.Size = new Size(71, 24);
            checkBoxCurs2.TabIndex = 25;
            checkBoxCurs2.Text = "Curs 2";
            checkBoxCurs2.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurs1
            // 
            checkBoxCurs1.AutoSize = true;
            checkBoxCurs1.Location = new Point(241, 274);
            checkBoxCurs1.Name = "checkBoxCurs1";
            checkBoxCurs1.Size = new Size(71, 24);
            checkBoxCurs1.TabIndex = 24;
            checkBoxCurs1.Text = "Curs 1";
            checkBoxCurs1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(44, 221);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 23;
            label9.Text = "Dades Alumne";
            // 
            // radioHorariTarda
            // 
            radioHorariTarda.AutoSize = true;
            radioHorariTarda.Location = new Point(364, 308);
            radioHorariTarda.Margin = new Padding(3, 4, 3, 4);
            radioHorariTarda.Name = "radioHorariTarda";
            radioHorariTarda.Size = new Size(103, 24);
            radioHorariTarda.TabIndex = 22;
            radioHorariTarda.TabStop = true;
            radioHorariTarda.Text = "Hora Tarda";
            radioHorariTarda.UseVisualStyleBackColor = true;
            // 
            // radioHorariMati
            // 
            radioHorariMati.AutoSize = true;
            radioHorariMati.Location = new Point(364, 274);
            radioHorariMati.Margin = new Padding(3, 4, 3, 4);
            radioHorariMati.Name = "radioHorariMati";
            radioHorariMati.Size = new Size(106, 24);
            radioHorariMati.TabIndex = 21;
            radioHorariMati.TabStop = true;
            radioHorariMati.Text = "Horari Matí";
            radioHorariMati.UseVisualStyleBackColor = true;
            // 
            // buttonEsborrar
            // 
            buttonEsborrar.Location = new Point(515, 351);
            buttonEsborrar.Margin = new Padding(3, 4, 3, 4);
            buttonEsborrar.Name = "buttonEsborrar";
            buttonEsborrar.Size = new Size(134, 31);
            buttonEsborrar.TabIndex = 4;
            buttonEsborrar.Text = "Esborrar (Ctrl+4)";
            buttonEsborrar.UseVisualStyleBackColor = true;
            buttonEsborrar.Click += buttonEsborrar_Click;
            // 
            // buttonAfegir
            // 
            buttonAfegir.Location = new Point(515, 312);
            buttonAfegir.Margin = new Padding(3, 4, 3, 4);
            buttonAfegir.Name = "buttonAfegir";
            buttonAfegir.Size = new Size(134, 31);
            buttonAfegir.TabIndex = 3;
            buttonAfegir.Text = "Afegir (Ctrl+3)";
            buttonAfegir.UseVisualStyleBackColor = true;
            buttonAfegir.Click += buttonAfegir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 4);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 17;
            label8.Text = "Alumnes";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(19, 268);
            textBoxNom.Margin = new Padding(3, 4, 3, 4);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(158, 27);
            textBoxNom.TabIndex = 0;
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(9, 28);
            grid.Margin = new Padding(3, 4, 3, 4);
            grid.Name = "grid";
            grid.RowHeadersWidth = 51;
            grid.RowTemplate.Height = 25;
            grid.Size = new Size(640, 189);
            grid.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 364);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 14;
            label5.Text = "eMail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 303);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 13;
            label6.Text = "Cognom";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 242);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 12;
            label7.Text = "Nom";
            // 
            // textBoxDataNaix
            // 
            textBoxDataNaix.Location = new Point(20, 449);
            textBoxDataNaix.Margin = new Padding(3, 4, 3, 4);
            textBoxDataNaix.Name = "textBoxDataNaix";
            textBoxDataNaix.Size = new Size(158, 27);
            textBoxDataNaix.TabIndex = 2;
            // 
            // textBoxCognom
            // 
            textBoxCognom.Location = new Point(18, 327);
            textBoxCognom.Margin = new Padding(3, 4, 3, 4);
            textBoxCognom.Name = "textBoxCognom";
            textBoxCognom.Size = new Size(158, 27);
            textBoxCognom.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 512);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }



        #endregion
        private TabControl tabControl1;
        private TabPage tabPage3;
        private Label label8;
        private TextBox textBoxNom;
        private DataGridView grid;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxDataNaix;
        private TextBox textBoxCognom;
        private Button buttonEsborrar;
        private Button buttonAfegir;
        private RadioButton radioHorariTarda;
        private RadioButton radioHorariMati;
        private Label label9;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxCurs3;
        private CheckBox checkBoxCurs2;
        private CheckBox checkBoxCurs1;
        private Label label3;
        private TextBox textBoxMail;
    }
}