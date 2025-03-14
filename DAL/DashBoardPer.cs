﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("DashBoardMst")]
    public class DashBoardPer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Role Role { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        [NotMapped]
        public int? RoleId { get; set; }
    }
}
