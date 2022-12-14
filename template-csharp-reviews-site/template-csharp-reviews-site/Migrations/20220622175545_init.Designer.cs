// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using template_csharp_reviews_site;

#nullable disable

namespace template_csharp_reviews_site.Migrations
{
    [DbContext(typeof(SupplyContext))]
    [Migration("20220622175545_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("template_csharp_reviews_site.Models.SchoolSupply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SchoolSupplies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ticonderoga Pencil"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bic Pen"
                        },
                        new
                        {
                            Id = 3,
                            Name = "5 star"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Texas Insturment"
                        },
                        new
                        {
                            Id = 5,
                            Name = "LL Bean"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
