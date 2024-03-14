using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TussentijdsProject.Domain;

namespace TussenTijdProject.Domain;
public class Fiscality
{
    public int Id { get; set; }
    public decimal ListPriceExclVAT { get; set; }
    public decimal BenefitInKindPerMonth { get; set; }
    public decimal AmountUpgradeInclVAT { get; set; }
    public decimal AmountDowngradeInclVAT { get; set; }
}
