﻿using BookStore.Models;

namespace BookStore.Application.Services
{
    public interface IOrderService
  {
    bool AddOrder(Order order);
    Order GetOrderById(int id);
    void ChangeOrderStutus (int orderId,OrderStatus status);
    List<Order> GetAllPagination(int num, int pageIndex);
        void DeleteOrder(int id);
    }
}