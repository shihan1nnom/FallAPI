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
    public class CancelacionesController : ApiController
    {
        private ContextoBD db = new ContextoBD();

        // GET: api/Cancelaciones
        public IQueryable<Cancelacion> GetCancelaciones()
        {
            return db.Cancelaciones;
        }

        // GET: api/Cancelaciones/5
        [ResponseType(typeof(Cancelacion))]
        public IHttpActionResult GetCancelacion(int id)
        {
            Cancelacion cancelacion = db.Cancelaciones.Find(id);
            if (cancelacion == null)
            {
                return NotFound();
            }

            return Ok(cancelacion);
        }

        // PUT: api/Cancelaciones/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCancelacion(int id, Cancelacion cancelacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cancelacion.CancelacionID)
            {
                return BadRequest();
            }

            db.Entry(cancelacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CancelacionExists(id))
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

        // POST: api/Cancelaciones
        [ResponseType(typeof(Cancelacion))]
        public IHttpActionResult PostCancelacion(Cancelacion cancelacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cancelaciones.Add(cancelacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cancelacion.CancelacionID }, cancelacion);
        }

        // DELETE: api/Cancelaciones/5
        [ResponseType(typeof(Cancelacion))]
        public IHttpActionResult DeleteCancelacion(int id)
        {
            Cancelacion cancelacion = db.Cancelaciones.Find(id);
            if (cancelacion == null)
            {
                return NotFound();
            }

            db.Cancelaciones.Remove(cancelacion);
            db.SaveChanges();

            return Ok(cancelacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CancelacionExists(int id)
        {
            return db.Cancelaciones.Count(e => e.CancelacionID == id) > 0;
        }
    }
}