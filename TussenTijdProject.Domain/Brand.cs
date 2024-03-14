using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TussentijdsProject.Domain;

namespace TussenTijdProject.Domain;
public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<CarModel> Cars { get; set; }
    public ICollection<TussentijdsProject.Domain.Type> Types { get; set; }
    public ICollection<Sort> Sorts { get; set; }

    public Brand(ICollection<CarModel> cars, ICollection<TussentijdsProject.Domain.Type> types, ICollection<Sort> sorts)
    {
        Cars = cars;
        Types = types;
        Sorts = sorts;
    }
}
