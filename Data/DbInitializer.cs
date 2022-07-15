using API.Entities;

namespace API.Data
{
  public static class DbInitializer
  {
    public static void Initialize(StoreContext context)
    {
      if (context.Products.Any()) return;

      var products = new List<Product>
      {
        new Product
        {
            Name = "Bicicleta mtb Raleigh mojave 2.0 29er 21v shimano disco",
            Description =
                "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 20000,
            PictureUrl = "/images/products/raleigh-bike.png",
            Brand = "Raleigh",
            Type = "Mountain",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Bicicleta mtb MGM bikes 29er full shimano 24v hidraulico",
            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            Price = 15000,
            PictureUrl = "/images/products/mgm-ang2.png",
            Brand = "MGM",
            Type = "Mountain",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Bicicleta mtb Battle 210 29er aluminio shimano altus disco",
            Description =
                "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
            Price = 18000,
            PictureUrl = "/images/products/battle-core1.png",
            Brand = "Battle",
            Type = "Mountain",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Bicicleta mtb Mosso 29er alu7005 full shimano 24v hidraulico",
            Description =
                "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
            Price = 30000,
            PictureUrl = "/images/products/moso-bike.png",
            Brand = "Mosso",
            Type = "Mountain",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Bicicleta mtb Silverfox 29er 21v freno disco cuadro aluminio",
            Description =
                "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 25000,
            PictureUrl = "/images/products/silverfox-bike.png",
            Brand = "Silverfox",
            Type = "Mountain",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Bicicleta spy Bullet 29er 24v shimano mecanico aluminio",
            Description =
                "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 12000,
            PictureUrl = "/images/products/spy-bullet.png",
            Brand = "Bullet",
            Type = "Mountain",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Ciclocomputadora bicicleta echowell u13w inalambrico 13 funcione",
            Description =
                "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 1000,
            PictureUrl = "/images/products/compu-echowell.png",
            Brand = "echowell",
            Type = "electronico",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Sensor bici ant+ bluetooth thinkrider velocidad o cadencia",
            Description =
                "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 8000,
            PictureUrl = "/images/products/sensor-thinkrider.png",
            Brand = "thinkrider",
            Type = "electronico",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Portapaquetes bicicleta al eje acero compatible rodado 26",
            Description =
                "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 1500,
            PictureUrl = "/images/products/portapaquetes-thinkrider.png",
            Brand = "thinkrider",
            Type = "Portapaquetes",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Portapaquetes universal aluminio apto freno disco r20 a r29",
            Description =
                "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 1800,
            PictureUrl = "/images/products/portapaquetes-universal.png",
            Brand = "Universal",
            Type = "Portapaquetes",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Portapaquetes ostand cd-28 universal flotante alforjas alumi",
            Description =
                "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 1500,
            PictureUrl = "/images/products/portapaquetes-vostand.png",
            Brand = "Vostand",
            Type = "Portapaquetes",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Multifuncion bicicleta bike hand yc-262 9 funciones original",
            Description =
                "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 1600,
            PictureUrl = "/images/products/multifuncion-bike.png",
            Brand = "bike",
            Type = "Herramientas",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "herramienta corta cadena bike hand sl-326a liviano pequeño",
            Description =
                "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 1400,
            PictureUrl = "/images/products/cortacadena-bike.png",
            Brand = "bike",
            Type = "Herramientas",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Multifuncion corta cadena bicicleta mti 11en1 ultra slim",
            Description =
                "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
            Price = 25000,
            PictureUrl = "/images/products/cortacadena-mti.png",
            Brand = "mti",
            Type = "Herramientas",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Herramienta corta cadena importado liviano pequeño",
            Description =
                "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            Price = 18999,
            PictureUrl = "/images/products/cortacadena-core2.png",
            Brand = "core2",
            Type = "Herramientas",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Multifuncion Purple Boots",
            Description =
                "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
            Price = 19999,
            PictureUrl = "/images/products/multifuncion-core1.png",
            Brand = "core1",
            Type = "Herramientas",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Multifuncion corta cadena sigma pocket tool medium 17en1",
            Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
            Price = 15000,
            PictureUrl = "/images/products/multifuncion-ang2.png",
            Brand = "bike",
            Type = "Herramientas",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "torquimetro profesional bike hand yc-617-2s 2-24nm 1/4 estu",
            Description =
                "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
            Price = 18000,
            PictureUrl = "/images/products/torq.png",
            Brand = "bike",
            Type = "Herramientas",
            QuantityInStock = 100
        },
      };

      foreach (var product in products)
      {
        context.Products.Add(product);
      }

      context.SaveChanges();
    }
  }
}