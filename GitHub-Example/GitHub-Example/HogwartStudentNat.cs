using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;




public class HogwartStudentNat : HogwartStudent

{
    public override string Name => "Nat";
    public HogwartStudentNat() : base(50, 50, House.Hufflepuff) { }
    protected override string CastSpell()
    {
        return "Crucio";
    }

    protected override string SayCatchPhrase()
    {
        return "Ashes to Ashes, Gold to Dust, Life is a Struggle, So dala what you must";
    }
}


