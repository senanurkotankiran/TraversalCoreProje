using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About2
    {
        [Key]
        public int About2ID { get; set; }
        public int Title1 { get; set; }
        public int Title2 { get; set; }
        public int Description { get; set; }
        public int Image { get; set; }
    }
}
