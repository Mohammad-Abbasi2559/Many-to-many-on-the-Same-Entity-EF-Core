# Many-to-many-on-the-Same-Entity-EF-Core

## For this you need first creat a class

```
public class Station
    {

        [Key]
        public int StationId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string TerminalName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Province { get; set; }

        //Add This two Lists create many to many
        public List<Mapped_Stations> Origins { get; set; }
        public List<Mapped_Stations> Destinations { get; set; }
    }
}
```
## Add the mapped class

```
public class Mapped_Stations
    {
        public int OriginId { get; set; }

        public int DestinationId { get; set; }

        public Station Origin { get; set; }

        public Station Destination { get; set; }
    }
```

## Add a folder with name mapping and create mapping class
### use IEntityTypeConfiguration interface
```
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
```
## Configure DbContext with override OnModelCreating
```
 public class Db:DbContext
    {
        public Db() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(local);Database=Many-to-many;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Mapped_SatationsMap());
        }

        DbSet<Mapped_Stations> Mapped_Stations { get; set; }
        DbSet<Station> stations { get; set; }
    }
```
## Please Read LICENSE
