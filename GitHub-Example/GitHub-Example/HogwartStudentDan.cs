﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



    
        public class HogwartStudentDan : HogwartStudent
        {
            public HogwartStudentDan() : base(1, 1, House.Hufflepuff) { }
        protected override string CastSpell()
        {
            return "Kachow";  
        }

        protected override string SayCatchPhrase()
        {
            return "Why tho?";
        }
    }
    
