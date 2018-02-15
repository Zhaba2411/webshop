using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopRepository
{
    public interface IWebshopRepository
    {
        WebshopItem Get(Guid todoId, Guid userId);

        void Add(WebshopItem webshopItem);

    }
}
