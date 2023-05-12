﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StackOverFlowAnswer;

namespace StackOverFlowAnswer.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20230512170345_addclass")]
    partial class addclass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StackOverFlowAnswer.Mapped_Stations", b =>
                {
                    b.Property<int>("OriginId")
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.HasKey("OriginId", "DestinationId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Mapped_Stations");
                });

            modelBuilder.Entity("StackOverFlowAnswer.Station", b =>
                {
                    b.Property<int>("StationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("TerminalName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("StationId");

                    b.ToTable("stations");
                });

            modelBuilder.Entity("StackOverFlowAnswer.Mapped_Stations", b =>
                {
                    b.HasOne("StackOverFlowAnswer.Station", "Destination")
                        .WithMany("Destinations")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StackOverFlowAnswer.Station", "Origin")
                        .WithMany("Origins")
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");

                    b.Navigation("Origin");
                });

            modelBuilder.Entity("StackOverFlowAnswer.Station", b =>
                {
                    b.Navigation("Destinations");

                    b.Navigation("Origins");
                });
#pragma warning restore 612, 618
        }
    }
}
