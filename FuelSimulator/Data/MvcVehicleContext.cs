using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FuelSimulator.Models;

namespace MvcVehicle.Data
{
    public class MvcVehicleContext : DbContext
    {
        public MvcVehicleContext (DbContextOptions<MvcVehicleContext> options)
            : base(options)
        {
        }

        public DbSet<FuelSimulator.Models.VehicleModel> VehicleModel { get; set; } = default!;
    }
}
