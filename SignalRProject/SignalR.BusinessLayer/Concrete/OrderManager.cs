using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
	public class OrderManager : IOrderService
	{
		private readonly IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public int TAcctiveOrderCount()
		{
			return _orderDal.AcctiveOrderCount();
		}

		public void TAdd(Order entity)
		{
			_orderDal.Add(entity);

		}

		public void TDelete(Order entity)
		{
			throw new NotImplementedException();
		}

		public Order TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Order> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public decimal TLastOrderPrice()
		{
			return _orderDal.LastOrderPrice();
		}

		public decimal TTodayTotalPrice()
		{
			return _orderDal.TodayTotalPrice();
		}

		public int TTotalOrderCount()
		{
			return _orderDal.TotalOrderCount();
		}

		public void TUpdate(Order entity)
		{
			throw new NotImplementedException();
		}
	}
}
