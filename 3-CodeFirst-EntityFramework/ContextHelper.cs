using _3_CodeFirst_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_EntityFramework
{
    public static class ContextHelper
    {
        public static OrderAppContext db = new OrderAppContext();
    }
}
