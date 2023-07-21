using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ILessorRepository
    {
        List<LessorDTO> GetLessors();
        void AddLessor(LessorDTO lessorDTO);
        void DeleteLessor(int id);
        LessorDTO GetLessorById(int id);
    }
}
