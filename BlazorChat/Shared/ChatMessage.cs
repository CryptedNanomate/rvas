using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Shared
{
    public class ChatMessage
    {
        //Entitet ChatMesage, koji drzi sve detalje o jednoj poruci i to: id,vreme,od kog korisnika (preko ID-a,kome, isto preko id-a,sadrzaj poruke,datumu
        // i virutelna svojstva koja ce se koristit za pristup drugim entitetima, polimorfizam!(moze biti overidovan property)
        public long Id { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ApplicationUser FromUser { get; set; }
        public virtual ApplicationUser ToUser { get; set; }
    }
}
