using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Proyector
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el Marca")]
        [StringLength(24)]
        public string? Marca { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el Modelo")]
        public string Modelo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Debe proporcionar un valor para el Numero de Serie")]
        public string NumeroDeSerie { get; set; } = string.Empty;

        public SituacionProyector Situacion { get; set; } = SituacionProyector.Bueno;
        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime? FechaDeBaja { get; set; } = null;

        [Required]
        public int DepartamentoId { get; set; }

        //propiedades de navegaciones de la relacion 
        public Departamento Departamento { get; } 
    }

    public enum SituacionProyector
    {
        Bueno =1,
        Regular,
        Malo,
    }
}
