using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class student
    {

        public string name; 
        public int age; 
        public int id;
        public int grade_math;
        public int grade_charms;
        public int grade_potions;
        public int grade_astronomy;
        public int grade_herbology;
        

        public student(string name, int age, int id, int grade_math, int grade_charms, 
            int grade_potions, int grade_astronomy, int grade_herbology)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.grade_math = grade_math;
            this.grade_charms = grade_charms;
            this.grade_potions = grade_potions;
            this.grade_astronomy = grade_astronomy;
            this.grade_herbology = grade_herbology;

            int result = (grade_math + grade_charms + grade_potions + grade_astronomy + grade_herbology) / 5;

            
        }
        public void print()
        {
            int result = (grade_math + grade_charms + grade_potions + grade_astronomy + grade_herbology) / 5;
            Console.WriteLine(name + " " + result);
            Console.WriteLine(name + " " + result).;
        }
        

    }
}
