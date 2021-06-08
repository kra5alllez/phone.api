using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhone.Models;
using WebApiPhone.Services.Interface;

namespace WebApiPhone.Services
{
    public class Provider : IProvider
    {
        private readonly Dictionary<int, Phone> _phones = new Dictionary<int, Phone>();
        private int _id = 1;

        public void Post(Phone phone)
        {
            var id = _id++;
            _phones.Add(id, phone);
        }

        public void Put(int id, Phone phone)
        {
            _phones[id] = phone;
        }

        public void Delete(int id)
        {
            _phones.Remove(id);
        }

        public Dictionary<int, Phone> Get()
        {
            return _phones;
        }

        public Phone Get(int id)
        {
            var phone = _phones[id];
            return phone;
        }
    }
}
