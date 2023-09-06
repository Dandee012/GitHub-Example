using static System.Console;

public class Program{

    static void Main(){

        HogwartStudent[] hogwartStudents =
            {


            new HogwartStudentNaan(),

            new HogwartStudentDan(),
            new HogwartStudentSam(),
            new HogwartStudentKhona(),

            };

        foreach(HogwartStudent s in hogwartStudents)
        {
            WriteLine(s);
        }
    }

}