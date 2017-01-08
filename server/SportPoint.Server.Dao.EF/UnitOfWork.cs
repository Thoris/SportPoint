using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class UnitOfWork : DbContext, Base.IUnitOfWork
    {
        #region Properties

        public DbSet<Entities.Modalidade> Modalidades { get; set; }

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="UnitOfWork"/>.
        /// </summary>
        public UnitOfWork()
            : base("DBProvider")
        {


#if (DEBUG)

            //Database.SetInitializer<UnitOfWork>(new Initializer.AcademiaDataContextInitializer());
#else
            Database.SetInitializer<UnitOfWork>(new CreateDatabaseIfNotExists<UnitOfWork>());           

#endif
        }

        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Removendo a pluralização de nomes das entidades
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


            modelBuilder.Entity<Entities.Modalidade>().ToTable("Modalidades");

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region IUnitOfWork members

        /// <summary>
        /// Método que atualiza os dados na base de dados.
        /// </summary>
        /// <returns>
        /// Quantidade de registros atualizados.
        /// </returns>
        public int Save()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
