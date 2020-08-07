using System;
using System.ComponentModel.DataAnnotations;

namespace TMS.ClassAdminManagement.Model
{
    public class ClassAdmin
    {
        [MaxLength(10)]
        public int ClassAdminId { get; set; }
        
        [StringLength(255)]
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
        [MaxLength(10)]
        public int Status { get; set; }
        [StringLength(255)]
        public string Remarks { get; set; }
    }
}
