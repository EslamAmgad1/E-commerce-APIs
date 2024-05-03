using System.ComponentModel.DataAnnotations;

namespace E_commerce_APIs.Dtos
{
    public class CustomerBasketDto
    {
        [Required]
        public string Id { get; set; }
        public List<BasketItemDto> Items { get; set; }

    }
}
