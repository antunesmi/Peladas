using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Peladas_WEBAPI.Models;

namespace Peladas_WEBAPI.Data
{
    public class Repository: IRepository
    {
        
    private readonly DataContext _context;

        public Repository(DataContext context)
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

        public async Task<Usuario[]> GetAllUsuarioAsync(bool includePelada = false)
        {
            IQueryable<Usuario> query = _context.Usuario;

            if (includePelada)
            {
                query = query.Include(pe => pe.Agendamentos)
                             .ThenInclude(ad => ad.Pelada)
                            .ThenInclude(d => d.LocalP);
            }

            query = query.AsNoTracking()
                         .OrderBy(c => c.usuarioId);

            return await query.ToArrayAsync();
        }
////////        

          
        public async Task<Usuario> GetAllUsuarioAsyncById(int  usuarioId, bool includePelada)
        {
            IQueryable<Usuario> query = _context.Usuario;

            if (includePelada)
            {
                query = query.Include(a => a.Agendamentos)
                             .ThenInclude(ad => ad.Pelada)
                             .ThenInclude(d => d.LocalP);
            }

            query = query.AsNoTracking()
                         .OrderBy(usuario => usuario.usuarioId)
                         .Where(usuario => usuario.usuarioId == usuarioId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Usuario[]> GetUsuariosAsyncByPeladasId(int peladasId, bool includePeladas)
        {
            IQueryable<Usuario> query = _context.Usuario;

            if (includePeladas)
            {
                query = query.Include(p => p.Agendamentos)
                             .ThenInclude(ad => ad.Pelada)                             
                             .ThenInclude(d => d.LocalP);
            }

            query = query.AsNoTracking()
                         .OrderBy(usuario => usuario.usuarioId)
                         .Where(usuario => usuario.Agendamentos.Any(ad => ad.peladaId == peladasId));

            return await query.ToArrayAsync();
        }

        public Task<Usuario[]> GetUsuariosAsyncByPeladaId(int peladaPId, bool includePelada)
        {
            throw new System.NotImplementedException();
        }
    }
    }
