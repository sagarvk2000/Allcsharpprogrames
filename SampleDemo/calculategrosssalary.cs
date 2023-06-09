using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class calculate_gross_salary
    {
        static void Main(string[] args)
        {
            int basic_salary, emp_id, hra, da, ta, pt=200, pf, gs;
            string emp_name;
            Console.WriteLine("Enter the salary=");
            basic_salary= Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter the empolyee name=");
            emp_name= (Console.ReadLine());

            Console.WriteLine("Enter the employee id=");
            emp_id = Convert.ToInt32( Console.ReadLine());

            hra = (basic_salary / 100) * 40;
            Console.WriteLine($"Hra 40% of basic salary={hra}");

            da = (basic_salary / 100) * 10;
            Console.WriteLine($"da 10% of basic salary={da}");
            
           
            ta = (basic_salary / 100) * 20;
            Console.WriteLine($"ta 20% of basic salary={ta}");

            pf = (basic_salary / 100) * 12;
            Console.WriteLine($"pf 12% of basic salary={pf}");

            gs = (basic_salary + hra + da + ta) - (pf + pt);

            Console.WriteLine( $"Gross salary with allowance={gs}");


        }
    }
}
