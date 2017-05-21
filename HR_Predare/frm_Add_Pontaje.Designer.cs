namespace HR_Predare
{
    partial class frm_Add_Pontaje
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
            this.comboBox_nume = new System.Windows.Forms.ComboBox();
            this.label_nume = new System.Windows.Forms.Label();
            this.button_pontaj = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_nume
            // 
            this.comboBox_nume.FormattingEnabled = true;
            this.comboBox_nume.Location = new System.Drawing.Point(114, 23);
            this.comboBox_nume.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_nume.Name = "comboBox_nume";
            this.comboBox_nume.Size = new System.Drawing.Size(262, 21);
            this.comboBox_nume.TabIndex = 0;
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.Location = new System.Drawing.Point(40, 25);
            this.label_nume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(35, 13);
            this.label_nume.TabIndex = 2;
            this.label_nume.Text = "Nume";
            // 
            // button_pontaj
            // 
            this.button_pontaj.Location = new System.Drawing.Point(11, 80);
            this.button_pontaj.Margin = new System.Windows.Forms.Padding(2);
            this.button_pontaj.Name = "button_pontaj";
            this.button_pontaj.Size = new System.Drawing.Size(72, 28);
            this.button_pontaj.TabIndex = 1;
            this.button_pontaj.Text = "Pontaj";
            this.button_pontaj.UseVisualStyleBackColor = true;
            this.button_pontaj.Click += new System.EventHandler(this.button_pontaj_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(325, 80);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(80, 28);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // frm_Add_Pontaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 144);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_pontaj);
            this.Controls.Add(this.label_nume);
            this.Controls.Add(this.comboBox_nume);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Add_Pontaje";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adaugare Pontaje";
            this.Load += new System.EventHandler(this.frm_Add_Pontaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_nume;
        private System.Windows.Forms.Label label_nume;
        private System.Windows.Forms.Button button_pontaj;
        private System.Windows.Forms.Button button_exit;
    }
}