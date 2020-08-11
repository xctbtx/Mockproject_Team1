using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TMS.ClassAdminManagement.Model
{
    public class Trainer
    {
        [MaxLength(10)]
        public int TrainerId { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Account { get; set; }


        [MaxLength(10)]
        public int Stautus { get; set; }

        public string Type { get; set; }

        public string Unit { get; set; }
        public string Major { get; set; }

        public int Experience { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }
        public string AuditTrail { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<ClassBatch> ClassBatches { get; set; }
    }
}
