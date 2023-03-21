using GiaBao_2011061513.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiaBao_2011061513.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}