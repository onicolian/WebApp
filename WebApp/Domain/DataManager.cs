using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain
{
    public class DataManager
    {
        public ITextFieldRepository TextFields { get; set; }
        public IJeweleryRepository Jewelery { get; set; }
        public IOrdersRepository Orders { get; set; }

        public DataManager(ITextFieldRepository textField, IJeweleryRepository jewelery, IOrdersRepository orders)
        {
            TextFields = textField;
            Jewelery = jewelery;
            Orders = orders;
        }
    }
}
