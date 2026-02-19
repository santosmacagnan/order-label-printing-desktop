
namespace Etiquetas_Pedidos.Model
{
    internal class Order
    {
        public string OrderCode { get; set; }
        public string Company { get; set; }
        public string ListOrder => $"{OrderCode} - {Company}";
        public Order(string orderCode, string company)
        {
            OrderCode = orderCode;
            Company = company;
        }
    }
}
