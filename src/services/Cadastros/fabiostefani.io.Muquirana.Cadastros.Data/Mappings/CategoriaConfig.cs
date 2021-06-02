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
            .IsRequired();

            builder.Property(x => x.Ativo)
            .IsRequired();

            builder.Property(x => x.Descricao)
            .HasMaxLength(250)
            .IsRequired(true)
            .HasColumnType("varchar(250)");

            builder.Property(x => x.Nome)
            .HasMaxLength(100)
            .IsRequired(true)
            .HasColumnType("varchar(100)");

            builder.Property(x => x.DataCadastro)
            .IsRequired();
            
        }
    }
}