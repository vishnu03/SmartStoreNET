﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using SmartStore.Core;

namespace SmartStore.Rules.Domain
{
    public partial class RuleEntity // : BaseEntity
    {
        [Required]
        public int RuleSetId { get; set; }

        [ForeignKey("RuleSetId")]
        public virtual RuleSet RuleSet { get; set; }

        [DataMember]
        [Required, StringLength(100)]
        [Index("IX_PageBuilder_RuleType")]
        public string RuleType { get; set; }

        //[DataMember]
        //[StringLength(400)]
        //public string Member { get; set; }

        [DataMember]
        [Required, StringLength(10)]
        public string Operator { get; set; }

        [DataMember]
        [StringLength(400)]
        public string Value { get; set; }

        //[DataMember]
        //[StringLength(400)]
        //public string UpperValue { get; set; }

        [DataMember]
        [Index("IX_PageBuilder_DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}