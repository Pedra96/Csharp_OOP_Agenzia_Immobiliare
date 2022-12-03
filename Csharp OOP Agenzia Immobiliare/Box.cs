using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare {
    internal class Box:Immobile {
        private uint postiauto;
         public Box(string indirizzo, uint cap, string citta,uint postiauto, uint mq): base(indirizzo, cap, citta, mq) {
            this.postiauto = postiauto;
        }
        public uint GetBox() {
            return postiauto;
        }
        
        public void SetBox(uint NewPostiAuto) {
            postiauto= NewPostiAuto;
        }

        public override string ToString() {
            string BoxPrint=base.ToString() + "\nPosti auto: "+postiauto;
            return BoxPrint;

        }
        public override void StampaImmobile() {
            Console.WriteLine($"-----------------------{base.GetCodiceAlfanumerico()}{base.GetCitta()}-----------------------\n");
            Console.WriteLine(this.ToString());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------\n");
        }
    }
}
