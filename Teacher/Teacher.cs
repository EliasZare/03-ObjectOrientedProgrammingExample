namespace Teacher
{
    public class Teacher
    {
        //Instance fields 
        public int Id { get; set; }
        public string Name { get; set; }
        //Readonly fields
        public readonly int WorkHistoryYear;
        public string Mejor { get; set; }
        public double Salary { get; set; }
        //Static fields
        public static string SchoolName { get; set; }
        //Constent fields
        public const double BaseSalary = 10000;



        public Teacher(long id, string name, string mejor)
        {
            this.Id = Id;
            this.Name = name;
            this.Mejor = mejor;

        }
        public Teacher(long id, string name, string mejor, int workHistoryYear)
        {
            //this keyword
            this.Id = Id;
            this.Name = name;
            this.Mejor = mejor;
            this.WorkHistoryYear = workHistoryYear;
        }
        //Constructor Overloading
        public Teacher(long id, string name, string mejor, string schoolName)
        {
            this.Id = Id;
            this.Name = name;
            this.Mejor = mejor;
        }
        //Static Constructor
        static Teacher()
        {
            SchoolName = "NamAvar";
        }


        public void CalculateSalary()
        {
            double salary = 0.0;

            double cal = (BaseSalary * this.WorkHistoryYear) / 100;
            salary = BaseSalary + cal;

            switch (this.Mejor)
            {
                case "Math":
                    salary = salary * 4;
                    break;
                case "Physics":
                    salary = salary * 3;
                    break;
                case "Chemestry":
                    salary = salary * 2;
                    break;
            }
            this.Salary = salary;
        }
        //Method Overloading
        public double CalculateSalary(int workHistoryYear, string mejor)
        {
            double salary = 0.0;

            double cal = (BaseSalary * workHistoryYear) / 100;
            salary = BaseSalary + cal;

            switch (mejor)
            {
                case "Math":
                    salary = salary * 4;
                    break;
                case "Physics":
                    salary = salary * 3;
                    break;
                case "Chemestry":
                    salary = salary * 2;
                    break;
            }
            return salary;
        }
        //Static Method
        public static string GetSchoolSalary()
        {
            double length = SchoolName.Length;
            //Local fanction
            double CalculateSalary(double length,double baseSalary)
            {
               return  BaseSalary * length;
            }
            return CalculateSalary(length, BaseSalary).ToString();
        }
    }
}