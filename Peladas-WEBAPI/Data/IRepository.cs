using System.Threading.Tasks;
using Peladas_WEBAPI.Models;

namespace Peladas_WEBAPI.Data
{
    public interface IRepository
    {
       
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        
        //Usuario
        Task<Usuario[]> GetAllUsuarioAsync(bool includePelada); 
        Task<Usuario[]> GetUsuariosAsyncByPeladaId(int peladaPId, bool includePelada);
        Task<Usuario>GetAllUsuarioAsyncById( int usuarioId, bool includePelada);        



        //Pelada        
        //Task<Pelada[]> GetAllPeladasAsync(bool includeUsuario);
        //Task<Pelada> GetPeladaAsyncById(int peladaId, bool includeUsuario);
        //Task<Pelada[]> GetPeladasAsyncByUsuariosId(int usuarioId, bool includeLocalP);


        //Local
        //Task<LocalP[]> GetAllLocalPAsync(bool includePelada);
        //Task<LocalP> GetLocalPAsyncById(int localId, bool includePelada);
        //Task<LocalP[]> GetLocalPAsyncByPeladasId(int peladaId, bool includePelada);
    }
}
