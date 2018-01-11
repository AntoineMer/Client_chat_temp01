namespace Client_chat
{
    partial class DataBase
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
            this.dataGridDB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDB
            // 
            this.dataGridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDB.Location = new System.Drawing.Point(12, 240);
            this.dataGridDB.Name = "dataGridDB";
            this.dataGridDB.Size = new System.Drawing.Size(417, 218);
            this.dataGridDB.TabIndex = 0;
            this.dataGridDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDB_CellContentClick);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 470);
            this.Controls.Add(this.dataGridDB);
            this.Name = "DataBase";
            this.Text = "DataBase";
            this.Load += new System.EventHandler(this.DataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDB;
    }
}