using System;
using System.ComponentModel.DataAnnotations;

namespace TMS.ClassAdminManagement.Model
{
    public class ClassAdmin
    {
        
        public int ClassAdminId { get; set; }
        
        [StringLength(255)]
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Account { get; set; }

        
        public int Status { get; set; }
        public string AuditTrail { get; set; }
        public bool IsDeleted { get; set; }
    }
}
