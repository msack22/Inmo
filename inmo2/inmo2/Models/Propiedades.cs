using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inmo2.Models
{
    public class Propiedades
    {
        public int Id { set; get; }
        public string Propiedad { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
        public int Habitaciones { set; get; }
        public int Personas { set; get; }
        public decimal Precio { set; get; }
        public string Imagen { set; get; }
        public virtual ICollection<Imagenes> Imagenes { get; set; }
        
    }
}