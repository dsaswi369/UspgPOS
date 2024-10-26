﻿using System.ComponentModel.DataAnnotations.Schema;

namespace UspgPOS.Models
{
    [Table("detalles_venta")]
    public class DetallesVenta
    {
        [Column("id")]
        public long? Id { get; set; }

        [Column("venta_id")]
        public long? VentaId { get; set; }
        public Venta Venta { get; set; }

        [Column("producto_id")]
        public long? ProductoId { get; set; }
        public Producto Producto { get; set; }

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("precio_unitario")] // Cambié este nombre para que sea claro
        public decimal PrecioUnitario { get; set; } // Asegúrate de que esta columna exista en tu base de datos
    }
}