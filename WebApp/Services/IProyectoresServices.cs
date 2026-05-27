using WebApp.Models;

namespace WebApp.Services
{
    public interface IProyectoresServices
    {
        IEnumerable<Proyector> GetAll();

        void AddProyector(Proyector proyector);
    }

}
