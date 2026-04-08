using System;

namespace csbases.Fundamentals;

public interface IProduct
{
    void ApplyDiscount(decimal percentage);
    string GetDescription();
}
