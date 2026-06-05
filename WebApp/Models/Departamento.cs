using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe proporcionar el titulo del departaamento")]

        public string Titulo { get; set; } = string.Empty;


        //propiedad de navegacion de la rlacion
        public IEnumerable<Proyector> Proyectores { get; set; } = new List<Proyector>();
    }
}
