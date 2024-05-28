using Ecomerci;

namespace AplicacaoEnrity.Repositoy
{
    public interface IUsuarioRepository
    {
        //interface definira os CRUD

        List<Usuario> Get();
        Usuario Get(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
