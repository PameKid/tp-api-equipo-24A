using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using Negocio;
using TPAPI_equipo_24A.Models;


namespace TPAPI_equipo_24A.Controllers
{
    public class ArticuloController : ApiController
    {
        // GET: api/Articulo
        public IEnumerable<Articulo> Get()
        {
            ArticuloNegocio aNegocio = new ArticuloNegocio();

            return aNegocio.listarArticulos();
        }

        // GET: api/Articulo/5

        //Metodo para buscar
        public Articulo Get(int id)
        {
            ArticuloNegocio aNegocio = new ArticuloNegocio();
            List<Articulo> listaArticulo = aNegocio.listarArticulos();
            return listaArticulo.Find(x=> x.Id == id);
            
        }

        // POST: api/Articulo
        public void Post([FromBody]ArticuloDTO art)
        {
            ArticuloNegocio aNegocio = new ArticuloNegocio();
            Articulo articuloNuevo = new Articulo();
            articuloNuevo.CodArticulo = art.CodArticulo;
            articuloNuevo.NombreArticulo = art.NombreArticulo;
            articuloNuevo.Marca = new Marca { IdMarca = art.IdMarca };
            articuloNuevo.Categoria = new Categoria { IdCategoria = art.IdCategoria };
            articuloNuevo.Descripcion = art.Descripcion;
            articuloNuevo.Precio = art.Precio;
            
            aNegocio.agregar(articuloNuevo);

        }

        // PUT: api/Articulo/5
        public void Put(int id, [FromBody] ArticuloDTO art)
        {
            ArticuloNegocio aNegocio = new ArticuloNegocio();
            Articulo articuloNuevo = new Articulo();
            articuloNuevo.CodArticulo = art.CodArticulo;
            articuloNuevo.NombreArticulo = art.NombreArticulo;
            articuloNuevo.Marca = new Marca { IdMarca = art.IdMarca };
            articuloNuevo.Categoria = new Categoria { IdCategoria = art.IdCategoria };
            articuloNuevo.Descripcion = art.Descripcion;
            articuloNuevo.Precio = art.Precio;
            articuloNuevo.Id = id;

            aNegocio.modificar(articuloNuevo);

        }

        // DELETE: api/Articulo/5
        public void Delete(int id)
        {
        }
    }
}
