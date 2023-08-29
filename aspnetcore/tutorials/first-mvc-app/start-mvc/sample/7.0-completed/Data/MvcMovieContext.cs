using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity("MvcMovie.Models.Movie", b =>
        //        {
        //            b.Property<int>("Id")
        //                .ValueGeneratedOnAdd()
        //                .HasColumnType("int");

        //            b.HasKey("Id");

        //            b.ToTable("Movie");
        //        });
        //}
    }
}
