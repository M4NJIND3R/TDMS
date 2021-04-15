
namespace TDMS
{
    partial class DatabaseForm
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
            this.databaseViewlabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAdd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAdd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.firstname,
            this.lastname,
            this.plan,
            this.countrcode,
            this.phoneNumber,
            this.streetAdd1,
            this.streetAdd2,
            this.city,
            this.province});
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseViewlabel
            // 
            this.databaseViewlabel.AutoSize = true;
            this.databaseViewlabel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.databaseViewlabel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseViewlabel.Location = new System.Drawing.Point(235, 9);
            this.databaseViewlabel.Name = "databaseViewlabel";
            this.databaseViewlabel.Size = new System.Drawing.Size(367, 51);
            this.databaseViewlabel.TabIndex = 1;
            this.databaseViewlabel.Text = "Customer Database";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Teal;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(696, 511);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 43);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Home";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.Home_click);
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            this.firstname.Width = 125;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            this.lastname.Width = 125;
            // 
            // plan
            // 
            this.plan.HeaderText = "Selected Plan";
            this.plan.MinimumWidth = 6;
            this.plan.Name = "plan";
            this.plan.Width = 125;
            // 
            // countrcode
            // 
            this.countrcode.HeaderText = "Country Code";
            this.countrcode.MinimumWidth = 6;
            this.countrcode.Name = "countrcode";
            this.countrcode.Width = 125;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Width = 125;
            // 
            // streetAdd1
            // 
            this.streetAdd1.HeaderText = "Street 1";
            this.streetAdd1.MinimumWidth = 6;
            this.streetAdd1.Name = "streetAdd1";
            this.streetAdd1.Width = 125;
            // 
            // streetAdd2
            // 
            this.streetAdd2.HeaderText = "Street 2";
            this.streetAdd2.MinimumWidth = 6;
            this.streetAdd2.Name = "streetAdd2";
            this.streetAdd2.Width = 125;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.Width = 125;
            // 
            // province
            // 
            this.province.HeaderText = "Province";
            this.province.MinimumWidth = 6;
            this.province.Name = "province";
            this.province.Width = 125;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 576);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.databaseViewlabel);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(850, 623);
            this.MinimumSize = new System.Drawing.Size(850, 623);
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database View";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label databaseViewlabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAdd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAdd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
    }
}