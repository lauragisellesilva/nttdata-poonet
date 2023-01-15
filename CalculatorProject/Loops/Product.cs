using System;

namespace CalculatorProject.Loops
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } //automatic properties
        public float Price { get; set; } //dotnet automatic properties: genera getters, setters  atributos de manera automática
                                         //fragmento: conjunto de odigo guardado, relacionado con la palabra clave
        public Guid Guid { get; set; }
        //var guid = Guid.NewGuid();

        //si no pongo el conructor de objetos vacio, el compilador lo va a poner por mi
        //pero si pongo otro y no pongo el vacío el compilador no crea uno vacío
        public Product()
        {
            Guid = Guid.NewGuid();
        }

        public Product(int id, string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
            Guid = Guid.NewGuid();
        }

        public override string ToString()
        {
            return "Product: " + Id + Name + "," + Price;
        }
    }
}
