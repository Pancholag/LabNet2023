using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class CategoriesViewModel
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}