using System;

namespace Aula37E_Players___Parte_1___Models.Models
{
    public class Partida
    {
        public int IdPartida { get; set; }
        public int IdEquipe1 { get; set; }
        public int IdEquipe2 { get; set; }
        public DateTime Horario { get; set; }
    }
}