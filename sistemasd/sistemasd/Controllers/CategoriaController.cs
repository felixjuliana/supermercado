﻿using sistemasd.Infra;
using sistemasd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sistemasd.Controllers
{
    public class CategoriaController : ApiController
    {

        private ApplicationDbContext contexto = new ApplicationDbContext();

        // GET: api/Categoria
        public IEnumerable<Categoria> Get()
        {
            return contexto.Categorias.ToList();
        }

        // GET: api/Categoria/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Categoria
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categoria/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categoria/5
        public void Delete(int id)
        {
        }
    }
}
