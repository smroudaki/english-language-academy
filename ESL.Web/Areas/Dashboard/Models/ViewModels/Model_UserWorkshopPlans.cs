using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ESL.Web.Areas.Dashboard.Models.ViewModels
{
    public class Model_UserWorkshopPlans
    {
        [Display(Name = "شناسه")]
        public int ID { get; set; }

        [Display(Name = "کاربر")]
        public string User { get; set; }

        [Display(Name = "کارگاه")]
        public string Workshop { get; set; }

        [Display(Name = "عنوان")]
        public string SubWorkshop { get; set; }

        [Display(Name = "مکان برگزاری")]
        public string Location { get; set; }

        [Display(Name = "تاریخ و زمان برگزاری")]
        public DateTime Date { get; set; }

        [Display(Name = "قیمت (تومان)")]
        public int Cost { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime CreationDate { get; set; }
    }
}