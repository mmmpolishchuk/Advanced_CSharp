namespace Homework_10.LINQ_to_SQL._27._11
{
    partial class Directors_Form
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
            this.btnAddDirector = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbBirthDate = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.dgvDirectors = new System.Windows.Forms.DataGridView();
            this.btnDelDirector = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDirector
            // 
            this.btnAddDirector.Location = new System.Drawing.Point(859, 733);
            this.btnAddDirector.Name = "btnAddDirector";
            this.btnAddDirector.Size = new System.Drawing.Size(332, 82);
            this.btnAddDirector.TabIndex = 0;
            this.btnAddDirector.Text = "Add director";
            this.btnAddDirector.UseVisualStyleBackColor = true;
            this.btnAddDirector.Click += new System.EventHandler(this.btnAddDirector_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(823, 444);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(411, 38);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(823, 542);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(411, 38);
            this.tbLastName.TabIndex = 2;
            // 
            // tbBirthDate
            // 
            this.tbBirthDate.Location = new System.Drawing.Point(823, 645);
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.Size = new System.Drawing.Size(411, 38);
            this.tbBirthDate.TabIndex = 3;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(646, 450);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(160, 32);
            this.lbFirstName.TabIndex = 4;
            this.lbFirstName.Text = "First Name:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(647, 545);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(159, 32);
            this.lbLastName.TabIndex = 5;
            this.lbLastName.Text = "Last Name:";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(657, 648);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(149, 32);
            this.lbBirthDate.TabIndex = 6;
            this.lbBirthDate.Text = "Birth Date:";
            // 
            // dgvDirectors
            // 
            this.dgvDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectors.Location = new System.Drawing.Point(146, 50);
            this.dgvDirectors.Name = "dgvDirectors";
            this.dgvDirectors.RowHeadersWidth = 102;
            this.dgvDirectors.Size = new System.Drawing.Size(1734, 298);
            this.dgvDirectors.TabIndex = 7;
            // 
            // btnDelDirector
            // 
            this.btnDelDirector.Location = new System.Drawing.Point(823, 855);
            this.btnDelDirector.Name = "btnDelDirector";
            this.btnDelDirector.Size = new System.Drawing.Size(411, 82);
            this.btnDelDirector.TabIndex = 8;
            this.btnDelDirector.Text = "Delete last directors";
            this.btnDelDirector.UseVisualStyleBackColor = true;
            this.btnDelDirector.Click += new System.EventHandler(this.button1_Click);
            // 
            // Directors_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1995, 1058);
            this.Controls.Add(this.btnDelDirector);
            this.Controls.Add(this.dgvDirectors);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbBirthDate);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.btnAddDirector);
            this.Name = "Directors_Form";
            this.Text = "Directors_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDirector;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbBirthDate;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.DataGridView dgvDirectors;
        private System.Windows.Forms.Button btnDelDirector;
    }
}