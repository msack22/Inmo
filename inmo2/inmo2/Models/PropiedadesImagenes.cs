using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inmo2.Models
{
    public class PropiedadesImagenes
    {
        public int Id { get; set; }
        public int PropiedadesID { get; set; }
        public int ImagenesID { get; set; }
        

        public virtual Propiedades Propiedades { get; set; }
        public virtual Imagenes Imagenes { get; set; }

    }
}