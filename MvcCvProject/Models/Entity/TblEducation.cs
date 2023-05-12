

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

        //[Required(ErrorMessage = "Bu Alan Bo� B�rak�lamaz")]
        public string SecondTitle { get; set; }

        //[Required(ErrorMessage = "Bu Alan Bo� B�rak�lamaz")]
        public string Description { get; set; }

        //[Required(ErrorMessage = "Bu Alan Bo� B�rak�lamaz")]
        public string SecondTitle2 { get; set; }

        //[StringLength(10,ErrorMessage ="L�tfen en fazla 10 karakterlik veri giri�i yap�n")]
        //[Required(ErrorMessage = "Bu Alan Bo� B�rak�lamaz")]

        public string TotalScore { get; set; }
        public string Date { get; set; }
    }
}
