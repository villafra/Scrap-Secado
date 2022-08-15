using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Enumerables
    {
        public enum Extrusora
        {
            [EnumMember(Value = "Extrusora 1")]
            Extrusora_1 = 1,
            [EnumMember(Value = "Extrusora 2")]
            Extrusora_2 = 2,
            [EnumMember(Value = "Extrusora 3")]
            Extrusora_3 = 3,
        }
        public enum Equipo
        {
            Azul, 
            Rojo,
            Verde
        }
        public enum Turno
        {
            Mañana,
            Tarde,
            Noche
        }
        public enum Familia
        {
            Pedigree,
            Whiskas,
            Eukanuba,
            Iams,
            Optimum,
            Champ,
            [EnumMember(Value = "Royal Canin")]
            Royal_Canin,

        }
        public enum Periodo
        {
            P01=1,
            P02=2,
            P03=3,
            P04=4,
            P05=5,
            P06=6,
            P07=7,
            P08=8,
            P09=9,
            P10=10,
            P11=11,
            P12=12,
            P13=13
        }
        public enum Semana
        {
            W1=1,
            W2=2,
            W3=3,
            W4=4
        }
    }
}
