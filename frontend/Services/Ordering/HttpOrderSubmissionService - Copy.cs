using GloboTicket.Frontend.Models.Api;
using GloboTicket.Frontend.Models.View;
using GloboTicket.Frontend.Services.ShoppingBasket;

namespace GloboTicket.Frontend.Services.Ordering;

public class InMemoryOrderSubmissionService : IOrderSubmissionService
{
    private readonly IShoppingBasketService shoppingBasketService;
    private readonly HttpClient orderingClient;

    public InMemoryOrderSubmissionService()
    { 
    }
    public async Task<Guid> SubmitOrder(CheckoutViewModel checkoutViewModel)
    {
       return await Task.FromResult(Guid.NewGuid());
    }
}
