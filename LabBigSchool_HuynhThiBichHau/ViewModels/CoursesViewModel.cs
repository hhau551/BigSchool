using LabBigSchool_HuynhThiBichHau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabBigSchool_HuynhThiBichHau.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}