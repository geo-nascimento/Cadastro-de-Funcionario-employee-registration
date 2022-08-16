using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Funcionários.Entities
{
    internal class Department
    {
        //Atributo da classe
        public string Name { get; set; }

        //Sobrecarga de construtores
        public Department ()
        {

        }
        public Department (string name)
        {
            Name = name;
        }
    }
}
