using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BiblWeb2._0.Data
{
    public partial class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options)
               : base(options)
        {
        }
    }
}
