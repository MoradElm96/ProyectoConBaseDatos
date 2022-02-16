
namespace Proyecto.Vistas
{
    partial class FrmRegistroResponsable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroResponsable));
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2Clave = new System.Windows.Forms.Label();
            this.label3Clave2 = new System.Windows.Forms.Label();
            this.textBox1Nombre = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxClave2 = new System.Windows.Forms.TextBox();
            this.lblErrorClave = new System.Windows.Forms.Label();
            this.lblErrorNombreUsuario = new System.Windows.Forms.Label();
            this.labelErrorContraseña = new System.Windows.Forms.Label();
            this.label1ErrorNommbre = new System.Windows.Forms.Label();
            this.label1ClaveNocoincide = new System.Windows.Forms.Label();
            this.label1UsuarioExiste = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2btnCancelar = new System.Windows.Forms.PictureBox();
            this.pictureBox1btnAceptar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1btnAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(39, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(238, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Responsable RRHH";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // label2Clave
            // 
            this.label2Clave.AutoSize = true;
            this.label2Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Clave.Location = new System.Drawing.Point(39, 130);
            this.label2Clave.Name = "label2Clave";
            this.label2Clave.Size = new System.Drawing.Size(167, 20);
            this.label2Clave.TabIndex = 1;
            this.label2Clave.Text = "Escriba Contraseña";
            this.label2Clave.Click += new System.EventHandler(this.label2Clave_Click);
            // 
            // label3Clave2
            // 
            this.label3Clave2.AutoSize = true;
            this.label3Clave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Clave2.Location = new System.Drawing.Point(39, 175);
            this.label3Clave2.Name = "label3Clave2";
            this.label3Clave2.Size = new System.Drawing.Size(179, 20);
            this.label3Clave2.TabIndex = 2;
            this.label3Clave2.Text = "Confirme Contraseña";
            this.label3Clave2.Click += new System.EventHandler(this.label3Clave2_Click);
            // 
            // textBox1Nombre
            // 
            this.textBox1Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Nombre.Location = new System.Drawing.Point(303, 86);
            this.textBox1Nombre.MaxLength = 12;
            this.textBox1Nombre.Name = "textBox1Nombre";
            this.textBox1Nombre.Size = new System.Drawing.Size(130, 22);
            this.textBox1Nombre.TabIndex = 3;
            this.textBox1Nombre.TextChanged += new System.EventHandler(this.textBox1Nombre_TextChanged);
            this.textBox1Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Nombre_KeyPress);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave.Location = new System.Drawing.Point(303, 130);
            this.textBoxClave.MaxLength = 4;
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(130, 22);
            this.textBoxClave.TabIndex = 4;
            this.textBoxClave.TextChanged += new System.EventHandler(this.textBoxClave_TextChanged);
            // 
            // textBoxClave2
            // 
            this.textBoxClave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave2.Location = new System.Drawing.Point(303, 175);
            this.textBoxClave2.MaxLength = 4;
            this.textBoxClave2.Name = "textBoxClave2";
            this.textBoxClave2.PasswordChar = '*';
            this.textBoxClave2.Size = new System.Drawing.Size(130, 22);
            this.textBoxClave2.TabIndex = 5;
            this.textBoxClave2.TextChanged += new System.EventHandler(this.textBoxClave2_TextChanged);
            this.textBoxClave2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClave2_KeyPress);
            // 
            // lblErrorClave
            // 
            this.lblErrorClave.AutoSize = true;
            this.lblErrorClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClave.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClave.Location = new System.Drawing.Point(439, 177);
            this.lblErrorClave.Name = "lblErrorClave";
            this.lblErrorClave.Size = new System.Drawing.Size(16, 20);
            this.lblErrorClave.TabIndex = 122;
            this.lblErrorClave.Text = "*";
            this.lblErrorClave.Visible = false;
            // 
            // lblErrorNombreUsuario
            // 
            this.lblErrorNombreUsuario.AutoSize = true;
            this.lblErrorNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombreUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombreUsuario.Location = new System.Drawing.Point(439, 88);
            this.lblErrorNombreUsuario.Name = "lblErrorNombreUsuario";
            this.lblErrorNombreUsuario.Size = new System.Drawing.Size(16, 20);
            this.lblErrorNombreUsuario.TabIndex = 123;
            this.lblErrorNombreUsuario.Text = "*";
            this.lblErrorNombreUsuario.Visible = false;
            // 
            // labelErrorContraseña
            // 
            this.labelErrorContraseña.AutoSize = true;
            this.labelErrorContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorContraseña.ForeColor = System.Drawing.Color.Red;
            this.labelErrorContraseña.Location = new System.Drawing.Point(303, 205);
            this.labelErrorContraseña.Name = "labelErrorContraseña";
            this.labelErrorContraseña.Size = new System.Drawing.Size(0, 20);
            this.labelErrorContraseña.TabIndex = 124;
            this.labelErrorContraseña.Visible = false;
            // 
            // label1ErrorNommbre
            // 
            this.label1ErrorNommbre.AutoSize = true;
            this.label1ErrorNommbre.Location = new System.Drawing.Point(307, 111);
            this.label1ErrorNommbre.Name = "label1ErrorNommbre";
            this.label1ErrorNommbre.Size = new System.Drawing.Size(0, 13);
            this.label1ErrorNommbre.TabIndex = 125;
            // 
            // label1ClaveNocoincide
            // 
            this.label1ClaveNocoincide.AutoSize = true;
            this.label1ClaveNocoincide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1ClaveNocoincide.ForeColor = System.Drawing.Color.Red;
            this.label1ClaveNocoincide.Location = new System.Drawing.Point(310, 205);
            this.label1ClaveNocoincide.Name = "label1ClaveNocoincide";
            this.label1ClaveNocoincide.Size = new System.Drawing.Size(130, 13);
            this.label1ClaveNocoincide.TabIndex = 126;
            this.label1ClaveNocoincide.Text = "La clave no coincide!";
            this.label1ClaveNocoincide.Visible = false;
            // 
            // label1UsuarioExiste
            // 
            this.label1UsuarioExiste.AutoSize = true;
            this.label1UsuarioExiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1UsuarioExiste.ForeColor = System.Drawing.Color.Red;
            this.label1UsuarioExiste.Location = new System.Drawing.Point(319, 114);
            this.label1UsuarioExiste.Name = "label1UsuarioExiste";
            this.label1UsuarioExiste.Size = new System.Drawing.Size(121, 13);
            this.label1UsuarioExiste.TabIndex = 127;
            this.label1UsuarioExiste.Text = "El usuario ya existe!";
            this.label1UsuarioExiste.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 30);
            this.label1.TabIndex = 128;
            this.label1.Text = "Registrar Responsable de RRHH";
            // 
            // pictureBox2btnCancelar
            // 
            this.pictureBox2btnCancelar.Image = global::Proyecto.Properties.Resources.remove_delete_close_10751;
            this.pictureBox2btnCancelar.Location = new System.Drawing.Point(283, 248);
            this.pictureBox2btnCancelar.Name = "pictureBox2btnCancelar";
            this.pictureBox2btnCancelar.Size = new System.Drawing.Size(71, 63);
            this.pictureBox2btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2btnCancelar.TabIndex = 22;
            this.pictureBox2btnCancelar.TabStop = false;
            this.pictureBox2btnCancelar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1btnAceptar
            // 
            this.pictureBox1btnAceptar.Image = global::Proyecto.Properties.Resources.accept_icon_icons1;
            this.pictureBox1btnAceptar.Location = new System.Drawing.Point(134, 251);
            this.pictureBox1btnAceptar.Name = "pictureBox1btnAceptar";
            this.pictureBox1btnAceptar.Size = new System.Drawing.Size(102, 60);
            this.pictureBox1btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1btnAceptar.TabIndex = 21;
            this.pictureBox1btnAceptar.TabStop = false;
            this.pictureBox1btnAceptar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmRegistroResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(501, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1UsuarioExiste);
            this.Controls.Add(this.label1ClaveNocoincide);
            this.Controls.Add(this.label1ErrorNommbre);
            this.Controls.Add(this.labelErrorContraseña);
            this.Controls.Add(this.lblErrorNombreUsuario);
            this.Controls.Add(this.lblErrorClave);
            this.Controls.Add(this.pictureBox2btnCancelar);
            this.Controls.Add(this.pictureBox1btnAceptar);
            this.Controls.Add(this.textBoxClave2);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBox1Nombre);
            this.Controls.Add(this.label3Clave2);
            this.Controls.Add(this.label2Clave);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroResponsable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistroUsuario";
            this.Load += new System.EventHandler(this.FrmRegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1btnAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2Clave;
        private System.Windows.Forms.Label label3Clave2;
        private System.Windows.Forms.TextBox textBox1Nombre;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxClave2;
        private System.Windows.Forms.PictureBox pictureBox1btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox2btnCancelar;
        private System.Windows.Forms.Label lblErrorClave;
        private System.Windows.Forms.Label lblErrorNombreUsuario;
        private System.Windows.Forms.Label labelErrorContraseña;
        private System.Windows.Forms.Label label1ErrorNommbre;
        private System.Windows.Forms.Label label1ClaveNocoincide;
        private System.Windows.Forms.Label label1UsuarioExiste;
        private System.Windows.Forms.Label label1;
    }
}