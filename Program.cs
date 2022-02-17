using System;
using System.Collections.Generic;
using sistema_empresa.Entities;
using System.Globalization;

namespace sistema_empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(); //isntanceia e inicia a lista

            Console.Write("Insira numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"insira informações sobre o funcionario {i}");
                Console.WriteLine("terceirizado? (s/n)");
                char sn = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hora: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value por hora: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(sn == 's')
                {
                    Console.WriteLine("Despesa adicional: ");
                    double addcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsrcEmployee(addcharge, name, hours, valueperhour));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueperhour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Folha de pagamento: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }



        }
    }
}
