using Assignment_3_4.Payment;
using Assignment_3_4.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4.Checkout
{
    class CheckoutTime
    { 
        private IPay _paymentMethod;
        private IProduct _product;


        public CheckoutTime(IProduct product, IPay paymentMethod)
        {
            _product = product;
            _paymentMethod = paymentMethod;
           
        }
            

        public void CheckOut()
        {
            _product.ShowDetails();
            Console.WriteLine("And its price is : {0}", _product.GetCost());
            _paymentMethod.Payment();

        }

    }
}
