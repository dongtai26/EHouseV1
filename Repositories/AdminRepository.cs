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
    public class AdminRepository : IAdminRepository
    {
        AdminDAO adminDAO = new AdminDAO();
        public List<AdminDTO> GetAdmins()
        {
            return adminDAO.GetAdmins().Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public void AddAdmin(AdminDTO adminDTO)
        {
            adminDAO.AddAdmin(Mapper.mapToEntity(adminDTO));
        }

        public void DeleteAdmin(int id)
        {
            adminDAO.DeleteAdmin(id);
        }
    }
}
