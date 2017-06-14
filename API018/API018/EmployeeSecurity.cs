using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API018DBAccess;

namespace API018
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using(API018Entities entities = new API018Entities())
            {
                return entities.Users.Any(user => user.Username.Equals(username,
                    StringComparison.OrdinalIgnoreCase) && user.Password == password);
            }
        }
    }
}