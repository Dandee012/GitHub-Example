using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        public class HogwartStudentNaan : HogwartStudent
        {
    public override string Name => "TopNaanBread";
    public HogwartStudentNaan() : base(44, 7, House.Hufflepuff) { }
            protected override string CastSpell()
            {
                return "Henk Please Help";
            }

            protected override string SayCatchPhrase()
            {
                return "Raees come here plz im dying i need aid with my IQ.";
            }
        }
