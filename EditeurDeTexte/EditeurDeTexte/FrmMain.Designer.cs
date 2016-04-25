namespace EditeurDeTexte
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntmnuCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.cntmnuCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.cntmnuColler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRetablir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSellectionnerTout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbBlocTexte = new System.Windows.Forms.RichTextBox();
            this.rpRichTextBox1 = new RPRichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntmnuCouper,
            this.cntmnuCopier,
            this.cntmnuColler});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 70);
            // 
            // cntmnuCouper
            // 
            this.cntmnuCouper.Image = ((System.Drawing.Image)(resources.GetObject("cntmnuCouper.Image")));
            this.cntmnuCouper.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cntmnuCouper.Name = "cntmnuCouper";
            this.cntmnuCouper.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cntmnuCouper.Size = new System.Drawing.Size(154, 22);
            this.cntmnuCouper.Text = "&Couper";
            this.cntmnuCouper.Click += new System.EventHandler(this.mnuCouper_Click);
            // 
            // cntmnuCopier
            // 
            this.cntmnuCopier.Image = ((System.Drawing.Image)(resources.GetObject("cntmnuCopier.Image")));
            this.cntmnuCopier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cntmnuCopier.Name = "cntmnuCopier";
            this.cntmnuCopier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cntmnuCopier.Size = new System.Drawing.Size(154, 22);
            this.cntmnuCopier.Text = "Co&pier";
            this.cntmnuCopier.Click += new System.EventHandler(this.mnuCopier_Click);
            // 
            // cntmnuColler
            // 
            this.cntmnuColler.Image = ((System.Drawing.Image)(resources.GetObject("cntmnuColler.Image")));
            this.cntmnuColler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cntmnuColler.Name = "cntmnuColler";
            this.cntmnuColler.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.cntmnuColler.Size = new System.Drawing.Size(154, 22);
            this.cntmnuColler.Text = "Co&ller";
            this.cntmnuColler.Click += new System.EventHandler(this.mnuColler_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuEdition,
            this.mnuAPropos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNouveau,
            this.mnuOuvrir,
            this.toolStripSeparator,
            this.mnuEnregistrer,
            this.mnuEnregistrerSous,
            this.toolStripSeparator1,
            this.mnuQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuNouveau
            // 
            this.mnuNouveau.Image = ((System.Drawing.Image)(resources.GetObject("mnuNouveau.Image")));
            this.mnuNouveau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNouveau.Name = "mnuNouveau";
            this.mnuNouveau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNouveau.Size = new System.Drawing.Size(170, 22);
            this.mnuNouveau.Text = "&Nouveau";
            this.mnuNouveau.Click += new System.EventHandler(this.mnuNouveau_Click);
            // 
            // mnuOuvrir
            // 
            this.mnuOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("mnuOuvrir.Image")));
            this.mnuOuvrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOuvrir.Name = "mnuOuvrir";
            this.mnuOuvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOuvrir.Size = new System.Drawing.Size(170, 22);
            this.mnuOuvrir.Text = "&Ouvrir";
            this.mnuOuvrir.Click += new System.EventHandler(this.mnuOuvrir_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuEnregistrer
            // 
            this.mnuEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("mnuEnregistrer.Image")));
            this.mnuEnregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEnregistrer.Name = "mnuEnregistrer";
            this.mnuEnregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuEnregistrer.Size = new System.Drawing.Size(170, 22);
            this.mnuEnregistrer.Text = "&Enregistrer";
            this.mnuEnregistrer.Click += new System.EventHandler(this.mnuEnregistrer_Click);
            // 
            // mnuEnregistrerSous
            // 
            this.mnuEnregistrerSous.Name = "mnuEnregistrerSous";
            this.mnuEnregistrerSous.Size = new System.Drawing.Size(170, 22);
            this.mnuEnregistrerSous.Text = "Enregistrer &sous";
            this.mnuEnregistrerSous.Click += new System.EventHandler(this.mnuEnregistrerSous_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.Size = new System.Drawing.Size(170, 22);
            this.mnuQuitter.Text = "&Quitter";
            this.mnuQuitter.Click += new System.EventHandler(this.mnuQuitter_Click);
            // 
            // mnuEdition
            // 
            this.mnuEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnnuler,
            this.mnuRetablir,
            this.toolStripSeparator3,
            this.mnuCouper,
            this.mnuCopier,
            this.mnuColler,
            this.toolStripSeparator4,
            this.mnuSellectionnerTout});
            this.mnuEdition.Name = "mnuEdition";
            this.mnuEdition.Size = new System.Drawing.Size(56, 20);
            this.mnuEdition.Text = "&Edition";
            // 
            // mnuAnnuler
            // 
            this.mnuAnnuler.Name = "mnuAnnuler";
            this.mnuAnnuler.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuAnnuler.Size = new System.Drawing.Size(164, 22);
            this.mnuAnnuler.Text = "&Annuler";
            this.mnuAnnuler.Click += new System.EventHandler(this.mnuAnnuler_Click);
            // 
            // mnuRetablir
            // 
            this.mnuRetablir.Name = "mnuRetablir";
            this.mnuRetablir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mnuRetablir.Size = new System.Drawing.Size(164, 22);
            this.mnuRetablir.Text = "&Rétablir";
            this.mnuRetablir.Click += new System.EventHandler(this.mnuRetablir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuCouper
            // 
            this.mnuCouper.Image = ((System.Drawing.Image)(resources.GetObject("mnuCouper.Image")));
            this.mnuCouper.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCouper.Name = "mnuCouper";
            this.mnuCouper.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuCouper.Size = new System.Drawing.Size(164, 22);
            this.mnuCouper.Text = "&Couper";
            this.mnuCouper.Click += new System.EventHandler(this.mnuCouper_Click);
            // 
            // mnuCopier
            // 
            this.mnuCopier.Image = ((System.Drawing.Image)(resources.GetObject("mnuCopier.Image")));
            this.mnuCopier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCopier.Name = "mnuCopier";
            this.mnuCopier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopier.Size = new System.Drawing.Size(164, 22);
            this.mnuCopier.Text = "Co&pier";
            this.mnuCopier.Click += new System.EventHandler(this.mnuCopier_Click);
            // 
            // mnuColler
            // 
            this.mnuColler.Image = ((System.Drawing.Image)(resources.GetObject("mnuColler.Image")));
            this.mnuColler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuColler.Name = "mnuColler";
            this.mnuColler.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuColler.Size = new System.Drawing.Size(164, 22);
            this.mnuColler.Text = "Co&ller";
            this.mnuColler.Click += new System.EventHandler(this.mnuColler_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuSellectionnerTout
            // 
            this.mnuSellectionnerTout.Name = "mnuSellectionnerTout";
            this.mnuSellectionnerTout.Size = new System.Drawing.Size(164, 22);
            this.mnuSellectionnerTout.Text = "Sélectio&nner tout";
            this.mnuSellectionnerTout.Click += new System.EventHandler(this.mnuSellectionnerTout_Click);
            // 
            // mnuAPropos
            // 
            this.mnuAPropos.Name = "mnuAPropos";
            this.mnuAPropos.Size = new System.Drawing.Size(67, 20);
            this.mnuAPropos.Text = "À &propos";
            this.mnuAPropos.Click += new System.EventHandler(this.mnuAPropos_Click);
            // 
            // rtbBlocTexte
            // 
            this.rtbBlocTexte.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbBlocTexte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbBlocTexte.Location = new System.Drawing.Point(0, 24);
            this.rtbBlocTexte.Name = "rtbBlocTexte";
            this.rtbBlocTexte.Size = new System.Drawing.Size(333, 172);
            this.rtbBlocTexte.TabIndex = 3;
            this.rtbBlocTexte.Text = "";
            this.rtbBlocTexte.TextChanged += new System.EventHandler(this.rtbBlocTexte_TextChanged);
            // 
            // rpRichTextBox1
            // 
            this.rpRichTextBox1.AcceptsTab = true;
            this.rpRichTextBox1.BackColor = System.Drawing.Color.White;
            this.rpRichTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.rpRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpRichTextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpRichTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rpRichTextBox1.Location = new System.Drawing.Point(0, 24);
            this.rpRichTextBox1.Name = "rpRichTextBox1";
            this.rpRichTextBox1.Padding = new System.Windows.Forms.Padding(4);
            this.rpRichTextBox1.Size = new System.Drawing.Size(333, 172);
            this.rpRichTextBox1.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 196);
            this.Controls.Add(this.rpRichTextBox1);
            this.Controls.Add(this.rtbBlocTexte);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mon Petit Editeur";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuNouveau;
        private System.Windows.Forms.ToolStripMenuItem mnuOuvrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem mnuEnregistrerSous;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuEdition;
        private System.Windows.Forms.ToolStripMenuItem mnuAnnuler;
        private System.Windows.Forms.ToolStripMenuItem mnuRetablir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuCouper;
        private System.Windows.Forms.ToolStripMenuItem mnuCopier;
        private System.Windows.Forms.ToolStripMenuItem mnuColler;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuSellectionnerTout;
        private System.Windows.Forms.ToolStripMenuItem mnuAPropos;
        private System.Windows.Forms.RichTextBox rtbBlocTexte;
        private System.Windows.Forms.ToolStripMenuItem cntmnuCouper;
        private System.Windows.Forms.ToolStripMenuItem cntmnuCopier;
        private System.Windows.Forms.ToolStripMenuItem cntmnuColler;
        private RPRichTextBox rpRichTextBox1;
    }
}

