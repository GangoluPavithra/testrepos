using Microsoft.EntityFrameworkCore;

namespace POPUP.Models
{

    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }

        public DbSet<TransactionModel> Transaction { get; set; }
    }


}