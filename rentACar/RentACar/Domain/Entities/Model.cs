using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Model:Entity<Guid>
{
    public Guid BrandId { get; set; }
    public Guid FuelId { get; set; } //yakıt
    public Guid TransmissionId { get; set; } //vites
    public string Name { get; set; } //model adı
    public decimal DailyPrice { get; set; } //günlük fiyat
    public string ImageUrl { get; set; }
    
    //nesneler arasında ilişki kurmak için kullanılır
    public virtual Brand? Brand { get; set; }
    public virtual Fuel? Fuel { get; set; }
    public virtual Transmission? Transmission { get; set; }

    public virtual ICollection<Car> Cars { get; set; }

    public Model()
    {
        Cars = new HashSet<Car>(); //bir modelin birden fazla aracı olabilir
    }

    public Model(Guid id, Guid brandId, Guid fuelId, Guid transmissionId, string name, decimal dailyPrice, string imageUrl):this() //this ile birlikte çalıştırılan constructor, üstteki constructor'ı çalıştırır
    {
        Id = id;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        DailyPrice = dailyPrice;
        ImageUrl = imageUrl;
    }
}