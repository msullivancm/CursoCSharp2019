using OrdemDeServico.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace OrdemDeServico.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();
        public Client Client { get; set; } = new Client();

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem item in Item)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: "); sb.AppendLine(Moment.Date.ToLongDateString());
            sb.Append("Status: "); sb.AppendLine(Status.ToString());
            sb.Append("Client: "); sb.AppendLine(Client.ToString());
            sb.Append("Order items: ");
            int n = 1;
            foreach (OrderItem item in Item)
            {
                sb.Append(item.Product.Name);
                sb.Append(", $");
                sb.Append(item.Product.Price);
                sb.Append($", Quantity: {n}, Subtotal: $");
                sb.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                n++;
            }
            sb.Append("Total price: "); sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
