namespace Presentacion
{
    partial class frmOtrosParamertos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LblDirectorio = new System.Windows.Forms.Label();
            this.txtImages = new System.Windows.Forms.TextBox();
            this.btnImages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logo de la empresa:";
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(125, 13);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(270, 20);
            this.txtLogo.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(334, 76);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 27);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(401, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 20);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LblDirectorio
            // 
            this.LblDirectorio.AutoSize = true;
            this.LblDirectorio.Location = new System.Drawing.Point(6, 54);
            this.LblDirectorio.Name = "LblDirectorio";
            this.LblDirectorio.Size = new System.Drawing.Size(119, 13);
            this.LblDirectorio.TabIndex = 4;
            this.LblDirectorio.Text = "Directorio de Imágenes:";
            // 
            // txtImages
            // 
            this.txtImages.Location = new System.Drawing.Point(125, 50);
            this.txtImages.Name = "txtImages";
            this.txtImages.Size = new System.Drawing.Size(269, 20);
            this.txtImages.TabIndex = 5;
            // 
            // btnImages
            // 
            this.btnImages.Location = new System.Drawing.Point(401, 50);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(56, 20);
            this.btnImages.TabIndex = 7;
            this.btnImages.Text = "Buscar";
            this.btnImages.UseVisualStyleBackColor = true;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // frmOtrosParamertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 115);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.txtImages);
            this.Controls.Add(this.LblDirectorio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOtrosParamertos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parámetros Generales";
            this.Load += new System.EventHandler(this.frmOtrosParamertos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LblDirectorio;
        private System.Windows.Forms.TextBox txtImages;
        private System.Windows.Forms.Button btnImages;
    }
}