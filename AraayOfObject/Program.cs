namespace AraayOfObject
{
    public class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("How many students data you have to store:");
            int len=Convert.ToInt32(Console.ReadLine());

            Student[] stdArray=new Student[len];

            for(int i=0; i<len; i++)
            {
                stdArray[i]=new Student();  
                stdArray[i].setData();
            }
            Student.ParcentageChaker( stdArray, len);
            //for (int i=0; i<len;i++) 
            //{
            //    stdArray[i].printData();
            //}
        }
    }


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
        public DateTime dob { get; set; }

        public void printData()
        {
            Console.WriteLine("===========Student Data========================");
            Console.WriteLine("Id: "+Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Percentage: " + Percentage);
            Console.WriteLine("dob: " + dob.ToString("dd/MMM/yyyy"));
            Console.WriteLine("================================================");

        }

        public void setData()
        {
            Console.WriteLine("===========Set Student Data========================");
            Console.WriteLine("Enter Id: ");
            Id=Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Percentage: ");
            Percentage = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Enter Date Of Birth: ");
            dob = Convert.ToDateTime(Console.ReadLine());


        }
        public static void ParcentageChaker(Student [] stdArray,int len)
        {
            Console.WriteLine("enter percnetage you want to chek");
           double  Percesentage1=Convert.ToDouble( Console.ReadLine());

            for (int i = 0; i < len; i++) 
            {
                if (stdArray[i].Percentage>Percesentage1)
                {
                    stdArray[i].printData();
                }
                
            }
        }


    }
}
