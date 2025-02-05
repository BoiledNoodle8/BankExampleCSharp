namespace BankApp
{
    partial class Withdraw
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
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdrawl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(862, 12);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(912, 48);
            this.cmbAccounts.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(1263, 458);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(237, 38);
            this.txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1210, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Withdraw Ammount";
            // 
            // btnWithdrawl
            // 
            this.btnWithdrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawl.Location = new System.Drawing.Point(1263, 515);
            this.btnWithdrawl.Name = "btnWithdrawl";
            this.btnWithdrawl.Size = new System.Drawing.Size(237, 62);
            this.btnWithdrawl.TabIndex = 3;
            this.btnWithdrawl.Text = "Submit";
            this.btnWithdrawl.UseVisualStyleBackColor = true;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankApp.Properties.Resources.Gary_Cash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1786, 1161);
            this.Controls.Add(this.btnWithdrawl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWithdrawl;
    }
}