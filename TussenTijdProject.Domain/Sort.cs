using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TussentijdsProject.Domain;

namespace TussenTijdProject.Domain;
public class Sort
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Brand> Brands { get; set; }
    public ICollection<CarModel> Cars { get; set; }

}

