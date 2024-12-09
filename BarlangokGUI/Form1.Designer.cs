namespace BarlangokGUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bt_barlang_keres = new Button();
            bt_mentes = new Button();
            tx_azon = new TextBox();
            tx_hossz = new TextBox();
            tx_mely = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Azonosító:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 68);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Barlang neve:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 111);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Hosszúság:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 159);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Mélység:";
            // 
            // bt_barlang_keres
            // 
            bt_barlang_keres.Location = new Point(258, 26);
            bt_barlang_keres.Name = "bt_barlang_keres";
            bt_barlang_keres.Size = new Size(125, 33);
            bt_barlang_keres.TabIndex = 4;
            bt_barlang_keres.Text = "Barlang keresése";
            bt_barlang_keres.UseVisualStyleBackColor = true;
            bt_barlang_keres.Click += bt_barlang_keres_Click;
            // 
            // bt_mentes
            // 
            bt_mentes.Enabled = false;
            bt_mentes.Location = new Point(258, 121);
            bt_mentes.Name = "bt_mentes";
            bt_mentes.Size = new Size(125, 33);
            bt_mentes.TabIndex = 5;
            bt_mentes.Text = "Adatok mentése";
            bt_mentes.UseVisualStyleBackColor = true;
            // 
            // tx_azon
            // 
            tx_azon.Location = new Point(91, 23);
            tx_azon.Name = "tx_azon";
            tx_azon.Size = new Size(100, 23);
            tx_azon.TabIndex = 6;
            // 
            // tx_hossz
            // 
            tx_hossz.Location = new Point(94, 108);
            tx_hossz.Name = "tx_hossz";
            tx_hossz.Size = new Size(100, 23);
            tx_hossz.TabIndex = 7;
            // 
            // tx_mely
            // 
            tx_mely.Location = new Point(94, 151);
            tx_mely.Name = "tx_mely";
            tx_mely.Size = new Size(100, 23);
            tx_mely.TabIndex = 8;
            tx_mely.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 195);
            Controls.Add(tx_mely);
            Controls.Add(tx_hossz);
            Controls.Add(tx_azon);
            Controls.Add(bt_mentes);
            Controls.Add(bt_barlang_keres);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barlangok";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_barlang_keres;
        private Button bt_mentes;
        private TextBox tx_azon;
        private TextBox tx_hossz;
        private TextBox tx_mely;
    }
}
