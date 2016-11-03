using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jQuery_CRUD.DAL
{
    public class User
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter Your Contact No")]
        public string ContactNo { get; set; }
    }
}