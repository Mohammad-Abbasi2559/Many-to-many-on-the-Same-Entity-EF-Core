using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowAnswer
{
    public class Mapped_SatationsMap : IEntityTypeConfiguration<Mapped_Stations>
    {
        public void Configure(EntityTypeBuilder<Mapped_Stations> builder)
        {
            builder.HasKey(t => new { t.OriginId, t.DestinationId });
            builder
                .HasOne(t => t.Origin)
                .WithMany(p => p.Origins)
                .HasForeignKey(f => f.OriginId);
            builder
                .HasOne(t => t.Destination)
                .WithMany(p => p.Destinations)
                .HasForeignKey(f => f.DestinationId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
