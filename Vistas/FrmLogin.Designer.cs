
namespace Proyecto.Vistas
{
    partial class FrmLogin
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
            this.lblError = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombreRRHH = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2btnCancelar = new System.Windows.Forms.PictureBox();
            this.pictureBox1btnAceptar = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnContratar = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1btnAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(127, 321);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(203, 19);
            this.lblError.TabIndex = 16;
            this.lblError.Text = "Usuario y/o clave erronea";
            this.lblError.Visible = false;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(228, 185);
            this.txtClave.MaxLength = 4;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(162, 26);
            this.txtClave.TabIndex = 13;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // txtNombreRRHH
            // 
            this.txtNombreRRHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRRHH.Location = new System.Drawing.Point(228, 125);
            this.txtNombreRRHH.MaxLength = 12;
            this.txtNombreRRHH.Name = "txtNombreRRHH";
            this.txtNombreRRHH.Size = new System.Drawing.Size(162, 26);
            this.txtNombreRRHH.TabIndex = 12;
            this.txtNombreRRHH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreRRHH_KeyPress);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(65, 189);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(58, 19);
            this.lblClave.TabIndex = 11;
            this.lblClave.Text = "Clave:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(65, 125);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(144, 19);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario de RRHH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // pictureBox2btnCancelar
            // 
            this.pictureBox2btnCancelar.Image = global::Proyecto.Properties.Resources.remove_delete_close_10751;
            this.pictureBox2btnCancelar.Location = new System.Drawing.Point(275, 230);
            this.pictureBox2btnCancelar.Name = "pictureBox2btnCancelar";
            this.pictureBox2btnCancelar.Size = new System.Drawing.Size(71, 63);
            this.pictureBox2btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2btnCancelar.TabIndex = 21;
            this.pictureBox2btnCancelar.TabStop = false;
            this.pictureBox2btnCancelar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1btnAceptar
            // 
            this.pictureBox1btnAceptar.Image = global::Proyecto.Properties.Resources.accept_icon_icons1;
            this.pictureBox1btnAceptar.Location = new System.Drawing.Point(87, 230);
            this.pictureBox1btnAceptar.Name = "pictureBox1btnAceptar";
            this.pictureBox1btnAceptar.Size = new System.Drawing.Size(102, 60);
            this.pictureBox1btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1btnAceptar.TabIndex = 20;
            this.pictureBox1btnAceptar.TabStop = false;
            this.pictureBox1btnAceptar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnContratar
            // 
            this.btnContratar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnContratar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContratar.ForeColor = System.Drawing.Color.Blue;
            this.btnContratar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContratar.Location = new System.Drawing.Point(112, 21);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(234, 78);
            this.btnContratar.TabIndex = 22;
            this.btnContratar.Text = "Si no estas registrado pulse aqui";
            this.btnContratar.UseVisualStyleBackColor = false;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(454, 391);
            this.Controls.Add(this.btnContratar);
            this.Controls.Add(this.pictureBox2btnCancelar);
            this.Controls.Add(this.pictureBox1btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombreRRHH);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1btnAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombreRRHH;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox2btnCancelar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnContratar;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}