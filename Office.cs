using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Tracking_with_Entity_Framework
{
    internal class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Currency {  get; set; }
        public float ConversionRate { get; set; }
    }
}
