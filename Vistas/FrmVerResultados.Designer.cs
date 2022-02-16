
namespace Proyecto.Vistas
{
    partial class FrmVerResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerResultados));
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxNombreCompleto = new System.Windows.Forms.ListBox();
            this.resultadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resultadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.lstCategoria = new System.Windows.Forms.ListBox();
            this.listRonda = new System.Windows.Forms.ListBox();
            this.listMetodo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.listBox1Contrincante = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultados";
            // 
            // lstBoxNombreCompleto
            // 
            this.lstBoxNombreCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstBoxNombreCompleto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.resultadosBindingSource1, "NombreCompletoPeleador", true));
            this.lstBoxNombreCompleto.DataSource = this.resultadosBindingSource;
            this.lstBoxNombreCompleto.DisplayMember = "NombreCompletoPeleador";
            this.lstBoxNombreCompleto.FormattingEnabled = true;
            this.lstBoxNombreCompleto.Location = new System.Drawing.Point(46, 113);
            this.lstBoxNombreCompleto.Name = "lstBoxNombreCompleto";
            this.lstBoxNombreCompleto.Size = new System.Drawing.Size(141, 264);
            this.lstBoxNombreCompleto.TabIndex = 2;
            this.lstBoxNombreCompleto.ValueMember = "NombreCompletoPeleador";
            this.lstBoxNombreCompleto.SelectedIndexChanged += new System.EventHandler(this.lstBoxNombreCompleto_SelectedIndexChanged);
            // 
            // resultadosBindingSource1
            // 
            this.resultadosBindingSource1.DataSource = typeof(Proyecto.Clases.Resultados);
            // 
            // resultadosBindingSource
            // 
            this.resultadosBindingSource.DataSource = typeof(Proyecto.Clases.Resultados);
            // 
            // atletaBindingSource1
            // 
            this.atletaBindingSource1.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource
            // 
            this.atletaBindingSource.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // lstResultado
            // 
            this.lstResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(228, 113);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(162, 264);
            this.lstResultado.TabIndex = 3;
            // 
            // lstCategoria
            // 
            this.lstCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstCategoria.FormattingEnabled = true;
            this.lstCategoria.Location = new System.Drawing.Point(420, 113);
            this.lstCategoria.Name = "lstCategoria";
            this.lstCategoria.Size = new System.Drawing.Size(142, 264);
            this.lstCategoria.TabIndex = 4;
            // 
            // listRonda
            // 
            this.listRonda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listRonda.FormattingEnabled = true;
            this.listRonda.Location = new System.Drawing.Point(600, 113);
            this.listRonda.Name = "listRonda";
            this.listRonda.Size = new System.Drawing.Size(76, 264);
            this.listRonda.TabIndex = 5;
            // 
            // listMetodo
            // 
            this.listMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMetodo.FormattingEnabled = true;
            this.listMetodo.Location = new System.Drawing.Point(739, 113);
            this.listMetodo.Name = "listMetodo";
            this.listMetodo.Size = new System.Drawing.Size(121, 264);
            this.listMetodo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Completo";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(417, 81);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(76, 16);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Categoria";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(736, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Metodo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ronda";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(225, 81);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(79, 16);
            this.lblResultados.TabIndex = 11;
            this.lblResultados.Text = "Resultado";
            // 
            // listBox1Contrincante
            // 
            this.listBox1Contrincante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBox1Contrincante.FormattingEnabled = true;
            this.listBox1Contrincante.Location = new System.Drawing.Point(916, 113);
            this.listBox1Contrincante.Name = "listBox1Contrincante";
            this.listBox1Contrincante.Size = new System.Drawing.Size(245, 264);
            this.listBox1Contrincante.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(913, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contrincante";
            // 
            // button1Salir
            // 
            this.button1Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Salir.Image = global::Proyecto.Properties.Resources.sign_emergency_code_sos_14_icon_icons_com_57231;
            this.button1Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Salir.Location = new System.Drawing.Point(541, 415);
            this.button1Salir.Name = "button1Salir";
            this.button1Salir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1Salir.Size = new System.Drawing.Size(82, 49);
            this.button1Salir.TabIndex = 15;
            this.button1Salir.Text = "Salir";
            this.button1Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1Salir.UseVisualStyleBackColor = false;
            this.button1Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVerResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1208, 527);
            this.Controls.Add(this.button1Salir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1Contrincante);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMetodo);
            this.Controls.Add(this.listRonda);
            this.Controls.Add(this.lstCategoria);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.lstBoxNombreCompleto);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVerResultados";
            this.Text = "FrmVerResultados";
            this.Load += new System.EventHandler(this.FrmVerResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxNombreCompleto;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.ListBox lstCategoria;
        private System.Windows.Forms.ListBox listRonda;
        private System.Windows.Forms.ListBox listMetodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.BindingSource atletaBindingSource;
        private System.Windows.Forms.BindingSource atletaBindingSource1;
        private System.Windows.Forms.BindingSource resultadosBindingSource;
        private System.Windows.Forms.BindingSource resultadosBindingSource1;
        private System.Windows.Forms.ListBox listBox1Contrincante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1Salir;
    }
}