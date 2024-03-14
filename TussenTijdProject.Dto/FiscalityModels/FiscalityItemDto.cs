using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussenTijdProject.Dto.FiscalityModels;
public record FiscalityItemDto
{
    public decimal ListPriceExclVAT { get; set; }
    public decimal BenefitInKindPerMonth { get; set; }
    public decimal AmountUpgradeInclVAT { get; set; }
    public decimal AmountDowngradeInclVAT { get; set; }
}
