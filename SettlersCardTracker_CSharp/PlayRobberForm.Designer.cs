namespace SettlersCardTracker
{
    partial class PlayRobberForm
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
            this.gbxPlayerRobbed = new System.Windows.Forms.GroupBox();
            this.rdoPlayer4 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer3 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer2 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer1 = new System.Windows.Forms.RadioButton();
            this.txtResourceRobbed = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxResourceRobbed = new System.Windows.Forms.GroupBox();
            this.gbxRobberLocation = new System.Windows.Forms.GroupBox();
            this.txtNewRobberLocation = new System.Windows.Forms.TextBox();
            this.gbxPlayerRobbed.SuspendLayout();
            this.gbxResourceRobbed.SuspendLayout();
            this.gbxRobberLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPlayerRobbed
            // 
            this.gbxPlayerRobbed.Controls.Add(this.rdoPlayer4);
            this.gbxPlayerRobbed.Controls.Add(this.rdoPlayer3);
            this.gbxPlayerRobbed.Controls.Add(this.rdoPlayer2);
            this.gbxPlayerRobbed.Controls.Add(this.rdoPlayer1);
            this.gbxPlayerRobbed.Location = new System.Drawing.Point(45, 85);
            this.gbxPlayerRobbed.Name = "gbxPlayerRobbed";
            this.gbxPlayerRobbed.Size = new System.Drawing.Size(195, 48);
            this.gbxPlayerRobbed.TabIndex = 13;
            this.gbxPlayerRobbed.TabStop = false;
            this.gbxPlayerRobbed.Text = "Which Player was robbed?";
            // 
            // rdoPlayer4
            // 
            this.rdoPlayer4.AutoSize = true;
            this.rdoPlayer4.Location = new System.Drawing.Point(150, 19);
            this.rdoPlayer4.Name = "rdoPlayer4";
            this.rdoPlayer4.Size = new System.Drawing.Size(31, 17);
            this.rdoPlayer4.TabIndex = 3;
            this.rdoPlayer4.Text = "4";
            this.rdoPlayer4.UseVisualStyleBackColor = true;
            this.rdoPlayer4.CheckedChanged += new System.EventHandler(this.rdoPlayer4_CheckedChanged);
            // 
            // rdoPlayer3
            // 
            this.rdoPlayer3.AutoSize = true;
            this.rdoPlayer3.Location = new System.Drawing.Point(105, 19);
            this.rdoPlayer3.Name = "rdoPlayer3";
            this.rdoPlayer3.Size = new System.Drawing.Size(31, 17);
            this.rdoPlayer3.TabIndex = 2;
            this.rdoPlayer3.Text = "3";
            this.rdoPlayer3.UseVisualStyleBackColor = true;
            this.rdoPlayer3.CheckedChanged += new System.EventHandler(this.rdoPlayer3_CheckedChanged);
            // 
            // rdoPlayer2
            // 
            this.rdoPlayer2.AutoSize = true;
            this.rdoPlayer2.Location = new System.Drawing.Point(59, 19);
            this.rdoPlayer2.Name = "rdoPlayer2";
            this.rdoPlayer2.Size = new System.Drawing.Size(31, 17);
            this.rdoPlayer2.TabIndex = 1;
            this.rdoPlayer2.Text = "2";
            this.rdoPlayer2.UseVisualStyleBackColor = true;
            this.rdoPlayer2.CheckedChanged += new System.EventHandler(this.rdoPlayer2_CheckedChanged);
            // 
            // rdoPlayer1
            // 
            this.rdoPlayer1.AutoSize = true;
            this.rdoPlayer1.Location = new System.Drawing.Point(13, 19);
            this.rdoPlayer1.Name = "rdoPlayer1";
            this.rdoPlayer1.Size = new System.Drawing.Size(31, 17);
            this.rdoPlayer1.TabIndex = 0;
            this.rdoPlayer1.Text = "1";
            this.rdoPlayer1.UseVisualStyleBackColor = true;
            this.rdoPlayer1.CheckedChanged += new System.EventHandler(this.rdoPlayer1_CheckedChanged);
            // 
            // txtResourceRobbed
            // 
            this.txtResourceRobbed.Location = new System.Drawing.Point(59, 24);
            this.txtResourceRobbed.MaxLength = 1;
            this.txtResourceRobbed.Name = "txtResourceRobbed";
            this.txtResourceRobbed.Size = new System.Drawing.Size(75, 20);
            this.txtResourceRobbed.TabIndex = 0;
            this.txtResourceRobbed.TextChanged += new System.EventHandler(this.txtResourceRobbed_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(104, 216);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxResourceRobbed
            // 
            this.gbxResourceRobbed.Controls.Add(this.txtResourceRobbed);
            this.gbxResourceRobbed.Location = new System.Drawing.Point(45, 146);
            this.gbxResourceRobbed.Name = "gbxResourceRobbed";
            this.gbxResourceRobbed.Size = new System.Drawing.Size(195, 55);
            this.gbxResourceRobbed.TabIndex = 14;
            this.gbxResourceRobbed.TabStop = false;
            this.gbxResourceRobbed.Text = "Of what resource (if known)?";
            // 
            // gbxRobberLocation
            // 
            this.gbxRobberLocation.Controls.Add(this.txtNewRobberLocation);
            this.gbxRobberLocation.Location = new System.Drawing.Point(45, 17);
            this.gbxRobberLocation.Name = "gbxRobberLocation";
            this.gbxRobberLocation.Size = new System.Drawing.Size(195, 55);
            this.gbxRobberLocation.TabIndex = 15;
            this.gbxRobberLocation.TabStop = false;
            this.gbxRobberLocation.Text = "Where is Robber now? (Ex. 8,T)";
            // 
            // txtNewRobberLocation
            // 
            this.txtNewRobberLocation.Location = new System.Drawing.Point(61, 24);
            this.txtNewRobberLocation.MaxLength = 3;
            this.txtNewRobberLocation.Name = "txtNewRobberLocation";
            this.txtNewRobberLocation.Size = new System.Drawing.Size(75, 20);
            this.txtNewRobberLocation.TabIndex = 1;
            this.txtNewRobberLocation.TextChanged += new System.EventHandler(this.txtNewRobberLocation_TextChanged);
            // 
            // PlayRobberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gbxRobberLocation);
            this.Controls.Add(this.gbxResourceRobbed);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxPlayerRobbed);
            this.Name = "PlayRobberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlayRobber";
            this.gbxPlayerRobbed.ResumeLayout(false);
            this.gbxPlayerRobbed.PerformLayout();
            this.gbxResourceRobbed.ResumeLayout(false);
            this.gbxResourceRobbed.PerformLayout();
            this.gbxRobberLocation.ResumeLayout(false);
            this.gbxRobberLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPlayerRobbed;
        private System.Windows.Forms.RadioButton rdoPlayer4;
        private System.Windows.Forms.RadioButton rdoPlayer3;
        private System.Windows.Forms.RadioButton rdoPlayer2;
        private System.Windows.Forms.RadioButton rdoPlayer1;
        private System.Windows.Forms.TextBox txtResourceRobbed;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbxResourceRobbed;
        private System.Windows.Forms.GroupBox gbxRobberLocation;
        private System.Windows.Forms.TextBox txtNewRobberLocation;

    }
}