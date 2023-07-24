using DataAccess;
using DataAccess.DTO;
using DataAccess.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RoleRepository : IRoleRepository
    {
        RoleDAO roleDAO = new RoleDAO();
        public void AddRole(RoleDTO roleDTO)
        {
            roleDAO.AddRole(Mapper.mapToEntity(roleDTO));
        }

        public void DeleteRole(int id)
        {
            roleDAO.DeleteRole(id);
        }

        public List<RoleDTO> GetRoles()
        {
            return roleDAO.GetRoles().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void UpdateRole(RoleDTO roleDTO)
        {
            roleDAO.UpdateRole(Mapper.mapToEntity(roleDTO));
        }
    }
}
