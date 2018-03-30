using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Investment.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
       
        public string Ticker { get; set; } // Upgrade to the project will pull live data for Assets and Debt figures.

        public int Asset { get; set; }
        public int Debt { get; set; }
        public int Liquidity { get; set; }  // Upgrade to the project will make this calculation dynamic.
        public string Assessment { get; set; }  // Upgrade to the project will make this Assessment dynamic based on Liquidity calculations.
    }

    public class CompanyDBContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
    }
}