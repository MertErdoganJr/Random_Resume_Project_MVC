//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCvProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TblEducation
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Bu Alan Bo� B�rak�lamaz")]
        public string Title { get; set; }
        public string SecondTitle { get; set; }

        [Required(ErrorMessage = "Bu Alan Bo� B�rak�lamaz")]
        public string Description { get; set; }
        public string SecondTitle2 { get; set; }
        public string TotalScore { get; set; }
        public string Date { get; set; }
    }
}
