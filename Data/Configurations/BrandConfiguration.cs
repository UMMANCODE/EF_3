﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations {
    public class BrandConfiguration : IEntityTypeConfiguration<Brand> {
        public void Configure(EntityTypeBuilder<Brand> builder) {
            // Same named brands cannot be added to the database
            builder.HasIndex(b => b.Name).IsUnique();
        }
    }
}
