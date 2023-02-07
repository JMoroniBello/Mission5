using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5.Models
{
    public class gradeModel
    {
        //Validation 
        [Range(1,100,ErrorMessage ="Enter a score between 1 and 100 for assignments")]
        public int asg { get; set; }
        [Range(1, 100, ErrorMessage = "Enter a score between 1 and 100 for group projects")]
        public int group { get; set; }
        [Range(1, 100, ErrorMessage = "Enter a score between 1 and 100 for quizes")]
        public int quiz { get; set; }
        [Range(1, 100, ErrorMessage = "Enter a score between 1 and 100 for midterm")]
        public int mt { get; set; }
        [Range(1, 100, ErrorMessage = "Enter a score between 1 and 100 for final")]
        public int fn { get; set; }
        [Range(1, 100, ErrorMessage = "Enter a score between 1 and 100 for intex")]
        public int itx { get; set; }

    }
}
