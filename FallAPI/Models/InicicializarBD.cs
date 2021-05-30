using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FallAPI.Models;
using System.Data.Entity;

namespace FallAPI.Models
{
    public class InicicializarBD: DropCreateDatabaseIfModelChanges<ContextoBD>
    {
        protected override void Seed(ContextoBD contexto)
        {
            var cancelaciones = new List<Cancelacion>
                {
                new Cancelacion
                {
                    oc = "1435378",
                    precio_despacho= 18890,
                    monto_total_linea =  879900,
                    sku_linea = "J11",
                    f12 = "12618508",
                    tipo_abastecimiento = "CENTRO DISTRIBUCION",
                    dup_oc = 1,
                    dup_f12 = 1,
                    estado_linea = "Released",
                    estado_orden_oms = "Allocated",
                    estado_cd = "CENTRO DISTRIBUCION",
                },
                new Cancelacion
                {
                    oc = "1435378",
                    precio_despacho= 18890,
                    monto_total_linea =  879900,
                    sku_linea = "J11",
                    f12 = "12618508",
                    tipo_abastecimiento = "CENTRO DISTRIBUCION",
                    dup_oc = 2,
                    dup_f12 = 2,
                    estado_linea = "Released",
                    estado_orden_oms = "Allocated",
                    estado_cd = "CENTRO DISTRIBUCION",
                },
                new Cancelacion
                {
                    oc = "1435446",
                    precio_despacho= 0,
                    monto_total_linea =  2939800,
                    sku_linea = "J11",
                    f12 = "12618553",
                    tipo_abastecimiento = "TIENDA",
                    dup_oc = 1,
                    dup_f12 = 1,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "DC Allocated",
                    estado_cd = "TIENDA",
                },
                new Cancelacion
                {
                    oc = "1435446",
                    precio_despacho= 0,
                    monto_total_linea =  5543700,
                    sku_linea = "J11",
                    f12 = "12618553",
                    tipo_abastecimiento = "TIENDA",
                    dup_oc = 2,
                    dup_f12 = 2,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "DC Allocated",
                    estado_cd = "TIENDA",
                },
                new Cancelacion
                {
                    oc = "1435506",
                    precio_despacho= 0,
                    monto_total_linea =  157900,
                    sku_linea = "J11",
                    f12 = "12618572",
                    tipo_abastecimiento = "CENTRO DISTRIBUCION",
                    dup_oc = 1,
                    dup_f12 = 1,
                    estado_linea = "Shipped",
                    estado_orden_oms = "Partially Released",
                    estado_cd = "CENTRO DISTRIBUCION",
                },
                new Cancelacion
                {
                    oc = "1435506",
                    precio_despacho= 0,
                    monto_total_linea =  242900,
                    sku_linea = "J11",
                    f12 = "12618572",
                    tipo_abastecimiento = "CENTRO DISTRIBUCION",
                    dup_oc = 2,
                    dup_f12 = 1,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "Partially Released",
                    estado_cd = "CENTRO DISTRIBUCION",
                },
                new Cancelacion
                {
                    oc = "1435506",
                    precio_despacho= 0,
                    monto_total_linea =  1595900,
                    sku_linea = "J11",
                    f12 = "12618572",
                    tipo_abastecimiento = "CENTRO DISTRIBUCION",
                    dup_oc = 2,
                    dup_f12 = 2,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "Partially Released",
                    estado_cd = "CENTRO DISTRIBUCION",
                },
                new Cancelacion
                {
                    oc = "1435511",
                    precio_despacho= 0,
                    monto_total_linea =  2179900,
                    sku_linea = "J11",
                    f12 = "12618571",
                    tipo_abastecimiento = "CENTRO DISTRIBUCION",
                    dup_oc = 1,
                    dup_f12 = 1,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "Allocated",
                    estado_cd = "Anulado SAB",
                },
                new Cancelacion
                {
                    oc = "1435600",
                    precio_despacho= 0,
                    monto_total_linea =  1562900,
                    sku_linea = "J11",
                    f12 = "12618623",
                    tipo_abastecimiento = "CENTRO DISTRIBUCION",
                    dup_oc = 1,
                    dup_f12 = 1,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "Partially DC Allocated",
                    estado_cd = "Anulado SAB",
                },
                new Cancelacion
                {
                    oc = "1435600",
                    precio_despacho= 0,
                    monto_total_linea =  2222900,
                    sku_linea = "J11",
                    f12 = "12618623",
                    tipo_abastecimiento = "CENTRO DISTRIBUCION",
                    dup_oc = 2,
                    dup_f12 = 1,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "Partially DC Allocated",
                    estado_cd = "Anulado SAB",
                },
                new Cancelacion
                {
                    oc = "1435640",
                    precio_despacho= 0,
                    monto_total_linea =  1149900,
                    sku_linea = "J11",
                    f12 = "12618650",
                    tipo_abastecimiento = "TIENDA",
                    dup_oc = 1,
                    dup_f12 = 1,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "DC Allocated",
                    estado_cd = "TIENDA",
                },
                new Cancelacion
                {
                    oc = "1435640",
                    precio_despacho= 0,
                    monto_total_linea =  669900,
                    sku_linea = "J11",
                    f12 = "12618650",
                    tipo_abastecimiento = "TIENDA",
                    dup_oc = 2,
                    dup_f12 = 2,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "DC Allocated",
                    estado_cd = "TIENDA",
                },
                new Cancelacion
                {
                    oc = "1435640",
                    precio_despacho= 0,
                    monto_total_linea =  56900,
                    sku_linea = "J11",
                    f12 = "12618650",
                    tipo_abastecimiento = "TIENDA",
                    dup_oc = 2,
                    dup_f12 = 2,
                    estado_linea = "DC Allocated",
                    estado_orden_oms = "DC Allocated",
                    estado_cd = "TIENDA",
                },
                new Cancelacion
                {
                    oc = "1435648",
                    precio_despacho= 14980,
                    monto_total_linea =  90890,
                    sku_linea = "J11",
                    f12 = "12618654",
                    tipo_abastecimiento = "PROVEEDOR",
                    dup_oc = 1,
                    dup_f12 = 1,
                    estado_linea = "Draft",
                    estado_orden_oms = "DO Created",
                    estado_cd = "PROVEEDOR",
                },

            };
            cancelaciones.ForEach(c => contexto.Cancelaciones.Add(c));
            contexto.SaveChanges();

            var datos = new List<Dato>
            {
                new Dato
                {
                    oc  = "1435378",
                    f12 = "12618508",
                    sku = "4939057",
                    cc = "123",
                    estado = null,
                },
                new Dato
                {
                    oc  = "1435378",
                    f12 = "12618508",
                    sku = "9570642",
                    cc = "123",
                    estado = null,
                },
                new Dato
                {
                    oc  = "1435506",
                    f12 = "12618572",
                    sku = "5076124",
                    cc = "456",
                    estado = null,
                },
                new Dato
                {
                    oc  = "1435506",
                    f12 = "12618572",
                    sku = "3907381",
                    cc = "456",
                    estado = null,
                },
                new Dato
                {
                    oc  = "1435506",
                    f12 = "12618572",
                    sku = "3028015",
                    cc = "456",
                    estado = null,
                },
                new Dato
                {
                    oc  = "1435600",
                    f12 = "12618623",
                    sku = "3192409",
                    cc = "789",
                    estado = null,
                },
                new Dato
                {
                    oc  = "1435600",
                    f12 = "12618623",
                    sku = "4087289",
                    cc = "789",
                    estado = null,
                },
                new Dato
                {
                    oc  = "1435640",
                    f12 = "12618650",
                    sku = "3664248",
                    cc = "1122",
                    estado = null,
                },
                new Dato
                {
                    oc  = "1435640",
                    f12 = "12618650",
                    sku = "9399280",
                    cc = "1122",
                    estado = null,
                },
                new Dato
                {
                    oc  = "1435640",
                    f12 = "12618650",
                    sku = "4073265",
                    cc = "1122",
                    estado = null,
                },
            };
            datos.ForEach(d => contexto.Datos.Add(d));
            contexto.SaveChanges();
        }
    }
}