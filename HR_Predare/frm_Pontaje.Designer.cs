namespace HR_Predare
{
    partial class frm_Pontaje
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
            this.dateTime_dateInPontaj = new System.Windows.Forms.DateTimePicker();
            this.button_add = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime_dateInPontaj
            // 
            this.dateTime_dateInPontaj.Location = new System.Drawing.Point(36, 258);
            this.dateTime_dateInPontaj.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_dateInPontaj.Name = "dateTime_dateInPontaj";
            this.dateTime_dateInPontaj.Size = new System.Drawing.Size(210, 20);
            this.dateTime_dateInPontaj.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(36, 323);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(88, 43);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "&Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(433, 323);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(84, 43);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 217);
            this.dataGridView1.TabIndex = 4;
            // 
            // frm_Pontaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 386);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dateTime_dateInPontaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Pontaje";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pontaj";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime_dateInPontaj;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}