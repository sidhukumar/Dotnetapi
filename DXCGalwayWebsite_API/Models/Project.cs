using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXCGalwayWebsite_API.Models
{
    public class Project: BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Images { get; set; }
        public string Logos { get; set; }
        public string Users { get; set; }
    }
}
