using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class AutomatOrderEntity
    {
        public int Id { get; set; }
        public int AutomatId { get; set; }
        public int DrinkId { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
