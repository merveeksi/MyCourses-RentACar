using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Brand:Entity<Guid>
{
    public string Name { get; set; }

    // public virtual ICollection<Model> Models { get; set; }
    //
    public Brand()
    {
        //Models = new HashSet<Model>();
    }
    
    public Brand(Guid id, string name)//:this()
    {
        Id = id;
        Name = name;
    }

}