using AplicacaoEnrity.Data;
using Ecomerci;

namespace AplicacaoEnrity.Repositoy
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Conexao _db;
        public UsuarioRepository(Conexao Db)
        {
            _db = Db;
        }

        public List<Usuario> Get()
        {
            //semelhante a um select, á posicao do oderby refere - se a aplicacao ou no banco, ou na memoria do computador
            return _db.Usuarios.OrderBy(a => a.Id).ToList();
        }

        public Usuario Get(int id)
        {//usando o Find como opcao de busca pelo Id
            return _db.Usuarios.Find(id)!;

        }
        public void Add(Usuario usuario)
        {
            _db.Add(usuario);
            _db.SaveChanges();
        }
        public void Update(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            _db.SaveChanges(true);
        }
        public void Delete(int id)
        {
            _db.Usuarios.Remove(Get(id));
            _db.SaveChanges();
        }

    }
}
