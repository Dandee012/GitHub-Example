using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class HogwartStudentKhona : HogwartStudent
{
    public override string Name => "Quinn";
    public HogwartStudentKhona() : base(127, 127, House.Hufflepuff) { }
    protected override string CastSpell()
    {
        return "One sec I'm setting this nun on fire";
    }

    protected override string SayCatchPhrase()
    {
        return "Bibbidi Bobbidi, your kneecaps are now my priority";
    }
}

