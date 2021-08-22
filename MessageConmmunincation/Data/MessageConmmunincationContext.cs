using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MessageConmmunincation.Model;

namespace MessageConmmunincation.Data
{
    public class MessageConmmunincationContext : DbContext
    {
        public MessageConmmunincationContext (DbContextOptions<MessageConmmunincationContext> options)
            : base(options)
        {
        }

        public DbSet<MessageConmmunincation.Model.Message> Message { get; set; }
    }
}
