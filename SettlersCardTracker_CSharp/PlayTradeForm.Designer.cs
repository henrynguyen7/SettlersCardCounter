namespace SettlersCardTracker
{
    partial class PlayTradeForm
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
            this.gbxResourcesTraded = new System.Windows.Forms.GroupBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtResourcesTradedFor = new System.Windows.Forms.TextBox();
            this.txtResourcesTradedAway = new System.Windows.Forms.TextBox();
            this.gbxPlayerTraded = new System.Windows.Forms.GroupBox();
            this.rdoBank = new System.Windows.Forms.RadioButton();
            this.rdoPlayer4 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer3 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer2 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer1 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxResourcesTraded.SuspendLayout();
            this.gbxPlayerTraded.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxResourcesTraded
            // 
            this.gbxResourcesTraded.Controls.Add(this.lblInstructions);
            this.gbxResourcesTraded.Controls.Add(this.txtResourcesTradedFor);
            this.gbxResourcesTraded.Controls.Add(this.txtResourcesTradedAway);
            this.gbxResourcesTraded.Location = new System.Drawing.Point(23, 94);
            this.gbxResourcesTraded.Name = "gbxResourcesTraded";
            this.gbxResourcesTraded.Size = new System.Drawing.Size(242, 94);
            this.gbxResourcesTraded.TabIndex = 15;
            this.gbxResourcesTraded.TabStop = false;
            this.gbxResourcesTraded.Text = "Enter resources traded";
            // 
            // lblInfo
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(6, 23);
            this.lblInstructions.Name = "lblInfo";
            this.lblInstructions.Size = new System.Drawing.Size(84, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Ex. T,T,T,T / W";
            // 
            // txtResourcesTradedFor
            // 
            this.txtResourcesTradedFor.Location = new System.Drawing.Point(130, 47);
            this.txtResourcesTradedFor.MaxLength = 10;
            this.txtResourcesTradedFor.Name = "txtResourcesTradedFor";
            this.txtResourcesTradedFor.Size = new System.Drawing.Size(100, 20);
            this.txtResourcesTradedFor.TabIndex = 1;
            this.txtResourcesTradedFor.TextChanged += new System.EventHandler(this.txtResourcesTradedFor_TextChanged);
            // 
            // txtResourcesTradedAway
            // 
            this.txtResourcesTradedAway.Location = new System.Drawing.Point(12, 48);
            this.txtResourcesTradedAway.MaxLength = 10;
            this.txtResourcesTradedAway.Name = "txtResourcesTradedAway";
            this.txtResourcesTradedAway.Size = new System.Drawing.Size(100, 20);
            this.txtResourcesTradedAway.TabIndex = 0;
            this.txtResourcesTradedAway.TextChanged += new System.EventHandler(this.txtResourcesTradedAway_TextChanged);
            // 
            // gbxPlayerTraded
            // 
            this.gbxPlayerTraded.Controls.Add(this.rdoBank);
            this.gbxPlayerTraded.Controls.Add(this.rdoPlayer4);
            this.gbxPlayerTraded.Controls.Add(this.rdoPlayer3);
            this.gbxPlayerTraded.Controls.Add(this.rdoPlayer2);
            this.gbxPlayerTraded.Controls.Add(this.rdoPlayer1);
            this.gbxPlayerTraded.Location = new System.Drawing.Point(20, 24);
            this.gbxPlayerTraded.Name = "gbxPlayerTraded";
            this.gbxPlayerTraded.Size = new System.Drawing.Size(245, 48);
            this.gbxPlayerTraded.TabIndex = 15;
            this.gbxPlayerTraded.TabStop = false;
            this.gbxPlayerTraded.Text = "With which Player did Player trade?";
            // 
            // rdoBank
            // 
            this.rdoBank.AutoSize = true;
            this.rdoBank.Location = new System.Drawing.Point(188, 19);
            this.rdoBank.Name = "rdoBank";
            this.rdoBank.Size = new System.Drawing.Size(50, 17);
            this.rdoBank.TabIndex = 4;
            this.rdoBank.TabStop = true;
            this.rdoBank.Text = "Bank";
            this.rdoBank.UseVisualStyleBackColor = true;
            this.rdoBank.CheckedChanged += new System.EventHandler(this.rdoBank_CheckedChanged);
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(105, 217);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // PlayTradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxPlayerTraded);
            this.Controls.Add(this.gbxResourcesTraded);
            this.Name = "PlayTradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlayTrade";
            this.gbxResourcesTraded.ResumeLayout(false);
            this.gbxResourcesTraded.PerformLayout();
            this.gbxPlayerTraded.ResumeLayout(false);
            this.gbxPlayerTraded.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxResourcesTraded;
        private System.Windows.Forms.GroupBox gbxPlayerTraded;
        private System.Windows.Forms.RadioButton rdoPlayer4;
        private System.Windows.Forms.RadioButton rdoPlayer3;
        private System.Windows.Forms.RadioButton rdoPlayer2;
        private System.Windows.Forms.RadioButton rdoPlayer1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoBank;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtResourcesTradedFor;
        private System.Windows.Forms.TextBox txtResourcesTradedAway;
    }
}