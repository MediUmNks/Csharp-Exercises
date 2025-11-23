//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AdvancedC_topics
//{
//    public class Products
//    {
//        private decimal _price;
//        private int _stockQuantity;

//        public Products(int id, string name, decimal price, int quntity)
//        {
//            Id = id;
//            ProName = name;
//            _price = price;
//            _stockQuantity = quntity;
//        }

//        public int Id
//        { get; private set; }

//        public string ProName { get; set; }

//        public decimal Price
//        {
//            get { return _price; }
//            set
//            {
//                if (value > 0)
//                {
//                    _price = value;
//                }
//                else
//                {
//                    throw new ArgumentOutOfRangeException(nameof(value), "Price cannot be Negative");
//                }
//            }
//        }

//        public int StockQuantity
//        {
//            get
//            {
//                return _stockQuantity;
//            }
//            set
//            {
//                if (value > 0)
//                {
//                    _stockQuantity = value;
//                }
//                else
//                {
//                    throw new ArgumentOutOfRangeException(nameof(value), "Quntity cannot be negative or zero");
//                }
//            }
//        }

//        public bool IsAvailable
//        {
//            get
//            {
//                if (StockQuantity > 0)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//        }
//    }
//}
