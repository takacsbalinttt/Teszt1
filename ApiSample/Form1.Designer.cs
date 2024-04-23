namespace inprogress_winforms_app
{
    partial class Form1
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
            this.button_mentes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_mennyiseg = new System.Windows.Forms.TextBox();
            this.textBox_kereses = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_megse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_mentes
            // 
            this.button_mentes.Location = new System.Drawing.Point(436, 231);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(91, 80);
            this.button_mentes.TabIndex = 1;
            this.button_mentes.Text = "Kész";
            this.button_mentes.UseVisualStyleBackColor = true;
            this.button_mentes.Click += new System.EventHandler(this.button_mentes_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(22, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 404);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox_mennyiseg
            // 
            this.textBox_mennyiseg.Location = new System.Drawing.Point(329, 111);
            this.textBox_mennyiseg.Name = "textBox_mennyiseg";
            this.textBox_mennyiseg.Size = new System.Drawing.Size(198, 22);
            this.textBox_mennyiseg.TabIndex = 4;
            // 
            // textBox_kereses
            // 
            this.textBox_kereses.Location = new System.Drawing.Point(22, 27);
            this.textBox_kereses.Name = "textBox_kereses";
            this.textBox_kereses.Size = new System.Drawing.Size(272, 22);
            this.textBox_kereses.TabIndex = 5;
            this.textBox_kereses.TextChanged += new System.EventHandler(this.textBox_kereses_TextChanged);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(436, 161);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(60, 50);
            this.button_plus.TabIndex = 6;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(359, 161);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(60, 50);
            this.button_minus.TabIndex = 7;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_megse
            // 
            this.button_megse.Location = new System.Drawing.Point(328, 231);
            this.button_megse.Name = "button_megse";
            this.button_megse.Size = new System.Drawing.Size(91, 80);
            this.button_megse.TabIndex = 8;
            this.button_megse.Text = "Mégse";
            this.button_megse.UseVisualStyleBackColor = true;
            this.button_megse.Click += new System.EventHandler(this.button_megse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 491);
            this.Controls.Add(this.button_megse);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.textBox_kereses);
            this.Controls.Add(this.textBox_mennyiseg);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_mentes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_mennyiseg;
        private System.Windows.Forms.TextBox textBox_kereses;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_megse;
    }
}