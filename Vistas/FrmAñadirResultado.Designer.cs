
namespace Proyecto.Vistas
{
    partial class FrmAñadirResultado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAñadirResultado));
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxResultado = new System.Windows.Forms.ComboBox();
            this.comboBoxMetodo = new System.Windows.Forms.ComboBox();
            this.label1Categoria = new System.Windows.Forms.Label();
            this.label1Resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericRonda = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNombreCompletoPeleador = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPeleadorRival = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.atletaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericRonda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Peso pesado            120kg  (265 lb)",
            "Peso semipesado      93kg  (205 lb)",
            "Peso medio             83,9kg  (185 lb)",
            "Peso wélter                77 kg  (169 lb)\t",
            "Peso ligero                 70 kg  (154 lb)\t",
            "Peso pluma                66 kg  (145 lb)\t",
            "Peso gallo                   61 kg  (134 lb)",
            "Peso mosca              56,7kg (125 lb)",
            "Peso paja                   52,3kg (115 lb)"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(311, 150);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 1;
            // 
            // comboBoxResultado
            // 
            this.comboBoxResultado.FormattingEnabled = true;
            this.comboBoxResultado.Items.AddRange(new object[] {
            "Ganador Primer Peleador ",
            "Perdedor Primer Peleador",
            "Empate"});
            this.comboBoxResultado.Location = new System.Drawing.Point(311, 206);
            this.comboBoxResultado.Name = "comboBoxResultado";
            this.comboBoxResultado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxResultado.TabIndex = 2;
            // 
            // comboBoxMetodo
            // 
            this.comboBoxMetodo.FormattingEnabled = true;
            this.comboBoxMetodo.Items.AddRange(new object[] {
            "KO",
            "KO tecnico",
            "Sumision",
            "Decision Unanime",
            "Decision Dividida"});
            this.comboBoxMetodo.Location = new System.Drawing.Point(311, 312);
            this.comboBoxMetodo.Name = "comboBoxMetodo";
            this.comboBoxMetodo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMetodo.TabIndex = 4;
            // 
            // label1Categoria
            // 
            this.label1Categoria.AutoSize = true;
            this.label1Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Categoria.Location = new System.Drawing.Point(104, 155);
            this.label1Categoria.Name = "label1Categoria";
            this.label1Categoria.Size = new System.Drawing.Size(158, 16);
            this.label1Categoria.TabIndex = 5;
            this.label1Categoria.Text = "Seleccione Categoria";
            // 
            // label1Resultado
            // 
            this.label1Resultado.AutoSize = true;
            this.label1Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Resultado.Location = new System.Drawing.Point(101, 211);
            this.label1Resultado.Name = "label1Resultado";
            this.label1Resultado.Size = new System.Drawing.Size(161, 16);
            this.label1Resultado.TabIndex = 6;
            this.label1Resultado.Text = "Seleccione Resultado";
            this.label1Resultado.Click += new System.EventHandler(this.label1Resultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione Ronda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione Metodo";
            // 
            // numericRonda
            // 
            this.numericRonda.Location = new System.Drawing.Point(311, 253);
            this.numericRonda.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericRonda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRonda.Name = "numericRonda";
            this.numericRonda.Size = new System.Drawing.Size(120, 20);
            this.numericRonda.TabIndex = 9;
            this.numericRonda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Primer  Peleador ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxNombreCompletoPeleador
            // 
            this.comboBoxNombreCompletoPeleador.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.atletaBindingSource4, "NombreCompleto", true));
            this.comboBoxNombreCompletoPeleador.FormattingEnabled = true;
            this.comboBoxNombreCompletoPeleador.Location = new System.Drawing.Point(57, 75);
            this.comboBoxNombreCompletoPeleador.Name = "comboBoxNombreCompletoPeleador";
            this.comboBoxNombreCompletoPeleador.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNombreCompletoPeleador.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(158, 360);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 39);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(311, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 39);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Peleador  Contrincante";
            // 
            // comboBoxPeleadorRival
            // 
            this.comboBoxPeleadorRival.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.atletaBindingSource4, "NombreCompleto", true));
            this.comboBoxPeleadorRival.FormattingEnabled = true;
            this.comboBoxPeleadorRival.Location = new System.Drawing.Point(317, 75);
            this.comboBoxPeleadorRival.Name = "comboBoxPeleadorRival";
            this.comboBoxPeleadorRival.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeleadorRival.TabIndex = 15;
            this.comboBoxPeleadorRival.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeleadorRival_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.comboBoxNombreCompletoPeleador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxPeleadorRival);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.competencia__1_;
            this.pictureBox1.Location = new System.Drawing.Point(212, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 57);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // atletaBindingSource4
            // 
            this.atletaBindingSource4.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource3
            // 
            this.atletaBindingSource3.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource2
            // 
            this.atletaBindingSource2.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource
            // 
            this.atletaBindingSource.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource1
            // 
            this.atletaBindingSource1.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // FrmAñadirResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(593, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numericRonda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1Resultado);
            this.Controls.Add(this.label1Categoria);
            this.Controls.Add(this.comboBoxMetodo);
            this.Controls.Add(this.comboBoxResultado);
            this.Controls.Add(this.comboBoxCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAñadirResultado";
            this.Text = "FrmAñadirResultado";
            this.Load += new System.EventHandler(this.FrmAñadirResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericRonda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxResultado;
        private System.Windows.Forms.ComboBox comboBoxMetodo;
        private System.Windows.Forms.Label label1Categoria;
        private System.Windows.Forms.Label label1Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericRonda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNombreCompletoPeleador;
        private System.Windows.Forms.BindingSource atletaBindingSource;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource atletaBindingSource1;
        private System.Windows.Forms.BindingSource atletaBindingSource2;
        private System.Windows.Forms.BindingSource atletaBindingSource3;
        private System.Windows.Forms.BindingSource atletaBindingSource4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPeleadorRival;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}