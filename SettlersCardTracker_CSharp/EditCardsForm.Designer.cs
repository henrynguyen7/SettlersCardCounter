namespace SettlersCardTracker
{
    partial class EditCardsForm
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
            this.rdoPlayer1 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer2 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer3 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer4 = new System.Windows.Forms.RadioButton();
            this.btnAddCards = new System.Windows.Forms.Button();
            this.btnRemoveCards = new System.Windows.Forms.Button();
            this.txtCardsToModify = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdoPlayer1
            // 
            this.rdoPlayer1.AutoSize = true;
            this.rdoPlayer1.Location = new System.Drawing.Point(111, 50);
            this.rdoPlayer1.Name = "rdoPlayer1";
            this.rdoPlayer1.Size = new System.Drawing.Size(63, 17);
            this.rdoPlayer1.TabIndex = 0;
            this.rdoPlayer1.TabStop = true;
            this.rdoPlayer1.Text = "Player 1";
            this.rdoPlayer1.UseVisualStyleBackColor = true;
            this.rdoPlayer1.CheckedChanged += new System.EventHandler(this.rdoPlayer1_CheckedChanged);
            // 
            // rdoPlayer2
            // 
            this.rdoPlayer2.AutoSize = true;
            this.rdoPlayer2.Location = new System.Drawing.Point(111, 73);
            this.rdoPlayer2.Name = "rdoPlayer2";
            this.rdoPlayer2.Size = new System.Drawing.Size(63, 17);
            this.rdoPlayer2.TabIndex = 1;
            this.rdoPlayer2.TabStop = true;
            this.rdoPlayer2.Text = "Player 2";
            this.rdoPlayer2.UseVisualStyleBackColor = true;
            this.rdoPlayer2.CheckedChanged += new System.EventHandler(this.rdoPlayer2_CheckedChanged);
            // 
            // rdoPlayer3
            // 
            this.rdoPlayer3.AutoSize = true;
            this.rdoPlayer3.Location = new System.Drawing.Point(111, 96);
            this.rdoPlayer3.Name = "rdoPlayer3";
            this.rdoPlayer3.Size = new System.Drawing.Size(63, 17);
            this.rdoPlayer3.TabIndex = 2;
            this.rdoPlayer3.TabStop = true;
            this.rdoPlayer3.Text = "Player 3";
            this.rdoPlayer3.UseVisualStyleBackColor = true;
            this.rdoPlayer3.CheckedChanged += new System.EventHandler(this.rdoPlayer3_CheckedChanged);
            // 
            // rdoPlayer4
            // 
            this.rdoPlayer4.AutoSize = true;
            this.rdoPlayer4.Location = new System.Drawing.Point(111, 119);
            this.rdoPlayer4.Name = "rdoPlayer4";
            this.rdoPlayer4.Size = new System.Drawing.Size(63, 17);
            this.rdoPlayer4.TabIndex = 3;
            this.rdoPlayer4.TabStop = true;
            this.rdoPlayer4.Text = "Player 4";
            this.rdoPlayer4.UseVisualStyleBackColor = true;
            this.rdoPlayer4.CheckedChanged += new System.EventHandler(this.rdoPlayer4_CheckedChanged);
            // 
            // btnAddCards
            // 
            this.btnAddCards.Location = new System.Drawing.Point(57, 193);
            this.btnAddCards.Name = "btnAddCards";
            this.btnAddCards.Size = new System.Drawing.Size(75, 40);
            this.btnAddCards.TabIndex = 4;
            this.btnAddCards.Text = "Add Card(s)";
            this.btnAddCards.UseVisualStyleBackColor = true;
            this.btnAddCards.Click += new System.EventHandler(this.btnAddCards_Click);
            // 
            // btnRemoveCards
            // 
            this.btnRemoveCards.Location = new System.Drawing.Point(154, 193);
            this.btnRemoveCards.Name = "btnRemoveCards";
            this.btnRemoveCards.Size = new System.Drawing.Size(75, 40);
            this.btnRemoveCards.TabIndex = 5;
            this.btnRemoveCards.Text = "Remove Card(s)";
            this.btnRemoveCards.UseVisualStyleBackColor = true;
            this.btnRemoveCards.Click += new System.EventHandler(this.btnRemoveCards_Click);
            // 
            // txtCardsToModify
            // 
            this.txtCardsToModify.Location = new System.Drawing.Point(92, 156);
            this.txtCardsToModify.MaxLength = 9;
            this.txtCardsToModify.Name = "txtCardsToModify";
            this.txtCardsToModify.Size = new System.Drawing.Size(100, 20);
            this.txtCardsToModify.TabIndex = 6;
            this.txtCardsToModify.TextChanged += new System.EventHandler(this.txtCardsToModify_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(49, 23);
            this.lblInstructions.Name = "lblInfo";
            this.lblInstructions.Size = new System.Drawing.Size(207, 13);
            this.lblInstructions.TabIndex = 7;
            this.lblInstructions.Text = "Enter resources to modify. (ex. W,B,S,T,O)";
            // 
            // EditCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtCardsToModify);
            this.Controls.Add(this.btnRemoveCards);
            this.Controls.Add(this.btnAddCards);
            this.Controls.Add(this.rdoPlayer4);
            this.Controls.Add(this.rdoPlayer3);
            this.Controls.Add(this.rdoPlayer2);
            this.Controls.Add(this.rdoPlayer1);
            this.Name = "EditCardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormManualEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoPlayer1;
        private System.Windows.Forms.RadioButton rdoPlayer2;
        private System.Windows.Forms.RadioButton rdoPlayer3;
        private System.Windows.Forms.RadioButton rdoPlayer4;
        private System.Windows.Forms.Button btnAddCards;
        private System.Windows.Forms.Button btnRemoveCards;
        private System.Windows.Forms.TextBox txtCardsToModify;
        private System.Windows.Forms.Label lblInstructions;
    }
}