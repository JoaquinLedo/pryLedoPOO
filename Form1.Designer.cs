namespace pryLedoPOO
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
            this.BtnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(16, 148);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(224, 49);
            this.BtnCrear.TabIndex = 3;
            this.BtnCrear.Text = "Crear Personaje";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDestreza
            // 
            this.txtDestreza.Location = new System.Drawing.Point(71, 96);
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.Size = new System.Drawing.Size(62, 20);
            this.txtDestreza.TabIndex = 2;
            // 
            // txtFuerza
            // 
            this.txtFuerza.Location = new System.Drawing.Point(71, 69);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(62, 20);
            this.txtFuerza.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(13, 69);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(42, 13);
            this.lblFuerza.TabIndex = 6;
            this.lblFuerza.Text = "Fuerza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destreza:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatos.Location = new System.Drawing.Point(71, 228);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(89, 15);
            this.lblDatos.TabIndex = 7;
            this.lblDatos.Text = "datos ingresados";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 305);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFuerza);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.txtFuerza);
            this.Controls.Add(this.txtDestreza);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmPrincipal";
            this.Text = "Creacion de Personajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDatos;
    }
}

