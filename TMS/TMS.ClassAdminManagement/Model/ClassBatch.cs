using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS.ClassAdminManagement.Model
{
    public class ClassBatch
    {
        public int ClassId { get; set; }

        [StringLength(50)]
        public string ClassCode { get; set; }

        [StringLength(50)]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(255)]
        public string DetailLocation { get; set; }
        [ForeignKey("ClassAdminId")]
        public int ClassAdminId { get; set; }

        [ForeignKey("TrainerId")]
        public int TrainerId { get; set; }
        public ICollection<ClassAdmin> ClassAdmins { get; set; }
        public ICollection<Trainer> Trainers { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }
    }
}
