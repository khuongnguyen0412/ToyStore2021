﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToyStore.Models
{
    [Table("QA")]
    public class QA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public int ProductID { set; get; }
        public int MemberID { set; get; }
        public int EmloyeeID { set; get; }
        [MaxLength(1000)]
        public string Question { set; get; }
        [MaxLength(1000)]
        public string Answer { set; get; }
        public bool Status { get; set; }
        public DateTime DateQuestion { get; set; }
        public DateTime DateAnswer { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
        [ForeignKey("MemberID")]
        public virtual Member Member { set; get; }
        [ForeignKey("EmloyeeID")]
        public virtual Emloyee Emloyee { set; get; }
    }
}