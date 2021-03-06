// <auto-generated />
using AcctReview;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace gcp_demo.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    [Migration("20210427033830_Modify-Patent-Name-Nvarchar")]
    partial class ModifyPatentNameNvarchar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("gcp_demo.Entities.Patent", b =>
                {
                    b.Property<string>("CaseId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(500)");

                    b.HasKey("CaseId");

                    b.ToTable("patent");
                });
#pragma warning restore 612, 618
        }
    }
}
