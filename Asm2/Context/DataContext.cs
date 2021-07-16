using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ASM2")
        {

        }


    }
}