namespace HR_Predare
{
    partial class frm_Cerere_Acte
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
            this.comboBox_angajat = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label_angajati = new System.Windows.Forms.Label();
            this.label_Act = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_angajat
            // 
            this.comboBox_angajat.FormattingEnabled = true;
            this.comboBox_angajat.Location = new System.Drawing.Point(144, 26);
            this.comboBox_angajat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_angajat.Name = "comboBox_angajat";
            this.comboBox_angajat.Size = new System.Drawing.Size(92, 21);
            this.comboBox_angajat.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 95);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(144, 154);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(92, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // label_angajati
            // 
            this.label_angajati.AutoSize = true;
            this.label_angajati.Location = new System.Drawing.Point(34, 32);
            this.label_angajati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_angajati.Name = "label_angajati";
            this.label_angajati.Size = new System.Drawing.Size(43, 13);
            this.label_angajati.TabIndex = 0;
            this.label_angajati.Text = "Angajat";
            // 
            // label_Act
            // 
            this.label_Act.AutoSize = true;
            this.label_Act.Location = new System.Drawing.Point(34, 98);
            this.label_Act.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Act.Name = "label_Act";
            this.label_Act.Size = new System.Drawing.Size(23, 13);
            this.label_Act.TabIndex = 4;
            this.label_Act.Text = "Act";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(34, 160);
            this.label_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(30, 13);
            this.label_data.TabIndex = 5;
            this.label_data.Text = "Data";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(27, 213);
            this.button_ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(79, 47);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(217, 213);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(81, 47);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // frm_Cerere_Acte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 271);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_Act);
            this.Controls.Add(this.label_angajati);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox_angajat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Cerere_Acte";
            this.Text = "Cerere_Acte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_angajat;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label_angajati;
        private System.Windows.Forms.Label label_Act;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
    }
}