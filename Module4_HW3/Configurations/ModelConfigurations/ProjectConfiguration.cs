﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4_HW3.Models;

namespace Module4_HW3.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project")
                .HasKey(x => x.ProjectId);

            builder.Property(x => x.ProjectId)
                .HasColumnName("ProjectId")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Budget)
                .HasColumnName("Budget")
                .HasColumnType("money")
                .IsRequired();

            builder.Property(x => x.StartedDate)
                .HasColumnName("StartedDate")
                .IsRequired();

            builder.HasMany(p => p.EmployeeProject)
            .WithOne(ep => ep.Project)
            .HasForeignKey(ep => ep.ProjectId);
        }
    }
}
