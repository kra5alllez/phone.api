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

        void Put(Phone phone);

        void Delete(int id);

        Phone Get(int id);
    }
}
