//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MinistryOfLand.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class PromotionalParticular
    {
        public int PromotionalParticularId { get; set; }

        [Required(ErrorMessage = "Rank Required")]
        public string Rank { get; set; }

        [Required(ErrorMessage = "Enter Promotion")]
        public string Promotion { get; set; }

        [Required(ErrorMessage = "Enter GO date")]
        public Nullable<System.DateTime> GODate { get; set; }

        [Required(ErrorMessage = "Enter Nature of Promotion")]
        public string NaturalOfPromotion { get; set; }

        [Required(ErrorMessage = "Pay Scale Required")]
        public string PayScal { get; set; }

        [Required(ErrorMessage = "Muset be Select User Id")]
        public int userId { get; set; }
    
        public virtual UserAccount UserAccount { get; set; }
    }
}
