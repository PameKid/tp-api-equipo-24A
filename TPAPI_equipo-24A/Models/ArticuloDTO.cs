using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPAPI_equipo_24A.Models
{
    public class ArticuloDTO
    {
       
        public string CodArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }


    }
}