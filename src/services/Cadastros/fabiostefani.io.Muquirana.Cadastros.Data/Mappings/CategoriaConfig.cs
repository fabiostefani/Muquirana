using fabiostefani.io.Muquirana.Cadastros.Domain.Categorias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fabiostefani.io.Muquirana.Cadastros.Data.Mappings
{
    public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("CATEGORIAS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
            .HasColumnName("IDCATEGORIA")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.Ativo)
            .HasColumnName("ATIVO")
            .IsRequired();

            builder.Property(x => x.Descricao)
            .HasColumnName("DESCRICAO")
            .HasMaxLength(250)
            .IsRequired()
            .HasColumnType("varchar(250)");

            builder.Property(x => x.Nome)
            .HasColumnName("NOME")
            .HasMaxLength(100)
            .IsRequired()
            .HasColumnType("varchar(100)");

            builder.Property(x => x.DataCadastro)
            .HasColumnName("DATACADASTRO")
            .IsRequired();

            builder.HasMany(x => x.Subcategorias)
            .WithOne(x => x.Categoria)
            .HasForeignKey(x => x.CodigoCategoria);

        }
                
    }
}