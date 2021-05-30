using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FallAPI.Models;

namespace FallAPI.Controllers
{
    public class DatosController : ApiController
    {
        private ContextoBD db = new ContextoBD();

        // GET: api/Datos
        public IQueryable<Dato> GetDatos()
        {
            return db.Datos;
        }

        // GET: api/Datos/5
        [ResponseType(typeof(Dato))]
        public IHttpActionResult GetDato(int id)
        {
            Dato dato = db.Datos.Find(id);
            if (dato == null)
            {
                return NotFound();
            }

            return Ok(dato);
        }

        // PUT: api/Datos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDato(int id, Dato dato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dato.DatoID)
            {
                return BadRequest();
            }

            db.Entry(dato).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DatoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Datos
        [ResponseType(typeof(Dato))]
        public IHttpActionResult PostDato(Dato dato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Datos.Add(dato);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dato.DatoID }, dato);
        }

        // DELETE: api/Datos/5
        [ResponseType(typeof(Dato))]
        public IHttpActionResult DeleteDato(int id)
        {
            Dato dato = db.Datos.Find(id);
            if (dato == null)
            {
                return NotFound();
            }

            db.Datos.Remove(dato);
            db.SaveChanges();

            return Ok(dato);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DatoExists(int id)
        {
            return db.Datos.Count(e => e.DatoID == id) > 0;
        }
    }
}