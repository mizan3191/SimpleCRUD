using CRUD.Membership.UnitOfWorks;

namespace CRUD.Membership.Services
{
    public class GroupService : IGroupService
    {
        private readonly IMembershipUnitOfWork _unitOfWork;

        public GroupService(IMembershipUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}