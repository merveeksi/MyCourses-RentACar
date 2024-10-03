using Core.Persistence.Repositories;
using Domain.Enums;

namespace Domain.Entities;

public class Car:Entity<Guid>
{
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public short ModelYear { get; set; }
    public string Plate { get; set; } //plaka
    public short MinFindexScore { get; set; } //findex puanı
    public CarState CarState { get; set; } //aracın durumu


    public virtual Model? Model { get; set; }

    public Car()
    {
        
    }

    public Car(
        Guid id,
        Guid modelId,
        CarState carState,
        int kilometer,
        short modelYear,
        string plate,
        short minFindexScore
    )
        : this()
    {
        Id = id;
        ModelId = modelId;
        CarState = carState;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
        MinFindexScore = minFindexScore;
    }
}