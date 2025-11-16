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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(245, 162);
            button1.Name = "button1";
            button1.Size = new Size(713, 277);
            button1.TabIndex = 0;
            button1.Text = "kutapoduncal";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmKitapOduncAl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 24);
            ClientSize = new Size(1179, 854);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKitapOduncAl";
            Text = "frmKitapOduncAl";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}