namespace Kutuphane.UI.Forms
{
    partial class frmKitapOduncAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapOduncAl));
            panel1 = new Panel();
            yenileBtn = new Button();
            kitapAdiTxt = new TextBox();
            xBtn = new Button();
            label1 = new Label();
            kitaplarDgw = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kitaplarDgw).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 255);
            panel1.Controls.Add(yenileBtn);
            panel1.Controls.Add(kitapAdiTxt);
            panel1.Controls.Add(xBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 40);
            panel1.TabIndex = 11;
            // 
            // yenileBtn
            // 
            yenileBtn.BackColor = Color.FromArgb(18, 18, 24);
            yenileBtn.FlatAppearance.BorderSize = 0;
            yenileBtn.FlatStyle = FlatStyle.Flat;
            yenileBtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            yenileBtn.ForeColor = SystemColors.ButtonHighlight;
            yenileBtn.Image = (Image)resources.GetObject("yenileBtn.Image");
            yenileBtn.ImageAlign = ContentAlignment.MiddleRight;
            yenileBtn.Location = new Point(700, 8);
            yenileBtn.Name = "yenileBtn";
            yenileBtn.Size = new Size(83, 25);
            yenileBtn.TabIndex = 4;
            yenileBtn.Text = "Yenile";
            yenileBtn.TextAlign = ContentAlignment.MiddleLeft;
            yenileBtn.UseVisualStyleBackColor = false;
            // 
            // kitapAdiTxt
            // 
            kitapAdiTxt.Location = new Point(421, 9);
            kitapAdiTxt.Name = "kitapAdiTxt";
            kitapAdiTxt.Size = new Size(261, 25);
            kitapAdiTxt.TabIndex = 3;
            kitapAdiTxt.TextChanged += kitapAdiTxt_TextChanged;
            // 
            // xBtn
            // 
            xBtn.BackColor = Color.FromArgb(18, 18, 24);
            xBtn.FlatAppearance.BorderSize = 0;
            xBtn.FlatStyle = FlatStyle.Flat;
            xBtn.ForeColor = Color.FromArgb(0, 122, 255);
            xBtn.Location = new Point(1351, 7);
            xBtn.Name = "xBtn";
            xBtn.Size = new Size(38, 33);
            xBtn.TabIndex = 2;
            xBtn.Text = "X";
            xBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(332, 10);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 1;
            label1.Text = "Kitap İsmi";
            // 
            // kitaplarDgw
            // 
            kitaplarDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kitaplarDgw.Location = new Point(32, 73);
            kitaplarDgw.Name = "kitaplarDgw";
            kitaplarDgw.RowHeadersWidth = 45;
            kitaplarDgw.Size = new Size(1115, 262);
            kitaplarDgw.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 255);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(32, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 40);
            panel2.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(18, 18, 24);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0, 122, 255);
            button2.Location = new Point(1351, 7);
            button2.Name = "button2";
            button2.Size = new Size(38, 33);
            button2.TabIndex = 2;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 5;
            label2.Text = "Ödünç Al";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(104, 416);
            label3.Name = "label3";
            label3.Size = new Size(51, 22);
            label3.TabIndex = 5;
            label3.Text = "Kitap";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(32, 459);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 13;
            label4.Text = "ISBN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(32, 496);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 14;
            label5.Text = "Kitap Adı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(32, 534);
            label6.Name = "label6";
            label6.Size = new Size(61, 22);
            label6.TabIndex = 15;
            label6.Text = "Yazar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(32, 576);
            label7.Name = "label7";
            label7.Size = new Size(83, 22);
            label7.TabIndex = 16;
            label7.Text = "Yayınevi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(36, 621);
            label8.Name = "label8";
            label8.Size = new Size(64, 22);
            label8.TabIndex = 17;
            label8.Text = "Basım:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(732, 416);
            label9.Name = "label9";
            label9.Size = new Size(73, 22);
            label9.TabIndex = 18;
            label9.Text = "Öğrenci";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(732, 459);
            label10.Name = "label10";
            label10.Size = new Size(78, 22);
            label10.TabIndex = 19;
            label10.Text = "Üye Adı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(734, 509);
            label11.Name = "label11";
            label11.Size = new Size(107, 22);
            label11.TabIndex = 20;
            label11.Text = "Üye Soyadı:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(737, 561);
            label12.Name = "label12";
            label12.Size = new Size(55, 22);
            label12.TabIndex = 21;
            label12.Text = "GSM:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(739, 610);
            label13.Name = "label13";
            label13.Size = new Size(66, 22);
            label13.TabIndex = 22;
            label13.Text = "Eposta";
            // 
            // button1
            // 
            button1.Location = new Point(177, 760);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 23;
            button1.Text = "Ödünç Al";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmKitapOduncAl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 24);
            ClientSize = new Size(1179, 854);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(kitaplarDgw);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKitapOduncAl";
            Text = "frmKitapOduncAl";
            Load += frmKitapOduncAl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kitaplarDgw).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button yenileBtn;
        private TextBox kitapAdiTxt;
        private Button xBtn;
        private Label label1;
        private DataGridView kitaplarDgw;
        private Panel panel2;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button1;
    }
}