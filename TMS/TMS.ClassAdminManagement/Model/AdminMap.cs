using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.ClassAdminManagement.Model
{
    public class AdminMap
    {
        public int ClassAdminId { get; set; }
        public ClassBatch ClassBatch { get; set; }

        public int ClassId { get; set; }
        public ClassAdmin ClassAdmin { get; set; }
    }
}
