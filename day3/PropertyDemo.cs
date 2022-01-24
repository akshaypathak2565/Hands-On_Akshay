using System;

namespace FirstProject.Property {
    class Product {
        private string _productId;
        private string _productName;
        private decimal _price;

        public Product(string id, string name, decimal price) {
            this._productId = id;
            this._productName = name;
            this._price = price;
        }

        public string ProductId {
            get { return _productId; }

        }

        public string ProductName {
            get { return _productName; }
        }

        public decimal Price {
            get { return _price; }
            set {
                if (value > _price) {
                    throw new Exception("Price can't be greater than current price");
                } else {
                    _price = value;
                }
            }
        }

        public void showProduct() {
            Console.WriteLine($"Product ID : {_productId}\nProduct Name : {_productName}\nPrice : {_price}");
        }

    }

    public class Demo {
        public static void Main(string[] args) {
            Product product = new Product("103", "Iphone", 40000);

            product.Price = 20000;
            product.showProduct();
        }
    }
}
