using Teacher;

Console.WriteLine("Hello, World!");
//I can creaet a object of teacher by constructor
Teacher.Teacher teacher1 = new Teacher.Teacher(1, "Abbas", "Math", 1);
teacher1.CalculateSalary();
//Naming Parameter 
teacher1.CalculateSalary(workHistoryYear: 7, mejor: "Chemestry");
Console.WriteLine($"Hey {teacher1.Name}, your salary is {teacher1.Salary}$");
Console.WriteLine($"The {Teacher.Teacher.SchoolName}School salary is {Teacher.Teacher.GetSchoolSalary()}");



int argNum1 = 0;
int argNum2 = 0;
int argNum3 = 0;
RefParameter(ref argNum1);
OutParameter(out argNum2);
InParameter(in argNum3);
int[] intArry = { 1, 2, 3, 4, 5, 6, 7 };
ParamsParameter(intArry);
Console.WriteLine(argNum1);
Console.WriteLine(argNum2);
Console.WriteLine(argNum3);
Console.ReadKey();




void RefParameter(ref int setNum)
{
    setNum = 10;
}


void OutParameter(out int setNum)
{
    //Console.WriteLine("setNum in Out: " + setNum);

    setNum = 10;
}
void InParameter(in int setNum/*readonly*/)
{
    //setNum = 10;//Error, can not change the prameter value  
}

void ParamsParameter(params int[] param)
{
    Console.WriteLine(param[0]);
}