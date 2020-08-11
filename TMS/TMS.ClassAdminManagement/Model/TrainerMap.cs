using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.ClassAdminManagement.Model
{
    public class TrainerMap
    {
        public int TrainerId { get; set; }
        public ClassBatch ClassBatch { get; set; }

        public int ClassId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
