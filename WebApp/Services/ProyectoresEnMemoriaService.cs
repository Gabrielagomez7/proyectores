using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresEnMemoriaService : IProyectoresServices
    {
        private static List<Proyector> _proyectores = LoadData();

        public void AddProyector(Proyector proyector)
        {
           if (proyector != null)
            {
                _proyectores.Add(proyector);
            }
        }

        public IEnumerable<Proyector> GetAll()
        {
            return _proyectores;
        }

        private static List<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "963454",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            proyectores.Add(new Proyector()
            {
                Id = 2,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "122296",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "267456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "122056",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            return proyectores;
        }

    }
}
