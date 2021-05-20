using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoApi.models;


namespace BlogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly OrderContext orderDb;

        //构造函数把OrderContext 作为参数，Asp.net core 框架可以自动注入OrderContext对象
        public OrderController(OrderContext context)
        {
            this.orderDb = context;
        }

        // GET: api/order/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<Order> GetTodoItem(int id)
        {
            var order = orderDb.Orders.Include(o=>o.Customer).FirstOrDefault(o => o.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // GET: api/todo
        // GET: api/todo/pageQuery?name=课程&&isComplete=true
        [HttpGet]
        public ActionResult<List<Order>> GetOrderDetail(string name)
        {
            var query = buildQuery(name);
            return query.ToList();
        }

        // GET: api/todo/pageQuery?skip=5&&take=10  
        // GET: api/todo/pageQuery?name=课程&&isComplete=true&&skip=5&&take=10
        [HttpGet("pageQuery")]
        public ActionResult<List<Order>> queryTodoItem(string name, int skip, int take)
        {
            var query = buildQuery(name).Skip(skip).Take(take);
            return query.ToList();
        }

        private IQueryable<Order> buildQuery(string name)
        {
            IQueryable<Order> query = orderDb.Orders.Include(o=>o.Customer);
            if (name != null)
            {
                query = query.Where(t => t.Customer.CustomerID.Contains(name));
            }
            return query;
        }


        // POST: api/todo
        [HttpPost]
        public ActionResult<Order> PostTodoItem(Order todo)
        {
            try
            {
                orderDb.Orders.Add(todo);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return todo;
        }

        // PUT: api/todo/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> PutTodoItem(int id, Order order)
        {
            if (id != order.OrderID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/todo/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTodoItem(int id)
        {
            try
            {
                var todo = orderDb.Orders.FirstOrDefault(t => t.OrderID == id);
                if (todo != null)
                {
                    orderDb.Remove(todo);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}