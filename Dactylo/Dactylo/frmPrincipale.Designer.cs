namespace Dactylo
{
    partial class frmPrincipale
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
            this.rbxTexteExemple = new System.Windows.Forms.RichTextBox();
            this.tbxTextCopie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mspFichier = new System.Windows.Forms.MenuStrip();
            this.tsmFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mspFichier.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbxTexteExemple
            // 
            this.rbxTexteExemple.Location = new System.Drawing.Point(12, 45);
            this.rbxTexteExemple.Name = "rbxTexteExemple";
            this.rbxTexteExemple.ReadOnly = true;
            this.rbxTexteExemple.Size = new System.Drawing.Size(341, 46);
            this.rbxTexteExemple.TabIndex = 0;
            this.rbxTexteExemple.Text = "";
            // 
            // tbxTextCopie
            // 
            this.tbxTextCopie.Location = new System.Drawing.Point(12, 123);
            this.tbxTextCopie.Name = "tbxTextCopie";
            this.tbxTextCopie.Size = new System.Drawing.Size(341, 20);
            this.tbxTextCopie.TabIndex = 1;
            this.tbxTextCopie.TextChanged += new System.EventHandler(this.tbxTextCopie_TextChanged);
            this.tbxTextCopie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTextCopie_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texte copiée :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texte à copié :";
            // 
            // mspFichier
            // 
            this.mspFichier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFichier});
            this.mspFichier.Location = new System.Drawing.Point(0, 0);
            this.mspFichier.Name = "mspFichier";
            this.mspFichier.Size = new System.Drawing.Size(365, 24);
            this.mspFichier.TabIndex = 4;
            this.mspFichier.Text = "menuStrip1";
            // 
            // tsmFichier
            // 
            this.tsmFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiNouveau});
            this.tsmFichier.Name = "tsmFichier";
            this.tsmFichier.Size = new System.Drawing.Size(54, 20);
            this.tsmFichier.Text = "Fichier";
            // 
            // tsiNouveau
            // 
            this.tsiNouveau.Name = "tsiNouveau";
            this.tsiNouveau.Size = new System.Drawing.Size(152, 22);
            this.tsiNouveau.Text = "Nouveau";
            this.tsiNouveau.Click += new System.EventHandler(this.tsiNouveau_Click);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTextCopie);
            this.Controls.Add(this.rbxTexteExemple);
            this.Controls.Add(this.mspFichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mspFichier;
            this.MaximizeBox = false;
            this.Name = "frmPrincipale";
            this.Text = "Apprends la dactylo !";
            this.mspFichier.ResumeLayout(false);
            this.mspFichier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbxTexteExemple;
        private System.Windows.Forms.TextBox tbxTextCopie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip mspFichier;
        private System.Windows.Forms.ToolStripMenuItem tsmFichier;
        private System.Windows.Forms.ToolStripMenuItem tsiNouveau;
    }
}

