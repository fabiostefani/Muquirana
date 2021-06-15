using fabiostefani.io.Muquirana.Cadastros.Domain.Categorias.Subcategorias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fabiostefani.io.Muquirana.Cadastros.Data.Mappings
{
    public class SubcategoriaConfig : IEntityTypeConfiguration<Subcategoria>
    {
        public void Configure(EntityTypeBuilder<Subcategoria> builder)
        {
            builder.ToTable("SUBCATEGORIA");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
            .HasColumnName("IDSUBCATEGORIA")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.Nome)
            .HasColumnName("NOME")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.Ativo)
            .HasColumnName("ATIVO")
            .IsRequired();

            builder.Property(x => x.CodigoCategoria)
            .HasColumnName("IDCATEGORIA")
            .IsRequired()
            .HasMaxLength(100);

            builder.HasOne(c => c.Categoria)
                .WithMany(c => c.Subcategorias);

        }
    }
}