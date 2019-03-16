using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inmo2.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario {get; set; }
        public string Contraseña {get; set; }
        public string Token { get; set; }
        
    }
    
}