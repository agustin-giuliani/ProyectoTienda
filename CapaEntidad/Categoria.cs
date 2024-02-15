using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En  esta clases creamos la propiedades que tienen nuestros objetos

namespace CapaEntidad
{

    public class Categoria
    {
        public int IdCategori { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
