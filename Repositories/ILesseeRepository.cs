using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ILesseeRepository
    {
        List<LesseeDTO> GetLessees();
        void AddLessee(LesseeDTO lesseeDTO);
        void DeleteLessee(int id);
        LesseeDTO GetLesseeById(int id);
    }
}
