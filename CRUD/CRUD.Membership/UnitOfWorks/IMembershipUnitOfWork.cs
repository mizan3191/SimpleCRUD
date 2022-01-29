using CRUD.Membership.Repositories;
using DevSkill.Data;

namespace CRUD.Membership.UnitOfWorks
{
    public interface IMembershipUnitOfWork : IUnitOfWork
    {
        IGroupRepository GroupRepository { get; }
    }
}