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
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string Email { get; set; }

        [MaxLength(10)]
        public int Stautus { get; set; }
        [StringLength(255)]
        public string Remarks { get; set; }
        public virtual ICollection<ClassBatch> ClassBatches { get; set; }
    }
}
