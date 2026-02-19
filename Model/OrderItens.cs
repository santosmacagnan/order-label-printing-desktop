
namespace Etiquetas_Pedidos.Model
{
    public class OrderItens(string codeReduced, string identificator, string productDescription, string description, string quantity, string unit)
    {
        private string CodeReduced { get; set; } = codeReduced;
        private string Identificator { get; set; } = identificator;
        public string Code => $"{CodeReduced} - {Identificator}";
        public string ProductName => $"{ProductDescription} -{Description}";
        private string ProductDescription { get; set; } = productDescription;
        private string Description { get; set; } = description;
        public string Quantity { get; set; } = quantity;
        public string Unit { get; set; } = unit;
    }
}
