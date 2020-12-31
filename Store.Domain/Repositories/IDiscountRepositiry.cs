using Store.Domain.Entities;

namespace Store.Domain.Repositories
{
    public interface IDiscountRepositiry
    {
        Discount Get(string code);
    }
}