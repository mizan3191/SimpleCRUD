using CRUD.Membership.Contexts;
using CRUD.Membership.Entities;
using DevSkill.Data;

namespace CRUD.Membership.Repositories
{
    public class GroupRepository : Repository<Group, Guid, MembershipDbContext>, IGroupRepository
    {
        public GroupRepository(IMembershipDbContext context)
            : base((MembershipDbContext)context)
        {
        }
    }
}