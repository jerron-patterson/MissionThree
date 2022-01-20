using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MissionThree.Models
{
    public class gradeCalModel
    {
        [Required]
        [Range(0,100)]
        public float assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public float groupProjects { get; set; }
        [Required]
        [Range(0, 100)]
        public float quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public float exams { get; set; }
        [Required]
        [Range(0, 100)]
        public float intex { get; set; }
    }
}
