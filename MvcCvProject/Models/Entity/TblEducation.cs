

namespace MvcCvProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TblEducation
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Bu Alan Boþ Býrakýlamaz")]
        public string Title { get; set; }

        //[Required(ErrorMessage = "Bu Alan Boþ Býrakýlamaz")]
        public string SecondTitle { get; set; }

        //[Required(ErrorMessage = "Bu Alan Boþ Býrakýlamaz")]
        public string Description { get; set; }

        //[Required(ErrorMessage = "Bu Alan Boþ Býrakýlamaz")]
        public string SecondTitle2 { get; set; }

        //[StringLength(10,ErrorMessage ="Lütfen en fazla 10 karakterlik veri giriþi yapýn")]
        //[Required(ErrorMessage = "Bu Alan Boþ Býrakýlamaz")]

        public string TotalScore { get; set; }
        public string Date { get; set; }
    }
}
