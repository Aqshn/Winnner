using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qaa
{
    public class Category
    {
        [Key]
        [StringLength(15)]
        public string Name { get; set; }
    }
}
