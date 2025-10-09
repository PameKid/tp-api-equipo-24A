using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using Negocio;


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
        public string Get(int id)
        {
            ArticuloNegocio aNegocio = new ArticuloNegocio();
            List<Articulo> nuevaLista = aNegocio.listarArticulos();
            return "id";

           // return nuevaLista.Find(x => x.Id == id);
        }

        // POST: api/Articulo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Articulo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Articulo/5
        public void Delete(int id)
        {
        }
    }
}
