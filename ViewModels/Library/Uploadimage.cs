using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels.Library
{
    public class Uploadimage
    {
        // Abre una ventana para poder agreaga una imagen.
        private OpenFileDialog fd = new OpenFileDialog();
        // Se crea un método.
        public void CargarImagen (PictureBox pictureBox)
        {
            //Establecer la propiedad de WaitOnLoad a true significa que la imagen se carga de forma sincrona.
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();
            if (fd.FileName != string.Empty)
            {
              pictureBox.ImageLocation = fd.FileName; // la ruta donde se encuentra la imagen


            }
        }
            
            
    }
}
