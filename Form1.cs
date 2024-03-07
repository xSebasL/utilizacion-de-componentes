using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reproductor_de_video
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void wmpVideo_Enter(object sender, EventArgs e)
        {
            wmpVideo.URL = Application.StartupPath + @"\\media\\video.mp4";
        }

        private void pdfDocumento_Enter(object sender, EventArgs e)
        {
            pdfDocumento.src = Application.StartupPath + @"\\media\\eloquent-javascript.pdf";
        }

        private void webbNavegador_Enter(object sender, EventArgs e)
        {
            webbNavegador.Navigate("https://www.google.com/");
        }
    }
}
