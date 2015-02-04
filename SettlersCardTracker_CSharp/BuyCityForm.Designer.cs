namespace SettlersCardTracker
{
    partial class BuyCityForm
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
            this.btnBuyCitySubmit = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtNewType = new System.Windows.Forms.TextBox();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuyCitySubmit
            // 
            this.btnBuyCitySubmit.Location = new System.Drawing.Point(101, 194);
            this.btnBuyCitySubmit.Name = "btnBuyCitySubmit";
            this.btnBuyCitySubmit.Size = new System.Drawing.Size(75, 23);
            this.btnBuyCitySubmit.TabIndex = 2;
            this.btnBuyCitySubmit.Text = "Submit";
            this.btnBuyCitySubmit.UseVisualStyleBackColor = true;
            this.btnBuyCitySubmit.Click += new System.EventHandler(this.btnBuySettlementSubmit_Click);
            // 
            // lblInfo
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(25, 46);
            this.lblInstructions.Name = "lblInfo";
            this.lblInstructions.Size = new System.Drawing.Size(235, 26);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Enter resource values and corresponding types: \r\n(ex. 8,5,4 / W,T,S) (T = wheat)";
            // 
            // txtNewType
            // 
            this.txtNewType.Location = new System.Drawing.Point(147, 107);
            this.txtNewType.MaxLength = 5;
            this.txtNewType.Name = "txtNewType";
            this.txtNewType.Size = new System.Drawing.Size(100, 20);
            this.txtNewType.TabIndex = 1;
            this.txtNewType.TextChanged += new System.EventHandler(this.txtNewType_TextChanged);
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(28, 107);
            this.txtNewValue.MaxLength = 8;
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewValue.TabIndex = 0;
            this.txtNewValue.TextChanged += new System.EventHandler(this.txtNewValue_TextChanged);
            // 
            // BuyCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnBuyCitySubmit);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtNewType);
            this.Controls.Add(this.txtNewValue);
            this.Name = "BuyCityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuyCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuyCitySubmit;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtNewType;
        private System.Windows.Forms.TextBox txtNewValue;
    }
}