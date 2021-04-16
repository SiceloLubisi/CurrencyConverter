
namespace CurrencyConverter
{
    partial class frmCurrencyConverter
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
            this.components = new System.ComponentModel.Container();
            this.lblEnterAount = new System.Windows.Forms.Label();
            this.lblConvertFrom = new System.Windows.Forms.Label();
            this.lblConvertTo = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblConvertedAmount = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterAount
            // 
            this.lblEnterAount.AutoSize = true;
            this.lblEnterAount.Location = new System.Drawing.Point(76, 79);
            this.lblEnterAount.Name = "lblEnterAount";
            this.lblEnterAount.Size = new System.Drawing.Size(71, 13);
            this.lblEnterAount.TabIndex = 0;
            this.lblEnterAount.Text = "Enter Amount";
            // 
            // lblConvertFrom
            // 
            this.lblConvertFrom.AutoSize = true;
            this.lblConvertFrom.Location = new System.Drawing.Point(76, 121);
            this.lblConvertFrom.Name = "lblConvertFrom";
            this.lblConvertFrom.Size = new System.Drawing.Size(70, 13);
            this.lblConvertFrom.TabIndex = 1;
            this.lblConvertFrom.Text = "Convert From";
            // 
            // lblConvertTo
            // 
            this.lblConvertTo.AutoSize = true;
            this.lblConvertTo.Location = new System.Drawing.Point(76, 166);
            this.lblConvertTo.Name = "lblConvertTo";
            this.lblConvertTo.Size = new System.Drawing.Size(60, 13);
            this.lblConvertTo.TabIndex = 2;
            this.lblConvertTo.Text = "Convert To";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(187, 76);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(137, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Items.AddRange(new object[] {
            "South African Rand",
            "United States Dollar",
            "Euro",
            "Pula"});
            this.cmbFrom.Location = new System.Drawing.Point(187, 118);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(137, 21);
            this.cmbFrom.TabIndex = 4;
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Items.AddRange(new object[] {
            "South African Rand",
            "United States Dollar",
            "Euro",
            "Pula"});
            this.cmbTo.Location = new System.Drawing.Point(187, 163);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(137, 21);
            this.cmbTo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConvertedAmount
            // 
            this.lblConvertedAmount.AutoSize = true;
            this.lblConvertedAmount.Location = new System.Drawing.Point(141, 226);
            this.lblConvertedAmount.Name = "lblConvertedAmount";
            this.lblConvertedAmount.Size = new System.Drawing.Size(98, 13);
            this.lblConvertedAmount.TabIndex = 7;
            this.lblConvertedAmount.Text = "Converted Amount:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 327);
            this.Controls.Add(this.lblConvertedAmount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblConvertTo);
            this.Controls.Add(this.lblConvertFrom);
            this.Controls.Add(this.lblEnterAount);
            this.Name = "frmCurrencyConverter";
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterAount;
        private System.Windows.Forms.Label lblConvertFrom;
        private System.Windows.Forms.Label lblConvertTo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblConvertedAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

