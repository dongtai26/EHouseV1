using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRoleRepository
    {
        List<RoleDTO> GetRoles();
        void AddRole(RoleDTO RoleDTO);
        void UpdateRole(RoleDTO RoleDTO);
        void DeleteRole(int id);
    }
}
