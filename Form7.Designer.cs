
namespace TDMS
{
    partial class DeleteForm
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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phNumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.streetAdd1Label = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.invalidUserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search User to Unsbscribe";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(132, 118);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(368, 29);
            this.emailBox.TabIndex = 1;
            // 
            // phNumTextBox
            // 
            this.phNumTextBox.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phNumTextBox.Location = new System.Drawing.Point(132, 229);
            this.phNumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phNumTextBox.Name = "phNumTextBox";
            this.phNumTextBox.Size = new System.Drawing.Size(368, 29);
            this.phNumTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(103, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 2);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Search with unique registered email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search with unique Registered Phone number Without country code";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F);
            this.label7.Location = new System.Drawing.Point(405, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Only One Required";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.firstNameLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.firstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameLabel.Location = new System.Drawing.Point(77, 370);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(49, 19);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "label8";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.lastNameLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.lastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameLabel.Location = new System.Drawing.Point(164, 370);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(49, 19);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "label9";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.EmailLabel.ForeColor = System.Drawing.Color.Red;
            this.EmailLabel.Location = new System.Drawing.Point(253, 370);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(57, 19);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "label10";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.phoneLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.phoneLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneLabel.Location = new System.Drawing.Point(380, 370);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(57, 19);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "label11";
            // 
            // streetAdd1Label
            // 
            this.streetAdd1Label.AutoSize = true;
            this.streetAdd1Label.BackColor = System.Drawing.Color.Aquamarine;
            this.streetAdd1Label.Font = new System.Drawing.Font("Calibri", 12F);
            this.streetAdd1Label.ForeColor = System.Drawing.Color.Red;
            this.streetAdd1Label.Location = new System.Drawing.Point(485, 370);
            this.streetAdd1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.streetAdd1Label.Name = "streetAdd1Label";
            this.streetAdd1Label.Size = new System.Drawing.Size(57, 19);
            this.streetAdd1Label.TabIndex = 13;
            this.streetAdd1Label.Text = "label12";
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.Teal;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(214, 305);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(77, 33);
            this.search.TabIndex = 14;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.BackColor = System.Drawing.Color.Teal;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(380, 420);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(162, 30);
            this.delete.TabIndex = 15;
            this.delete.Text = "Unsubscribe User";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.unsbscribe_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.BackColor = System.Drawing.Color.Teal;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(131, 305);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(72, 33);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.cancel_Click);
            // 
            // invalidUserLabel
            // 
            this.invalidUserLabel.AutoSize = true;
            this.invalidUserLabel.BackColor = System.Drawing.Color.MistyRose;
            this.invalidUserLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.invalidUserLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidUserLabel.Location = new System.Drawing.Point(308, 314);
            this.invalidUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.invalidUserLabel.Name = "invalidUserLabel";
            this.invalidUserLabel.Size = new System.Drawing.Size(209, 17);
            this.invalidUserLabel.TabIndex = 17;
            this.invalidUserLabel.Text = "No user for given number or email";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 476);
            this.Controls.Add(this.invalidUserLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.streetAdd1Label);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phNumTextBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(642, 515);
            this.MinimumSize = new System.Drawing.Size(642, 515);
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unsbscribe Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phNumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label streetAdd1Label;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label invalidUserLabel;
    }
}