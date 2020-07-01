using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface IUsersController
    {
        Task<ActionResult<User>> DeleteUser(int id);
        Task<ActionResult<User>> GetUser(int id);
        Task<ActionResult<IEnumerable<User>>> GetUsers();
        Task<ActionResult<User>> PostUser(User user);
        Task<IActionResult> PutUser(int id, User user);
    }
}