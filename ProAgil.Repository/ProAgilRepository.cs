using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public class ProAgilRepository : IProAgilRepository
    {
        // GERAIS
        public ProAgilContext _context { get; }

        public ProAgilRepository(ProAgilContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void DeleteRange<T>(T[] entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        // Evento
        public Task<Evento[]> GetAllEventoAsync(bool includePalestrantes)
        {
            throw new System.NotImplementedException();
        }

                public Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes)
        {
            throw new System.NotImplementedException();
        }

        // Palestrante
        public Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }



        public Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

    }
}