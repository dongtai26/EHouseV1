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
    public class LesseeRepository : ILesseeRepository
    {
        LesseeDAO lesseeDAO = new LesseeDAO();
        public List<LesseeDTO> GetLessees()
        {
            return lesseeDAO.GetLessees().Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public void AddLessee(LesseeDTO lesseeDTO)
        {
            lesseeDAO.AddLessee(Mapper.mapToEntity(lesseeDTO));
        }

        public void DeleteLessee(int id)
        {
            lesseeDAO.DeleteLessee(id);
        }
    }
}
