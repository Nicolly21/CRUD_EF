using Microsoft.EntityFrameworkCore;

namespace CRUD_EF.Models
{
    public class FuncionarioContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios{get; set;}

        public FuncionarioContext(DbContextOptions<FuncionarioContext> options) : base(options){
        }
        
    }
}
//Representa o contexto das entidades mapeadas para as tabelas do BD