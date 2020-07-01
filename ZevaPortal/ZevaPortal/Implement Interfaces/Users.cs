using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Implement_Interfaces
{
    public class Users : IUsersController
    {
        public Task<ActionResult<User>> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<User>> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<User>> PostUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutUser(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
