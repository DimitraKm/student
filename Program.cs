namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student s1 = new student("Moris", 15, 7648, 5, 6, 4, 6, 5);
            student s2 = new student("Julian", 16, 8364, 4, 5, 6, 3, 6);
            student s3 = new student("Mort", 15, 3764, 3, 5, 6, 4, 3);
            student s4 = new student("Rico", 15, 2663, 4, 2, 5, 4, 6);
            student s5 = new student("Rednic", 16, 9438, 4, 6, 6, 2, 3);

            s1.print();
            s2.print();
            s3.print();
            s4.print();
            s5.print();

        }
    }
}