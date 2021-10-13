﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexModelBinding.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public Instructor Teacher { get; set; }
    }

    public class CourseCreateViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Instructor> AllAvailableInstructors { get; set; }

        public Instructor ChosenInstructor { get; set; }
    }
}
