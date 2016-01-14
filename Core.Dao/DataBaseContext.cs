using Core.Entity.Entidades;
using Core.Entity.Entidades.Layout;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Core.Dao
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            //: base(@"Data Source=EDSON\;Initial Catalog=CORE;Persist Security Info=True;User ID=Aplicacao;Password=Aplicacao;")
             : base("name=DefaultConnection")
            
        {
            Database.SetInitializer<DatabaseContext>(null);
        }


        #region Map Tables

        public DbSet<UsuarioEntidade> Usuario { get; set; }
       // public DbSet<MenuEntidade> Menu { get; set; }
       // public DbSet<BannerEntidade> Banner { get; set; }
       // public DbSet<ImagemEntidade> Imagem { get; set; }
        public DbSet<NoticiaEntidade> Noticia { get; set; }
        
        public void Save()
        {
            base.SaveChanges();
        }


        #endregion

        /// <summary>
        /// Metodo responsavel por criar o model
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           // modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            //TableMapping
            TableMapping(modelBuilder);

            //mapeamento 1 p muitos
            OneToManyMapping(modelBuilder);

            //Propriedades nao mapeadas
            NotMappedProperties(modelBuilder);

            //Mapeamento muitos p muitos
            ManyToManyMapping(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void TableMapping(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioEntidade>().ToTable("Usuario");
           // modelBuilder.Entity<MenuEntidade>().ToTable("Menu");
           // modelBuilder.Entity<BannerEntidade>().ToTable("Banner");
            //modelBuilder.Entity<ImagemEntidade>().ToTable("Imagem");
            modelBuilder.Entity<NoticiaEntidade>().ToTable("Noticias");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void OneToManyMapping(DbModelBuilder modelBuilder)
        {



        }


        /// <summary>
        /// propriedades que nao, serão mapeadas pelo entity
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void NotMappedProperties(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Entity>().Ignore(e => e.Id);
        }


        /// <summary>
        /// mapeamento muito p muito
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void ManyToManyMapping(DbModelBuilder modelBuilder)
        {

        }

    }
}
