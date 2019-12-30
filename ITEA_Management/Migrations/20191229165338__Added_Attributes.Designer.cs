﻿// <auto-generated />
using System;
using ITEA_Management.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITEA_Management.Migrations
{
    [DbContext(typeof(ITEA_Context))]
    [Migration("20191229165338__Added_Attributes")]
    partial class _Added_Attributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITEA_Management.Models.Course", b =>
                {
                    b.Property<int>("CourseId");

                    b.Property<int>("Hours");

                    b.Property<int>("Lessons");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ITEA_Management.Models.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasMaxLength(70);

                    b.HasKey("OfficeId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("ITEA_Management.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentCourseId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Mark");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CurrentCourseId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ITEA_Management.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("OfficeId");

                    b.Property<int?>("OfficeId1");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("OfficeId1");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ITEA_Management.Models.TeacherCourses", b =>
                {
                    b.Property<int>("CourseId");

                    b.Property<int>("TeacherId");

                    b.HasKey("CourseId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherCourses");
                });

            modelBuilder.Entity("ITEA_Management.Models.Student", b =>
                {
                    b.HasOne("ITEA_Management.Models.Course", "CurrentCourse")
                        .WithMany("CurrentStudents")
                        .HasForeignKey("CurrentCourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITEA_Management.Models.Teacher", b =>
                {
                    b.HasOne("ITEA_Management.Models.Office")
                        .WithMany("Teachers")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ITEA_Management.Models.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId1");
                });

            modelBuilder.Entity("ITEA_Management.Models.TeacherCourses", b =>
                {
                    b.HasOne("ITEA_Management.Models.Course", "Course")
                        .WithMany("TeacherCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ITEA_Management.Models.Teacher", "Teacher")
                        .WithMany("TeacherCourses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
