namespace HR_Predare
{
    partial class frm_Acte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 367);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 61);
            this.panel1.TabIndex = 5;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(822, 13);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(77, 29);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "E&xit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click_1);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(147, 13);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(63, 29);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "&Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(85, 13);
            this.button_edit.Margin = new System.Windows.Forms.Padding(2);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(58, 29);
            this.button_edit.TabIndex = 2;
            this.button_edit.Text = "&Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(24, 13);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(56, 29);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "&Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 367);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1009, 367);
            this.dataGridView.TabIndex = 0;
            // 
            // frm_Acte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Acte";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista acte";
            this.Load += new System.EventHandler(this.frm_Acte_Load);
            this.Resize += new System.EventHandler(this.frm_Acte_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}