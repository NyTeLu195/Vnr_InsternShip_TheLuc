using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vnr_InsternShip_TheLuc.Models;

    public class Vnr_InsternShip_TheLucContext : DbContext
    {
        public Vnr_InsternShip_TheLucContext (DbContextOptions<Vnr_InsternShip_TheLucContext> options)
            : base(options)
        {
        }

        public DbSet<KhoaHoc> KhoaHoc { get; set; }

        public DbSet<MonHoc> MonHoc { get; set; }
    }
