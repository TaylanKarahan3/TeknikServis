namespace TeknikServis.Formlar
{
    partial class FrmFaturaKalemDetayları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalemDetayları));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.txtserino = new DevExpress.XtraEditors.TextEdit();
            this.txtsirano = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtfaturaid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsirano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfaturaid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl1.Location = new System.Drawing.Point(0, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1360, 488);
            this.gridControl1.TabIndex = 26;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Orchid;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.CadetBlue;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gridView1.DetailHeight = 538;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(151, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 20);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Seri No";
            // 
            // btnara
            // 
            this.btnara.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnara.Appearance.Options.UseFont = true;
            this.btnara.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnara.ImageOptions.Image")));
            this.btnara.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(442, 6);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(70, 30);
            this.btnara.TabIndex = 3;
            this.btnara.Text = "Ara";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // txtserino
            // 
            this.txtserino.Location = new System.Drawing.Point(207, 9);
            this.txtserino.Name = "txtserino";
            this.txtserino.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtserino.Properties.Appearance.Options.UseFont = true;
            this.txtserino.Properties.Mask.EditMask = "A";
            this.txtserino.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtserino.Size = new System.Drawing.Size(41, 26);
            this.txtserino.TabIndex = 1;
            // 
            // txtsirano
            // 
            this.txtsirano.Location = new System.Drawing.Point(319, 9);
            this.txtsirano.Name = "txtsirano";
            this.txtsirano.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtsirano.Properties.Appearance.Options.UseFont = true;
            this.txtsirano.Properties.Mask.EditMask = "AAAAAA";
            this.txtsirano.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtsirano.Size = new System.Drawing.Size(112, 26);
            this.txtsirano.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(263, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 20);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Sıra No";
            // 
            // txtfaturaid
            // 
            this.txtfaturaid.Location = new System.Drawing.Point(84, 10);
            this.txtfaturaid.Name = "txtfaturaid";
            this.txtfaturaid.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtfaturaid.Properties.Appearance.Options.UseFont = true;
            this.txtfaturaid.Size = new System.Drawing.Size(52, 26);
            this.txtfaturaid.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 20);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Fatura ID";
            // 
            // FrmFaturaKalemDetayları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 531);
            this.Controls.Add(this.txtfaturaid);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtsirano);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtserino);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFaturaKalemDetayları";
            this.Text = "FATURA KALEM DETAYLARI";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsirano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfaturaid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.TextEdit txtserino;
        private DevExpress.XtraEditors.TextEdit txtsirano;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtfaturaid;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}