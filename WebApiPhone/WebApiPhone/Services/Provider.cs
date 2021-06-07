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
        private readonly List<Phone> _phones;

        public void Post(Phone phone)
        {
            _phones.Add(phone);
        }

        public void Put(Phone phone)
        {
            var index = _phones.FindIndex(x => x.Id == phone.Id);
            _phones[index] = phone;
        }

        public void Delete(int id)
        {
            _phones.RemoveAt(id);
        }

        public List<Phone> Get()
        {
            return _phones;
        }

        public Phone Get(int id)
        {
            var phone = _phones.FirstOrDefault(x => x.Id == id);
            return phone;
        }
    }
}
