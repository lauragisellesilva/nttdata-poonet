using System.Collections.Generic;
using System.Linq;

namespace CalculatorProject.Loops
{
    public class PrintProduct
    {
        //creo un metodo que genere el array de productos
        //la creo static porque la quiero compartida

        private static List<Product> products = new List<Product>();
        public static void CreateListProduct()
        {
            var potatoes = new Product
            {
                Id = 1,
                Name = "Patatas",
                Price = 24.56f
            };
            products.Add(potatoes);

            var oil = new Product
            {
                Id = 2,
                Name = "Aceite",
                Price = 35.27f
            };
            products.Add(oil);

            var game = new Product
            {
                Id = 3,
                Name = "Juego",
                Price = 39.99f
            };
            products.Add(game);

            var shoes = new Product(3, "Zapatos", 20.99f);
            products.Add(shoes);
        }

        public static List<Product> GetProductsGreaterThan30For()
        {
            var productsGreaterThan30 = new List<Product>();
            for (var i = 0; i < products.Count; i++)
            {
                if (products[i].Price > 30)
                {
                    productsGreaterThan30.Add(products[i]);
                }
            }
            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30ForEach()
        {
            var productsGreaterThan30 = new List<Product>();
            foreach (var product in products)
            {
                if (product.Price > 30)
                {
                    productsGreaterThan30.Add(product);
                }
            }
            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30While()
        {
            var productsGreaterThan30 = new List<Product>();
            int counter = 0;
            while (counter <= products.Count)
            {
                if (products[counter].Price > 30)
                {
                    productsGreaterThan30.Add(products[counter]);
                }
                counter++;
            }
            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30LinQ()
        {
            //no puedo usar un bucle con Ienumerable,
            //IEnumerable: la defino para recuperar el conjunto de datos de una instruccion linq
            //Recupera el conjunto de registros de una consulta
            //Polimorfismo de interfaces
            //interfaces fuertemente tipadas (genericos) Java generics
            IEnumerable<Product> filterProducs =
                from price in products
                where price.Price > 30
                select price;

            List<Product> productsGreaterThan30 = filterProducs.ToList();
            return productsGreaterThan30;
        }
    }
}
