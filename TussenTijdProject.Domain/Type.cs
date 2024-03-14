using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TussenTijdProject.Domain;

namespace TussentijdsProject.Domain;
public class Type
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Sort> Sorts { get; set; }
    public ICollection<Brand> Brands { get; set; }
    public ICollection<CarModel> Models { get; set; }

    public Type(ICollection<Sort> sorts, ICollection<Brand> brands, ICollection<CarModel> models)
    {
        Sorts = sorts;
        Brands = brands;
        Models = models;
    }
}
