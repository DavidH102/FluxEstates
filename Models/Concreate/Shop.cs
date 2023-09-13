using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluxEstates.Models.Abstract;
using FluxEstates.Models.Distinct;

namespace FluxEstates.Models.Concreate
{
    public class Shop : Commercial
    {

        public int ShopId { get; set; }
        public string CatagoryOfStore { get; set; }

        public ObjectType Type { get; set; } = ObjectType.Shop;
        public override void SomeMethod()
        {
            // implementation goes here
        }
    }
}
