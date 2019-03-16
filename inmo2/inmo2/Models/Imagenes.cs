using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inmo2.Models
{
    public class Imagenes
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string almacenada { get; set; }

        public virtual ICollection<PropiedadesImagenes> PropiedadesImagenes{ get; set; }

    }
}