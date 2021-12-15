﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NguyenCaoSang830.Data;

namespace NguyenCaoSang830.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211215062412_Create_Table_NCS0830")]
    partial class Create_Table_NCS0830
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("NguyenCaoSang830.Models.NCS0830", b =>
                {
                    b.Property<string>("NCSId")
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<bool>("NCSGender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NCSName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("NCSId");

                    b.ToTable("NCS0830s");
                });

            modelBuilder.Entity("NguyenCaoSang830.Models.UniversityNCS830", b =>
                {
                    b.Property<string>("UniversityId")
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("UniversityName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("UniversityId");

                    b.ToTable("UniversityNCS830");
                });
#pragma warning restore 612, 618
        }
    }
}
