using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands").HasKey(b=>b.Id);

        builder.Property(b=>b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

<<<<<<< HEAD
        // builder.HasIndex(indexExpression:b=>b.Name, name:"UK_Brands_Name").IsUnique(); 
        //
        // builder.HasMany(b=>b.Models);
=======
        builder.HasIndex(indexExpression:b=>b.Name, name:"UK_Brands_Name").IsUnique(); //marka ismi unique olmalı, tekrar edilmesin
        
        builder.HasMany(b=>b.Models); //bir markanın birden fazla modeli olabilir
>>>>>>> f8079a9 (Initial commit for MyCourses_RentACar)

        builder.HasQueryFilter(b=>!b.DeletedDate.HasValue); //global filtrelemeyi sağlar
    }
}