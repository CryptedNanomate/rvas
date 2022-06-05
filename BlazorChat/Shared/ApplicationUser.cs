using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Shared
{   //nasledjujemo klasu identity user jer onda sadrzi podatke i registrovanim korisnicima, na pocetku projekta izabrano je individual accounts!
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<ChatMessage> ChatMessagesFromUsers { get; set; }
        public virtual ICollection<ChatMessage> ChatMessagesToUsers { get; set; }
        public ApplicationUser()
        {
            ChatMessagesFromUsers = new HashSet<ChatMessage>(); //instanciramo klasu HashSet,jedan korisnik ce mozda biti primalac seta poruka,ili posiljalac kolekcije poruka.
            ChatMessagesToUsers = new HashSet<ChatMessage>();
        }
    }
}
