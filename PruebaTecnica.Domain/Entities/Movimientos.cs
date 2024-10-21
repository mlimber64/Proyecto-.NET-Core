using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Domain.Entities
{
    [Table("Movimientos", Schema = "dbo")]
    public class Movimientos
    {
        [Column("MovimientoId")]
        [Required]
        public int MovimientoId { get; set; }

        [Column("CuentaId")]
        [Required]
        public int CuentaId { get; set; }

        [Column("Fecha")]
        [Required]
        public DateTime Fecha { get; set; }

        [Column("TipoMovimiento")]
        [Required]
        public string? TipoMovimiento { get; set; }

        [Column("Valor")]
        [Required]
        public string? Valor { get; set; }

        [Column("Saldo")]
        [Required]
        public decimal Saldo { get; set; }
    }
}
