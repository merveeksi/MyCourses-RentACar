using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Brand:Entity<Guid>
{
    public string Name { get; set; }

<<<<<<< HEAD
    // public virtual ICollection<Model> Models { get; set; }
    //
    public Brand()
    {
        //Models = new HashSet<Model>();
    }
    
    public Brand(Guid id, string name)//:this()
=======
    public virtual ICollection<Model> Models { get; set; }
    
    public Brand()
    { 
        Models = new HashSet<Model>();
    }
    
    public Brand(Guid id, string name):this() //this ile birlikte çalıştırılan constructor, üstteki constructor'ı çalıştırır
>>>>>>> f8079a9 (Initial commit for MyCourses_RentACar)
    {
        Id = id;
        Name = name;
    }

}