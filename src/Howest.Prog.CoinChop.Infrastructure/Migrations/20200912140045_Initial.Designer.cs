﻿// <auto-generated />
using Howest.Prog.CoinChop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Howest.Prog.CoinChop.Infrastructure.Migrations
{
    [DbContext(typeof(CoinChopDataContext))]
    [Migration("20200912140045_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Howest.Prog.CoinChop.Core.Entities.Expense", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(19,4)");

                    b.Property<long>("ContributorId");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.HasIndex("ContributorId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new { Id = 1L, Amount = 20.0m, ContributorId = 2L, Description = "Tickets mom and dad" },
                        new { Id = 2L, Amount = 30.0m, ContributorId = 5L, Description = "Tickets for myself, bro and sis" },
                        new { Id = 3L, Amount = 20.0m, ContributorId = 1L, Description = "Lunch" },
                        new { Id = 4L, Amount = 10.0m, ContributorId = 5L, Description = "Ice cream" },
                        new { Id = 5L, Amount = 10.0m, ContributorId = 3L, Description = "Waffles and coffee" },
                        new { Id = 6L, Amount = 5.0m, ContributorId = 4L, Description = "Souvenir photo" },
                        new { Id = 7L, Amount = 200.0m, ContributorId = 7L, Description = "Cannonballs" },
                        new { Id = 8L, Amount = 40.0m, ContributorId = 8L, Description = "Mizzen-mast rigging ropes" },
                        new { Id = 9L, Amount = 75.0m, ContributorId = 9L, Description = "Heavy loot chest" },
                        new { Id = 10L, Amount = 60.0m, ContributorId = 7L, Description = "Gunpowder" }
                    );
                });

            modelBuilder.Entity("Howest.Prog.CoinChop.Core.Entities.ExpenseGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("ExpenseGroups");

                    b.HasData(
                        new { Id = 1L, Name = "Friends funpark", Token = "friendsfunpark" },
                        new { Id = 2L, Name = "Raiding supplies", Token = "privateers" }
                    );
                });

            modelBuilder.Entity("Howest.Prog.CoinChop.Core.Entities.Member", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<long>("GroupId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Members");

                    b.HasData(
                        new { Id = 1L, Email = "rachel@friends.example.com", GroupId = 1L, Name = "Rachel" },
                        new { Id = 2L, Email = "monica@friends.example.com", GroupId = 1L, Name = "Monica" },
                        new { Id = 3L, Email = "chandler@friends.example.com", GroupId = 1L, Name = "Chandler" },
                        new { Id = 4L, Email = "joey@friends.example.com", GroupId = 1L, Name = "Joey" },
                        new { Id = 5L, Email = "ross@friends.example.com", GroupId = 1L, Name = "Ross" },
                        new { Id = 6L, Email = "jan@kapers.example.com", GroupId = 2L, Name = "Jan" },
                        new { Id = 7L, Email = "pieredebeeste@kapers.example.com", GroupId = 2L, Name = "Pier" },
                        new { Id = 8L, Email = "tjoris@kapers.example.com", GroupId = 2L, Name = "Tjoris" },
                        new { Id = 9L, Email = "corneel@kapers.example.com", GroupId = 2L, Name = "Corneel" }
                    );
                });

            modelBuilder.Entity("Howest.Prog.CoinChop.Core.Entities.Expense", b =>
                {
                    b.HasOne("Howest.Prog.CoinChop.Core.Entities.Member", "Contributor")
                        .WithMany("Contributions")
                        .HasForeignKey("ContributorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Howest.Prog.CoinChop.Core.Entities.Member", b =>
                {
                    b.HasOne("Howest.Prog.CoinChop.Core.Entities.ExpenseGroup", "Group")
                        .WithMany("Members")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
