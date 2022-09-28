using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SGV.Models;
using SGV.Models.RecursosHumanos;

namespace SGV.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Softwares> Softwares { get; set; }

        public DbSet<Permissoes> Permissoes { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Sub_Menus> Sub_Menus { get; set; }
        public DbSet<SolicitacaoUsuario> SolicitacaoUsuario { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<Sub_Setor> Sub_Setor { get; set; }

        public DbSet<AlteracaoFuncional> AlteracaoFuncional { get; set; }
        public DbSet<solicitacaoDesligamento> solicitacaoDesligamento { get; set; }
        public DbSet<solicitacaoTreinamento> solicitacaoTreinamento { get; set; }
        public DbSet<RNC> RNC { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
