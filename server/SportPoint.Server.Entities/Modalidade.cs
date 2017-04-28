using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Classe que possui dados da entidade modalidade.
    /// </summary>
    public class Modalidade : Base.AuditModel //: EntityTypeConfiguration<UserProfile>  
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o identificador da modalidade.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModalidadeId { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna o nome da modalidade.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a descrição da modalidade.
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a quantidade de pessoas por time.
        /// </summary>
        public short ? QtdPessoasTime { get; set; }

        #endregion

        #region Constructors/Destructors

        public Modalidade()
        {
            ////key  
            //HasKey(t => t.ID);
            ////properties             
            //Property(t => t.FirstName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            //Property(t => t.LastName).HasMaxLength(100).HasColumnType("nvarchar");
            //Property(t => t.Address).HasColumnType("nvarchar");
            //Property(t => t.AddedDate).IsRequired();
            //Property(t => t.ModifiedDate).IsRequired();
            //Property(t => t.IP);
            ////table  
            //ToTable("UserProfiles");
            ////relation            
            //HasRequired(t => t.User).WithRequiredDependent(u => u.UserProfile);  
        }

        #endregion
    }
}
