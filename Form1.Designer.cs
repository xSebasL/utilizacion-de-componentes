namespace reproductor_de_video
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pdfDocumento = new AxAcroPDFLib.AxAcroPDF();
            this.webbNavegador = new AxSHDocVw.AxWebBrowser();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pdfDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbNavegador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfDocumento
            // 
            this.pdfDocumento.Enabled = true;
            this.pdfDocumento.Location = new System.Drawing.Point(12, 179);
            this.pdfDocumento.Name = "pdfDocumento";
            this.pdfDocumento.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfDocumento.OcxState")));
            this.pdfDocumento.Size = new System.Drawing.Size(397, 192);
            this.pdfDocumento.TabIndex = 2;
            this.pdfDocumento.Enter += new System.EventHandler(this.pdfDocumento_Enter);
            // 
            // webbNavegador
            // 
            this.webbNavegador.Enabled = true;
            this.webbNavegador.Location = new System.Drawing.Point(424, 12);
            this.webbNavegador.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("webbNavegador.OcxState")));
            this.webbNavegador.Size = new System.Drawing.Size(355, 346);
            this.webbNavegador.TabIndex = 1;
            this.webbNavegador.Enter += new System.EventHandler(this.webbNavegador_Enter);
            // 
            // wmpVideo
            // 
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(12, 12);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(397, 160);
            this.wmpVideo.TabIndex = 0;
            this.wmpVideo.Enter += new System.EventHandler(this.wmpVideo_Enter);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.pdfDocumento);
            this.Controls.Add(this.webbNavegador);
            this.Controls.Add(this.wmpVideo);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pdfDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbNavegador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private AxSHDocVw.AxWebBrowser webbNavegador;
        private AxAcroPDFLib.AxAcroPDF pdfDocumento;
    }
}

