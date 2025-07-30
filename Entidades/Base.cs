using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISync.Classes
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime SysDInsert { get; set; }
        public DateTime  SysDUpdate { get; set; }
        public bool SysIsDeleted { get; set; }
    }
}
