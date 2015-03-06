using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;  //añadidas
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;


namespace Asp_EnlaceBD
{
    public partial class frmCaptcha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack)
            {
                crearImagen();
            }
            
        }

        protected void btnRefrescarImagen_Click(object sender, EventArgs e)
        {
            crearImagen();
        }

        private void crearImagen()
        {
            Rectangle rec = new Rectangle(0,0,400,200);
            LinearGradientBrush brocha = new LinearGradientBrush(rec,Color.Black,Color.Red,LinearGradientMode.ForwardDiagonal);
            Bitmap bmp = new Bitmap(400, 200);
            Graphics grafico = Graphics.FromImage(bmp);
            grafico.FillRectangle(brocha, rec);

            string letra = string.Empty;
            Random rmd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int nro = rmd.Next(65, 90);
                letra += (char)nro;
            }
            hiddenLetra.Value = letra;//mismo valor de la imagen
            grafico.DrawString(letra, new Font("Arial", 90), Brushes.Blue, 10, 10);
            bmp.Save(Server.MapPath("Grafico.jpg"), ImageFormat.Jpeg);
            imgCaptcha.ImageUrl = "Grafico.jpg";
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            //aca se hace la validacion y el cast correspondiente
        }
    }
}