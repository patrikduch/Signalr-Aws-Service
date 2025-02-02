﻿using Microsoft.EntityFrameworkCore;
using SignalRAwsService.Models;
using SignalRAwsService.Models.ModelsConfiguration;

namespace SignalRAwsService.Contexts
{
    /// <summary>
    /// DB context for managing project detail details.
    /// </summary>
    public class ProjectDetailContext : DbContext
    {
        public ProjectDetailContext(DbContextOptions<ProjectDetailContext> options) : base(options)
        {

        }

        /// <summary>
        /// Configuration setup for ProjectDetail DB context.
        /// </summary>
        /// <param name="builder">Modelbuilder instance that is used for additional Model configuration.</param>
        protected override void OnModelCreating(ModelBuilder builder){

            // Addd the Postgres Extension for UUID generation
            builder.HasPostgresExtension("uuid-ossp");

            builder.ApplyConfiguration(new ProjectDetailConfiguration());    
        }

        public DbSet<ProjectDetail> ProjectDetail { get; set;}
    }
}
