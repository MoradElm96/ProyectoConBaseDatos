
namespace Proyecto
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolArchivo = new System.Windows.Forms.ToolStripSplitButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAtletas = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSalarios = new System.Windows.Forms.ToolStripLabel();
            this.toolStripResultados = new System.Windows.Forms.ToolStripSplitButton();
            this.añadirResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabelGestionAtletas = new System.Windows.Forms.ToolStripLabel();
            this.toolStripWebPage = new System.Windows.Forms.ToolStripLabel();
            this.toolstripMapa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripRegistrarRRHH = new System.Windows.Forms.ToolStripLabel();
            this.toolStripResponsablesRRHH = new System.Windows.Forms.ToolStripLabel();
            this.toolStripAyuda = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolArchivo,
            this.toolStripAtletas,
            this.toolStripLabelSalarios,
            this.toolStripResultados,
            this.toolStripLabelGestionAtletas,
            this.toolStripWebPage,
            this.toolstripMapa,
            this.toolStripRegistrarRRHH,
            this.toolStripResponsablesRRHH,
            this.toolStripAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(935, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolArchivo
            // 
            this.toolArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.toolArchivo.Image = global::Proyecto.Properties.Resources.File_Explorer_23583;
            this.toolArchivo.Name = "toolArchivo";
            this.toolArchivo.Size = new System.Drawing.Size(80, 22);
            this.toolArchivo.Text = "Archivo";
            this.toolArchivo.Click += new System.EventHandler(this.toolStripLabelArchivo_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.salirToolStripMenuItem.Text = "Salir     Alt+E";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripAtletas
            // 
            this.toolStripAtletas.Image = global::Proyecto.Properties.Resources.olimpycs_4_icon_icons_com_68636;
            this.toolStripAtletas.Name = "toolStripAtletas";
            this.toolStripAtletas.Size = new System.Drawing.Size(59, 22);
            this.toolStripAtletas.Text = "Atletas";
            this.toolStripAtletas.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // toolStripLabelSalarios
            // 
            this.toolStripLabelSalarios.Image = global::Proyecto.Properties.Resources.dollarsign_7083;
            this.toolStripLabelSalarios.Name = "toolStripLabelSalarios";
            this.toolStripLabelSalarios.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabelSalarios.Text = "Salarios";
            this.toolStripLabelSalarios.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // toolStripResultados
            // 
            this.toolStripResultados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirResultadoToolStripMenuItem,
            this.verResultadosToolStripMenuItem});
            this.toolStripResultados.Image = global::Proyecto.Properties.Resources.result_clipboard_check_mark_list_icon_153875;
            this.toolStripResultados.Name = "toolStripResultados";
            this.toolStripResultados.Size = new System.Drawing.Size(96, 22);
            this.toolStripResultados.Text = "Resultados";
            this.toolStripResultados.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // añadirResultadoToolStripMenuItem
            // 
            this.añadirResultadoToolStripMenuItem.Name = "añadirResultadoToolStripMenuItem";
            this.añadirResultadoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.añadirResultadoToolStripMenuItem.Text = "Añadir Resultado";
            this.añadirResultadoToolStripMenuItem.Click += new System.EventHandler(this.añadirResultadoToolStripMenuItem_Click);
            // 
            // verResultadosToolStripMenuItem
            // 
            this.verResultadosToolStripMenuItem.Name = "verResultadosToolStripMenuItem";
            this.verResultadosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.verResultadosToolStripMenuItem.Text = "Ver  Resultados";
            this.verResultadosToolStripMenuItem.Click += new System.EventHandler(this.verResultadosToolStripMenuItem_Click);
            // 
            // toolStripLabelGestionAtletas
            // 
            this.toolStripLabelGestionAtletas.Image = global::Proyecto.Properties.Resources._2799204_management_99783;
            this.toolStripLabelGestionAtletas.Name = "toolStripLabelGestionAtletas";
            this.toolStripLabelGestionAtletas.Size = new System.Drawing.Size(116, 22);
            this.toolStripLabelGestionAtletas.Text = "Gestion de atletas";
            this.toolStripLabelGestionAtletas.Click += new System.EventHandler(this.toolStripLabelGestionAtletas_Click);
            // 
            // toolStripWebPage
            // 
            this.toolStripWebPage.Image = global::Proyecto.Properties.Resources.website_web_12218;
            this.toolStripWebPage.Name = "toolStripWebPage";
            this.toolStripWebPage.Size = new System.Drawing.Size(73, 22);
            this.toolStripWebPage.Text = "WebPage";
            this.toolStripWebPage.Click += new System.EventHandler(this.toolStripWebPage_Click);
            // 
            // toolstripMapa
            // 
            this.toolstripMapa.Image = global::Proyecto.Properties.Resources.logoUbic1;
            this.toolstripMapa.Name = "toolstripMapa";
            this.toolstripMapa.Size = new System.Drawing.Size(88, 22);
            this.toolstripMapa.Text = "Localizacion";
            this.toolstripMapa.Click += new System.EventHandler(this.toolstripMapa_Click);
            // 
            // toolStripRegistrarRRHH
            // 
            this.toolStripRegistrarRRHH.Image = global::Proyecto.Properties.Resources.new_add_user_16734;
            this.toolStripRegistrarRRHH.Name = "toolStripRegistrarRRHH";
            this.toolStripRegistrarRRHH.Size = new System.Drawing.Size(104, 22);
            this.toolStripRegistrarRRHH.Text = "Registrar RRHH";
            this.toolStripRegistrarRRHH.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripResponsablesRRHH
            // 
            this.toolStripResponsablesRRHH.Image = global::Proyecto.Properties.Resources.humans_icon_icons_com_67854;
            this.toolStripResponsablesRRHH.Name = "toolStripResponsablesRRHH";
            this.toolStripResponsablesRRHH.Size = new System.Drawing.Size(129, 22);
            this.toolStripResponsablesRRHH.Text = "Responsables RRHH";
            this.toolStripResponsablesRRHH.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripAyuda
            // 
            this.toolStripAyuda.Image = global::Proyecto.Properties.Resources.search_book_open_search_locate_6178;
            this.toolStripAyuda.Name = "toolStripAyuda";
            this.toolStripAyuda.Size = new System.Drawing.Size(57, 22);
            this.toolStripAyuda.Text = "Ayuda";
            this.toolStripAyuda.Click += new System.EventHandler(this.toolStripAyuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MMA champ", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(86, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "UFC 261 : Usman vs Masvidal 2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(935, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources._161431968_150915146903109_9165319601587942362_n_650x250;
            this.pictureBox1.Location = new System.Drawing.Point(170, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(935, 568);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Fighting Championship 261";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSalarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelGestionAtletas;
        private System.Windows.Forms.ToolStripLabel toolStripAyuda;
        private System.Windows.Forms.ToolStripLabel toolStripWebPage;
        private System.Windows.Forms.ToolStripLabel toolstripMapa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripResultados;
        private System.Windows.Forms.ToolStripMenuItem añadirResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripAtletas;
        private System.Windows.Forms.ToolStripLabel toolStripRegistrarRRHH;
        private System.Windows.Forms.ToolStripLabel toolStripResponsablesRRHH;
        private System.Windows.Forms.ToolStripSplitButton toolArchivo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

