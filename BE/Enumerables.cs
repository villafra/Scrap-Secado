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
            Extrusora_1 =1,
            [EnumMember(Value = "Extrusora 2")]
            Extrusora_2 =2,
            [EnumMember(Value = "Extrusora 3")]
            Extrusora_3 =3,
        }
        public enum Turno
        {
            Azul, 
            Rojo,
            Verde
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
            P1=1,
            P2=2,
            P3=3,
            P4=4,
            P5=5,
            P6=6,
            P7=7,
            P8=8,
            P9=9,
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
