﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Data;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentContext))]
    [Migration("20200715211545_initialize")]
    partial class initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Hymn", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PageNumber");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Hymn");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calling");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int?>("SacramentMeetingID");

                    b.HasKey("ID");

                    b.HasIndex("SacramentMeetingID");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SacramentMeeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosingHymn")
                        .IsRequired();

                    b.Property<string>("ClosingPrayer")
                        .IsRequired();

                    b.Property<string>("ConductingBishopric")
                        .IsRequired();

                    b.Property<int?>("IntermediateHymn");

                    b.Property<string>("OpeningHymn")
                        .IsRequired();

                    b.Property<string>("OpeningPrayer")
                        .IsRequired();

                    b.Property<DateTime>("SacramentDate");

                    b.Property<string>("SacramentHymn")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("SacramentMeeting");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Member", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.SacramentMeeting")
                        .WithMany("Speaker")
                        .HasForeignKey("SacramentMeetingID");
                });
#pragma warning restore 612, 618
        }
    }
}