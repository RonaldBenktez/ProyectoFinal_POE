﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Subjects
    {
        public int SubjectId { get; set; }        
        public string SubjectName { get; set; }   
        public int SectionId { get; set; }          
        public int Year { get; set; }
    }
}
