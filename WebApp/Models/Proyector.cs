using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Proyector
    {
        public int Id { get; set; } 
        [Required(ErrorMessage ="Debe proporcionar un valor para el Marca")]
        [StringLength(24)]
        public string? Marca { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el Numero de Serie")]
        public string NumeroDeSerie { get; set; }

        public SituacionProyector Situacion { get; set; } = SituacionProyector.Bueno;

        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        public DateTime? FechaDeBaja { get; set; } = null;
    }

    public enum SituacionProyector
    {
        Bueno =1,
        Regular,
        Malo,
    }
}
