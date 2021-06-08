using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhone.Models;

namespace WebApiPhone.Services.Interface
{
    public interface IProvider
    {
        void Post(Phone phone);

        void Put(int id, Phone phone);

        void Delete(int id);
        Dictionary<int, Phone> Get();

        Phone Get(int id);
    }
}
