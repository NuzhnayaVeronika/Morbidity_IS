using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public class DiseaseContext
        : DbContext
    {
        internal DbSet<Disease> Diseases { get; set; }

        public DiseaseContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}