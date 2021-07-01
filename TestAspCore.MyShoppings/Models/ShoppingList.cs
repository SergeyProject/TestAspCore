using System.Text.Json.Serialization;

namespace TestAspCore.MyShoppings.Models
{
    public class ShoppingList
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("Comment")]
        public string Comment { get; set; }
    }
}
