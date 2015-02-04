namespace SettlersCardTracker
{
    partial class PlayYearPlentyForm
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
            this.gbxResourcesGained = new System.Windows.Forms.GroupBox();
            this.txtResourcesGained = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxResourcesGained.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxResourcesGained
            // 
            this.gbxResourcesGained.Controls.Add(this.txtResourcesGained);
            this.gbxResourcesGained.Location = new System.Drawing.Point(46, 62);
            this.gbxResourcesGained.Name = "gbxResourcesGained";
            this.gbxResourcesGained.Size = new System.Drawing.Size(195, 91);
            this.gbxResourcesGained.TabIndex = 15;
            this.gbxResourcesGained.TabStop = false;
            this.gbxResourcesGained.Text = "What two resources did Player get? (Ex. O,T)";
            // 
            // txtResourcesGained
            // 
            this.txtResourcesGained.Location = new System.Drawing.Point(47, 43);
            this.txtResourcesGained.MaxLength = 3;
            this.txtResourcesGained.Name = "txtResourcesGained";
            this.txtResourcesGained.Size = new System.Drawing.Size(100, 20);
            this.txtResourcesGained.TabIndex = 0;
            this.txtResourcesGained.TextChanged += new System.EventHandler(this.txtResourcesGained_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(105, 185);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // PlayYearPlentyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxResourcesGained);
            this.Name = "PlayYearPlentyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlayYearPlenty";
            this.gbxResourcesGained.ResumeLayout(false);
            this.gbxResourcesGained.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxResourcesGained;
        private System.Windows.Forms.TextBox txtResourcesGained;
        private System.Windows.Forms.Button btnSubmit;
    }
}