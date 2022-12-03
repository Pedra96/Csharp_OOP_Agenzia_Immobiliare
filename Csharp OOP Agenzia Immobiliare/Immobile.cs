using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare {
    public class Immobile {
        private string CodiceAlfanumerico;
        private string indirizzo;
        private uint cap;
        private string citta;
        private uint mq;


        public Immobile(string indirizzo,uint cap,string citta,uint mq) {
            CodiceAlfanumerico = SetCodiceAlfanumerico();
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.citta = citta;
            this.mq = mq;
        }

        private string SetCodiceAlfanumerico() {
            string caratteri = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] CaratteriArray = new char[8];
            Random random = new();

            for (int i = 0; i < CaratteriArray.Length; i++) {
                CaratteriArray[i] = caratteri[random.Next(caratteri.Length)];
            }

            string CodiceAlfanumerico = new string(CaratteriArray);
            return CodiceAlfanumerico;
        }

        public string GetCodiceAlfanumerico() {
            return CodiceAlfanumerico;
        }

        public string GetIndirizzo() {
            return indirizzo;
        }

        public uint GetCap() {
            return cap;
        }

        public string GetCitta() {
            return citta;
        }

        public uint GetMq() {
            return mq;
        }

        public override string ToString() {
            string message = $"Codice dell abitazione: {CodiceAlfanumerico}\nIndirizzo: {indirizzo}\nCittà: {citta}\n" +
                $"Cap: {cap}\nSuperfice: {mq} m2";
            return message;
        }
        public virtual void StampaImmobile() {
            Console.WriteLine($"-----------------------{CodiceAlfanumerico}{citta}-----------------------\n");
            Console.WriteLine(this.ToString());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------\n");
        }
    }
}
