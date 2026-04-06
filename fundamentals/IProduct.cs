using System;

namespace csbases.fundamentals;

public interface IProduct
{
    void ApplyDiscount(decimal percentage);
    string GetDescription();
}
