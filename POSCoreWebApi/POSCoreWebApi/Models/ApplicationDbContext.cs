
using BusinesEntities;
using Microsoft.EntityFrameworkCore;

namespace POSCoreWebApi.Models
{
    public class ApplicationDbContext:DbContext
    {
        //NS:23/12/2022 => i've inserted dependency injection here
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // NS:23/12/2022 =>Add the classes here to create properties of classes for database through Entity DbSet Class

        public DbSet<AccountMaster> AccountMasters { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ChildAccount> ChildAccounts { get; set; }
        public DbSet<ParentAccount> ParentAccounts { get; set; }
        public DbSet<HeadAccount> HeadAccounts { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<PurchaseReturn> PurchaseReturns { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Design> Designs { get; set; }
        public DbSet<Currency> Currencys { get; set; }
        public DbSet<CurrencyDetail> CurrencyDetails { get; set; }
        public DbSet<ChequeDetail> ChequeDetails { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankAccountHolder> BankAccountHolders { get; set; }

        public DbSet<PhoneNo> PhoneNos { get; set; }
        public DbSet<UserLogStatus> UserLogStatus { get; set; }
        public virtual DbSet<MenuMaster> MenuMaster { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
    }
}
