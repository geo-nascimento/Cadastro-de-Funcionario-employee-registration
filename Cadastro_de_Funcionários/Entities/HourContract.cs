using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cadastro_de_Funcionários.Entities
{
    internal class HourContract
    {   
        //Atributos da classe
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        
        //Sobrecarga de construtores
        public HourContract ()
        {

        }

        public HourContract (DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //método de instância
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

    }
}
