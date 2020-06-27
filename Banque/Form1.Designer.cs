namespace Banque
{
    partial class BanqueForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.rtbOuput = new System.Windows.Forms.RichTextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(354, 524);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(119, 38);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Entrer";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 486);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(174, 25);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Entrer votre choix :";
            // 
            // rtbOuput
            // 
            this.rtbOuput.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbOuput.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOuput.Location = new System.Drawing.Point(12, 12);
            this.rtbOuput.Name = "rtbOuput";
            this.rtbOuput.ReadOnly = true;
            this.rtbOuput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtbOuput.Size = new System.Drawing.Size(480, 459);
            this.rtbOuput.TabIndex = 2;
            this.rtbOuput.Text = "";
            this.rtbOuput.TextChanged += new System.EventHandler(this.rtbOuput_TextChanged);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(17, 524);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(239, 30);
            this.tbInput.TabIndex = 3;
            // 
            // BanqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(507, 590);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.rtbOuput);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BanqueForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application banquaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RichTextBox rtbOuput;
        private System.Windows.Forms.TextBox tbInput;
    }
}

