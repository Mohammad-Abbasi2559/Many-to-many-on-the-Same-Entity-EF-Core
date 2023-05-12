using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowAnswer
{
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

        //Add This Lists
        public List<Mapped_Stations> Origins { get; set; }
        public List<Mapped_Stations> Destinations { get; set; }
    }
}
