using CRUD.Membership.Contexts;
using CRUD.Membership.Entities;
using DevSkill.Data;

namespace CRUD.Membership.Repositories
{
    public interface IGroupRepository : IRepository<Group, Guid, MembershipDbContext>
    {
    }
}