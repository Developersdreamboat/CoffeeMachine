using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Coffee
{
    public class OrderService:IOrderService
    {
        private readonly IUnitOfWork unit;
        private readonly IMapper mapper;
        public OrderService(IUnitOfWork unit, IMapper mapper)
        {
            this.unit = unit;
            this.mapper = mapper;
        }
        public IEnumerable<AutomatOrderModel> GetOrders()
        {
            return mapper.Map<IEnumerable<AutomatOrderModel>>(unit.AutomatOrderRepository.GetAll());
        }
    }
}
