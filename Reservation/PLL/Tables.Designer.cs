namespace Reservation.PLL
{
    partial class Tables
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.activeUser = new System.Windows.Forms.Label();
            this.bookBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.allTablesBtn = new System.Windows.Forms.Button();
            this.emptyTablesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(219, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(312, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tables";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 171);
            this.dataGridView1.TabIndex = 4;
            // 
            // activeUser
            // 
            this.activeUser.AutoSize = true;
            this.activeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.activeUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.activeUser.Location = new System.Drawing.Point(27, 22);
            this.activeUser.Name = "activeUser";
            this.activeUser.Size = new System.Drawing.Size(86, 20);
            this.activeUser.TabIndex = 5;
            this.activeUser.Text = "Username";
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(401, 378);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(92, 35);
            this.bookBtn.TabIndex = 6;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(303, 378);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(92, 35);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // allTablesBtn
            // 
            this.allTablesBtn.Location = new System.Drawing.Point(499, 378);
            this.allTablesBtn.Name = "allTablesBtn";
            this.allTablesBtn.Size = new System.Drawing.Size(92, 35);
            this.allTablesBtn.TabIndex = 8;
            this.allTablesBtn.Text = "All Tables";
            this.allTablesBtn.UseVisualStyleBackColor = true;
            this.allTablesBtn.Click += new System.EventHandler(this.allTablesBtn_Click);
            // 
            // emptyTablesBtn
            // 
            this.emptyTablesBtn.Location = new System.Drawing.Point(597, 378);
            this.emptyTablesBtn.Name = "emptyTablesBtn";
            this.emptyTablesBtn.Size = new System.Drawing.Size(120, 35);
            this.emptyTablesBtn.TabIndex = 9;
            this.emptyTablesBtn.Text = "Empty Tables";
            this.emptyTablesBtn.UseVisualStyleBackColor = true;
            this.emptyTablesBtn.Click += new System.EventHandler(this.emptyTablesBtn_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emptyTablesBtn);
            this.Controls.Add(this.allTablesBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.activeUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tables";
            this.Text = "Tables";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label activeUser;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button allTablesBtn;
        private System.Windows.Forms.Button emptyTablesBtn;
    }
}