namespace HR_Predare
{
    partial class frm_Angajati
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(36, 355);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(97, 30);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "&Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(174, 355);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(85, 30);
            this.button_edit.TabIndex = 2;
            this.button_edit.Text = "&Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(308, 355);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(95, 30);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "&Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(544, 355);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(91, 30);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "E&xit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // frm_Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 440);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Angajati";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista Angajati";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_exit;
    }
}