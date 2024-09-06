using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Reserva
    {
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Quartos {  get; set; }

        public Reserva(DateTime dataCheckin, DateTime dataCheckOut, int quartos)
        {
            DataCheckIn = dataCheckin;
            DataCheckOut = dataCheckOut;
            Quartos = quartos;
        }
    }
}
