using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gamestore.Models
{
    [Table("t_producto")]
    public class Producto
    {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("categoria")]
        public string Categoria { get; set; }
        [Column("precio")]
        public decimal Precio {get; set;}
        [Column("descuento")]
        public string Descuento {get; set; }   
    }
}