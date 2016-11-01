//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sequencing.WeatherApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    public partial class Recommendation
    {
        [Required]
        [Display(Name = "Genetically tailored forecast")]
        public string Forecast { get; set; }

        [Required]
        [Display(Name = "Weather forecast")]
        public long CondId { get; set; }

        [Required]
        [Display(Name = "Vitamin D result")]
        public long VitaminDId { get; set; }

        [Required]
        [Display(Name = "Melanoma risk result")]
        public long MelanomaRiskId { get; set; }

        [Required]
        public string Language { get; set; }
        public long GroupItemId { get; set; }
    
        public virtual Condition Condition { get; set; }
        public virtual MelanomaRisk MelanomaRisk { get; set; }
        public virtual VitaminD VitaminD { get; set; }
    }
}