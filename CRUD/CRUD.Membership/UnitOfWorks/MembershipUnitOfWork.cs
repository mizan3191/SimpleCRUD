using CRUD.Membership.Contexts;
using CRUD.Membership.Repositories;
using DevSkill.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Membership.UnitOfWorks
{
    public class MembershipUnitOfWork : UnitOfWork, IMembershipUnitOfWork
    {
        public IGroupRepository GroupRepository { get; private set; }

        public MembershipUnitOfWork(IMembershipDbContext context,
            IGroupRepository groupRepository
            ) : base((DbContext)context)
        {
           GroupRepository = groupRepository;
        }
    }
}