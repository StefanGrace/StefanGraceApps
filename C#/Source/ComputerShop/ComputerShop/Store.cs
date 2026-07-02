using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class Store
    {
        private Product[] products = new Product[1024];
        private int productFiler = 0;
        private string nameFilter = "";
        private bool inStockFilter = false;

        public Store()
        {
            products[0] = new CPU("i7-4790", 400, true, 4, 8, 3_600_000_000, 4_000_000_000, 8_000_000, "LGA1150", 84);
            products[1] = new GraphicsCard("GTX 1060", 350, true, 3_000_000_000);
            products[2] = new HardDrive("10 TB Segate Barracuda Pro", 600, true, 10_000_000_000_000, "3.5 inch", "SATA", 7200);
            products[3] = new Monitor("Dell U2412M", 250, true, new Resolution(1920, 1200), 24.1, 60, "e-IPS", new string[] { "DisplayPort", "DVI-D", "VGA" }, "4-port USB 2.0");
        }

        public void AddProduct(Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = product;
                    return;
                }
            }
        }

        private Product[] GetFilteredProducts(string productName)
        {
            Product[] filteredProducts = new Product[1024];

            int filteredProductIndex = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    if ((products[i].GetType().Name == productName || productName == "") 
                        && products[i].Name.ToLower().Contains(nameFilter.ToLower())
                        && (products[i].InStock || !inStockFilter))
                    {
                        filteredProducts[filteredProductIndex] = products[i];
                        filteredProductIndex++;
                    }
                }
            }
            return filteredProducts;
        }

        public Product[] GetProducts()
        {
            return products;
        }

        public int NumberOfProducts
        {
            get
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == null)
                    {
                        return i;
                    }
                }
                return products.Length;
            }
        }

        public string[] GetProductNames()
        {
            string[] productNames = new string[products.Length];
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    productNames[i] = products[i].Name;
                }
                
            }
            return productNames;
        }

        public string GetHTML(string sortBy, bool decending)
        {
            Product[] products;

            // Filter prodcuts
            switch (productFiler)
            {
                default: products = GetFilteredProducts(""); break;
                case 1: products = GetFilteredProducts("CPU"); break;
                case 2: products = GetFilteredProducts("GraphicsCard"); break;
                case 3: products = GetFilteredProducts("HardDrive"); break;
                case 4: products = GetFilteredProducts("Monitor"); break;
            }
            products = products.Where(product => product != null).ToArray(); // Remove all null instances from the array

            // Sort array
            switch (sortBy)
            {
                // All
                case "Name": products = products.OrderBy(product => product.Name).ToArray(); break;
                case "Price": products = products.OrderBy(product => product.Price).ToArray(); break;
                // CPU
                case "Cores": products = products.OrderBy(product => ((CPU)product).Cores).ToArray(); break;
                case "Threads": products = products.OrderBy(product => ((CPU)product).Threads).ToArray(); break;
                case "Base clock": products = products.OrderBy(product => ((CPU)product).BaseClockHz).ToArray(); break;
                case "Boost clock": products = products.OrderBy(product => ((CPU)product).BoostClockHz).ToArray(); break;
                case "Cache": products = products.OrderBy(product => ((CPU)product).CacheBytes).ToArray(); break;
                case "Socket": products = products.OrderBy(product => ((CPU)product).Socket).ToArray(); break;
                case "TPD": products = products.OrderBy(product => ((CPU)product).TPD_W).ToArray(); break;
                // Graphics card
                case "V RAM": products = products.OrderBy(product => ((GraphicsCard)product).VRamBytes).ToArray(); break;
                // Hard drive
                case "Capasity": products = products.OrderBy(product => ((HardDrive)product).CapasityBytes).ToArray(); break;
                case "Cost per TB": products = products.OrderBy(product => ((HardDrive)product).CostPerTB).ToArray(); break;
                case "Connector": products = products.OrderBy(product => ((HardDrive)product).Connector).ToArray(); break;
                case "Rotaitonal speed": products = products.OrderBy(product => ((HardDrive)product).RotaitionalSpeedRPM).ToArray(); break;
                // Monitor
                case "Size": products = products.OrderBy(product => ((Monitor)product).DiagonalSizeInches).ToArray(); break;
                case "Resolution": products = products.OrderBy(product => ((Monitor)product).Resolution.TotalPixelCount).ToArray(); break;
                case "Aspect ratio": products = products.OrderBy(product => ((Monitor)product).AR.Ratio).ToArray(); break;
                case "Refresh rate": products = products.OrderBy(product => ((Monitor)product).RefreshRateHz).ToArray(); break;
                case "Panel type": products = products.OrderBy(product => ((Monitor)product).PanelType).ToArray(); break;
            }
            if (decending)
            {
                products = products.Reverse().ToArray();
            }

            // Generate HTML
            string html = "<body><table>";
            for(int i = 0; i < products.Length; i++)
            {
                string rowClass = (i % 2 == 0) ? "odd" : "even";
                if (products[i] != null)
                {
                    html += "<tr class=\"" + rowClass + "\"><td class=\"name\">" + products[i].Name + 
                        "</td><td class=\"price\">$" + products[i].Price.ToString("#,##0.00") + 
                        "</td><td class=\"info\">" + products[i].GetHTML() + "</td></tr>";
                }
            }
            html += "</table></body>";
            return html;
        }

        public void RemoveProduct (int productIndex)
        {
            Product[] newProducts = new Product[1024];
            for (int i = 0; i < productIndex; i++)
            {
                newProducts[i] = products[i];
            }
            for (int i = productIndex + 1; i < products.Length; i++)
            {
                newProducts[i - 1] = products[i];
            }
            products = newProducts;
        }

        public int ProductFilter
        {
            set
            {
                productFiler = value;
            }
        }

        public string NameFilter
        {
            set
            {
                nameFilter = value;
            }
        }

        public bool InStockFilter
        {
            set
            {
                inStockFilter = value;
            }
        }

        

    }
}
