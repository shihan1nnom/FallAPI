using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FallAPI.Models
{
    public class Cancelacion
    {
        [Key, Column(Order = 1)]
        public int CancelacionID { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string oc { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public int precio_despacho { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public int monto_total_linea { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string sku_linea { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string f12 { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string tipo_abastecimiento { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public int dup_oc { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public int dup_f12 { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string estado_linea { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string estado_orden_oms { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string estado_cd { get; set; }
    }
}