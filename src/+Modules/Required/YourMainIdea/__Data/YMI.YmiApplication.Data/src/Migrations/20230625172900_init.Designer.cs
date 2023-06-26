// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YMI.YmiInfrastructure.Data;

#nullable disable

namespace YMI.YmiApplication.Data.Migrations
{
    [DbContext(typeof(YmiDbContext))]
    [Migration("20230625172900_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<Guid>("AuthorsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BooksId")
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("LibraryId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LibraryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.BookCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BookCategoryId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookCategoryId");

                    b.HasIndex("BookId");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.BookCopy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Condition")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CopySequence")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("BookCopies");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Library", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.MemberInMembership", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MembershipId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("MembershipId");

                    b.ToTable("MemberInMemberships");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Membership", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MemberSince")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MembershipCardNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("MembershipTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("YMI.YmiCore.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YMI.YmiCore.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Author", b =>
                {
                    b.OwnsOne("YMI.YmiCore.Entities.NameVO", "Name", b1 =>
                        {
                            b1.Property<Guid>("AuthorId")
                                .HasColumnType("TEXT");

                            b1.HasKey("AuthorId");

                            b1.ToTable("Authors");

                            b1.WithOwner()
                                .HasForeignKey("AuthorId");
                        });

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Book", b =>
                {
                    b.HasOne("YMI.YmiCore.Entities.Library", null)
                        .WithMany("Books")
                        .HasForeignKey("LibraryId");

                    b.OwnsOne("YMI.YmiCore.Entities.IsbnVO", "Isbn", b1 =>
                        {
                            b1.Property<Guid>("BookId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Isbn")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("BookId");

                            b1.HasIndex("Isbn")
                                .IsUnique()
                                .HasDatabaseName("Index_Isbn")
                                .HasAnnotation("SqlServer:Clustered", false);

                            b1.ToTable("Books");

                            b1.WithOwner()
                                .HasForeignKey("BookId");
                        });

                    b.Navigation("Isbn")
                        .IsRequired();
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.BookCategory", b =>
                {
                    b.HasOne("YMI.YmiCore.Entities.BookCategory", null)
                        .WithMany("BookCategories")
                        .HasForeignKey("BookCategoryId");

                    b.HasOne("YMI.YmiCore.Entities.Book", null)
                        .WithMany("BookCategories")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.BookCopy", b =>
                {
                    b.HasOne("YMI.YmiCore.Entities.Book", "Book")
                        .WithMany("BookCopies")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Library", b =>
                {
                    b.OwnsOne("YMI.YmiCore.Entities.PhysicalAddressVO", "Address", b1 =>
                        {
                            b1.Property<Guid>("LibraryId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("StateProvince")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street1")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street2")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("LibraryId");

                            b1.ToTable("Libraries");

                            b1.WithOwner()
                                .HasForeignKey("LibraryId");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Member", b =>
                {
                    b.OwnsOne("YMI.YmiCore.Entities.PhysicalAddressVO", "Address", b1 =>
                        {
                            b1.Property<Guid>("MemberId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("StateProvince")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street1")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street2")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("MemberId");

                            b1.ToTable("Members");

                            b1.WithOwner()
                                .HasForeignKey("MemberId");
                        });

                    b.OwnsOne("YMI.YmiCore.Entities.DigitalAddressVO", "Email", b1 =>
                        {
                            b1.Property<Guid>("MemberId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<long>("PhoneNumber")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Type")
                                .HasColumnType("INTEGER");

                            b1.HasKey("MemberId");

                            b1.ToTable("Members");

                            b1.WithOwner()
                                .HasForeignKey("MemberId");
                        });

                    b.OwnsOne("YMI.YmiCore.Entities.NameVO", "Name", b1 =>
                        {
                            b1.Property<Guid>("MemberId")
                                .HasColumnType("TEXT");

                            b1.HasKey("MemberId");

                            b1.ToTable("Members");

                            b1.WithOwner()
                                .HasForeignKey("MemberId");
                        });

                    b.OwnsOne("YMI.YmiCore.Entities.DigitalAddressVO", "Phone", b1 =>
                        {
                            b1.Property<Guid>("MemberId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<long>("PhoneNumber")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Type")
                                .HasColumnType("INTEGER");

                            b1.HasKey("MemberId");

                            b1.ToTable("Members");

                            b1.WithOwner()
                                .HasForeignKey("MemberId");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Email");

                    b.Navigation("Name")
                        .IsRequired();

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.MemberInMembership", b =>
                {
                    b.HasOne("YMI.YmiCore.Entities.Member", "Member")
                        .WithMany("MemberInMemberships")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YMI.YmiCore.Entities.Membership", "Membership")
                        .WithMany("MemberInMemberships")
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Membership");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Book", b =>
                {
                    b.Navigation("BookCategories");

                    b.Navigation("BookCopies");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.BookCategory", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Library", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Member", b =>
                {
                    b.Navigation("MemberInMemberships");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Membership", b =>
                {
                    b.Navigation("MemberInMemberships");
                });
#pragma warning restore 612, 618
        }
    }
}
