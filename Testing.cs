
using static System.Console;

namespace AbsClasses
{
    public partial class AbstractClasses
    {
        static void HumanClassesTest()
        {
            Builder builder = new Builder();
            builder.Enter();
            WriteLine(builder.ToString());
            Sailor sailor = new Sailor();
            sailor.Enter();
            WriteLine(sailor.ToString());
            Pilot pilot = new Pilot();
            pilot.Enter();
            WriteLine(pilot.ToString());
        }
        static void PassportClassesTest()
        {
            ForeignPassport passport = new ForeignPassport();
            passport.Enter();
            WriteLine(passport.ToString());
        }
        static void AnimalClassesTest()
        {
            Tiger tiger = new Tiger();
            tiger.Enter();
            WriteLine(tiger.ToString());
            Crocodile crocodile = new Crocodile();
            crocodile.Enter();
            WriteLine(crocodile.ToString());
            Kangaroo kangaroo = new Kangaroo();
            kangaroo.Enter();
            WriteLine(kangaroo.ToString());
        }
        static void ShapeClassesTest()
        {

        }
    }
}
