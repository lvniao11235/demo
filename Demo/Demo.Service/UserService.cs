using System;
using System.Collections.Generic;
using System.Text;
using Demo.Entity;
using System.Linq;

namespace Demo.Service
{
    public class UserService
    {
        private DataContext ctx;

        public UserService(DataContext ctx)
        {
            this.ctx = ctx;
        }

        public List<User> GetAllUsers()
        {
            return ctx.Users.ToList();
        }
    }
}
