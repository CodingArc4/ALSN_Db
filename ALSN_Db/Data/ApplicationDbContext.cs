using ALSN_Db.Models;
using Microsoft.EntityFrameworkCore;

namespace ALSN_Db.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RoleClaim> RoleClaims { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Translator> Translators { get; set; }
        public DbSet<TranslationOfficeTranslator> TranslationOfficeTranslators { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderPayment> OrderPayments { get; set; }
        public DbSet<OrderRepition> OrderRepitions { get; set; }
        public DbSet<OrderAssignment> OrderAssignments { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<UserBank> UserBanks { get; set; }
        public DbSet<HeadOfAccount> HeadOfAccounts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }

    }
}
