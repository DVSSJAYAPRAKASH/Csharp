using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;

    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }

    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount;
        }
    }

    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * (1 - _percentage / 100);
        }
    }
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private  decimal _fixedAmount;

        public FixedAmountDiscount(decimal fixedAmount)
        {
            _fixedAmount = fixedAmount;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - _fixedAmount;
        }
    }

    // ShoppingCart class that uses a discount strategy
    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal(decimal totalAmount)
        {
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart(new NoDiscount());
            Console.WriteLine("Total with No Discount: " + cart.CalculateTotal(100));

            cart.SetDiscountStrategy(new PercentageDiscount(10));
            Console.WriteLine("Total with 10% Discount: " + cart.CalculateTotal(100));

            cart.SetDiscountStrategy(new FixedAmountDiscount(20));
            Console.WriteLine("Total with $20 Discount: " + cart.CalculateTotal(100));
        }
    }
}
