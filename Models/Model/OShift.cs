﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("OShift")]
    public class OShift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string IDOrganization { get; set; }
        [Required]
        public string ShiftName { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime ShiftStartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime ShiftEndTime { get; set; }

        [ForeignKey("IDOrganization")]
        public virtual Organization Organization { get; set; }
    }
}
