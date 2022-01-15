using System;
//Added these "usings" manually
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2.Models
{
    public class GradeCalcModel
    {
        //[Required]
        [Range(0,100, ErrorMessage = "Assignments grade must be between 0 to 100")]
        public int Assignments { get; set; }

        [Range(0, 100, ErrorMessage = "Group Projects grade must be between 0 to 100")]
        public int GroupProjects { get; set; }

        [Range(0, 100, ErrorMessage = "Quizzes grade must be between 0 to 100")]
        public int Quizzes { get; set; }

        [Range(0, 100, ErrorMessage = "Exams grade must be between 0 to 100")]
        public int Exams { get; set; }

        [Range(0, 100, ErrorMessage = "INTEX grade must be between 0 to 100")]
        public int INTEX { get; set; }
    }
}