namespace SettlersCardTracker
{

    partial class PlayMonopolyForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtResourceMonopolized = new System.Windows.Forms.TextBox();
            this.gbxResourceMonopolized = new System.Windows.Forms.GroupBox();
            this.gbxResourceMonopolized.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(104, 180);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtResourceMonopolized
            // 
            this.txtResourceMonopolized.Location = new System.Drawing.Point(62, 31);
            this.txtResourceMonopolized.MaxLength = 1;
            this.txtResourceMonopolized.Name = "txtResourceMonopolized";
            this.txtResourceMonopolized.Size = new System.Drawing.Size(75, 20);
            this.txtResourceMonopolized.TabIndex = 0;
            this.txtResourceMonopolized.TextChanged += new System.EventHandler(this.txtResourceMonopolized_TextChanged);
            // 
            // gbxResourceMonopolized
            // 
            this.gbxResourceMonopolized.Controls.Add(this.txtResourceMonopolized);
            this.gbxResourceMonopolized.Location = new System.Drawing.Point(42, 74);
            this.gbxResourceMonopolized.Name = "gbxResourceMonopolized";
            this.gbxResourceMonopolized.Size = new System.Drawing.Size(203, 68);
            this.gbxResourceMonopolized.TabIndex = 15;
            this.gbxResourceMonopolized.TabStop = false;
            this.gbxResourceMonopolized.Text = "What resource did Player monopolize?";
            // 
            // PlayMonopolyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gbxResourceMonopolized);
            this.Controls.Add(this.btnSubmit);
            this.Name = "PlayMonopolyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlayMonopoly";
            this.gbxResourceMonopolized.ResumeLayout(false);
            this.gbxResourceMonopolized.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtResourceMonopolized;
        private System.Windows.Forms.GroupBox gbxResourceMonopolized;
    }
}