using DevSkill.Data;

namespace CRUD.Membership.Entities
{
    public class Group : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        
    }
}