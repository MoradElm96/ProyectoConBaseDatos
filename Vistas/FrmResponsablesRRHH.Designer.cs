
namespace Proyecto.Vistas
{
    partial class FrmResponsablesRRHH
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
            this.dgvResponsables = new System.Windows.Forms.DataGridView();
            this.responsableRRHHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsableRRHHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResponsables
            // 
            this.dgvResponsables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsables.Location = new System.Drawing.Point(160, 81);
            this.dgvResponsables.Name = "dgvResponsables";
            this.dgvResponsables.Size = new System.Drawing.Size(461, 283);
            this.dgvResponsables.TabIndex = 0;
            this.dgvResponsables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsables_CellContentClick);
            // 
            // responsableRRHHBindingSource
            // 
            this.responsableRRHHBindingSource.DataSource = typeof(Proyecto.Clases.ResponsableRRHH);
            // 
            // FrmResponsablesRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(780, 452);
            this.Controls.Add(this.dgvResponsables);
            this.Name = "FrmResponsablesRRHH";
            this.Text = "FrmResponsablesRRHH";
            this.Load += new System.EventHandler(this.FrmResponsablesRRHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsableRRHHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResponsables;
        private System.Windows.Forms.BindingSource responsableRRHHBindingSource;
    }
}