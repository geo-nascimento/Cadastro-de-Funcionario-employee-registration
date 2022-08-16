using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Cadastro_de_Funcionários.Entities.Enums;


namespace Cadastro_de_Funcionários.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } /*Criei a propriedade department para associar a classe departamento com
                                                    com a classe worker*/
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); 
            /*Um funcionário pode ter vários contratos, então é conveniente
              associar a classe HourContract a classe worker por meio de uma
              propriedade do tipo lista, que recberá os diversos contratos
              cadastrados*/
       
        //Sobrecarga de construtores
        public Worker()
        {
           
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //métodos
        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum = sum + contract.TotalValue();
                }
                    
            }
            return sum;
        }


    }
}
