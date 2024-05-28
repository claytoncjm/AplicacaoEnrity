using Ecomerci;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoEnrity.Data
{
    public class Conexao : DbContext
    {

        public Conexao(DbContextOptions<Conexao> options) : base(options)   
        {
        }

        public DbSet <Usuario> Usuarios { get; set; }

        public DbSet <Contato>Contatos { get; set; }
        public DbSet <EnderecoEntrega>EnderecosEntregas { get; set; }
        public DbSet <Departamento>Departamentos { get; set; }







    }
}
