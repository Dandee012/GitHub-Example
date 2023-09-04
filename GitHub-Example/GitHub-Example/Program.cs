using static System.Console;

public class Program{

    static void Main(){

        HogwartStudent[] hogwartStudents =
            {

            new HogwartStudentDan()

            };

        foreach(HogwartStudent s in hogwartStudents)
        {
            WriteLine(s);
        }
    }

}