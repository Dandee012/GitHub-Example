using static System.Console;

public class Program{

    static void Main(){

        HogwartStudent[] hogwartStudents =
            {


            new HogwartStudentDan(),
            new HogwartStudentNat(),


            new HogwartStudentNaan(),

            
            new HogwartStudentSam(),
            new HogwartStudentKhona(),


            };

        foreach(HogwartStudent s in hogwartStudents)
        {
            WriteLine(s);
        }
    }

}