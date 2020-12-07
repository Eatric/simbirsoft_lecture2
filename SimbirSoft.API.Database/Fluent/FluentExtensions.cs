using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimbirSoft.API.Database.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimbirSoft.API.Database.Fluent
{

    public static class FluentExtentions
    {   
        public static void BaseEntityWithLinksConfig<T, T1, T2>(this EntityTypeBuilder<T> builder,
                                                           Expression<Func<T1, IEnumerable<T>>> withMany1 = default,
                                                           Expression<Func<T2, IEnumerable<T>>> withMany2 = default)
                      where T : BaseEntityWithLinks<T1, T2>
                      where T1 : BaseEntity
                      where T2 : BaseEntity
        {
            builder.ToTable($"{typeof(T).Name}");

            builder.HasKey(e => new { e.Entity1Id, e.Entity2Id });

            builder.Property(e => e.Entity1Id)
                   .HasColumnName($"Id{typeof(T1).Name}");
            builder.Property(e => e.Entity2Id)
                   .HasColumnName($"Id{typeof(T2).Name}");

            builder.HasOne(e => e.Entity1)
                   .WithMany(withMany1)
                   .HasForeignKey(e => e.Entity1Id);

            builder.HasOne(e => e.Entity2)
                   .WithMany(withMany2)
                   .HasForeignKey(e => e.Entity2Id);
        }
    }
}
