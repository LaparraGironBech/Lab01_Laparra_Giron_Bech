using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab1_Giron_Laparra_Bech.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Posicion { get; set; }
        public decimal salario { get; set; }
    }
}
