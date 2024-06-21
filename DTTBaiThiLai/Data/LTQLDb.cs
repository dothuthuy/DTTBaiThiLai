using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DTTBaiThiLai.Models;

    public class LTQLDb : DbContext
    {
        public LTQLDb (DbContextOptions<LTQLDb> options)
            : base(options)
        {
        }

        public DbSet<DTTBaiThiLai.Models.DTT893> DTT893 { get; set; } = default!;
    }
