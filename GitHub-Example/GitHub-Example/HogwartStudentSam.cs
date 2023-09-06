using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;




public class HogwartStudentSam : HogwartStudent
{
    public override string Name => "Sam";
    public HogwartStudentSam() : base(100, 100, House.Hufflepuff) { }
    protected override string CastSpell()
    {
        return "bruh...";
    }

    protected override string SayCatchPhrase()
    {
        return "LETS GOOOOOOO";
    }
}


