using BlazorChat.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorChat.Client.Managers
{
public interface IChatManager
{   
        //interfejs koji ce biti nasledjen od strane klase ChatManager.cs
    Task<List<ApplicationUser>> GetUsersAsync();
    Task SaveMessageAsync(ChatMessage message);
    Task<List<ChatMessage>> GetConversationAsync(string contactId);
    Task<ApplicationUser> GetUserDetailsAsync(string userId);
}
}
