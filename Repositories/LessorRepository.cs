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
    public class LessorRepository : ILessorRepository
    {
        LessorDAO lessorDAO = new LessorDAO();
        public List<LessorDTO> GetLessors()
        {
            return lessorDAO.GetLessors().Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public void AddLessor(LessorDTO lessorDTO)
        {
            lessorDAO.AddLessor(Mapper.mapToEntity(lessorDTO));
        }

        public void DeleteLessor(int id)
        {
            lessorDAO.DeleteLessor(id);
        }

        public LessorDTO GetLessorById(int id)
        {
            return Mapper.mapToDTO(lessorDAO.GetLessorByUserId(id));
        }
        public LessorDTO GetLessorByLessorId(int id)
        {
            return Mapper.mapToDTO(lessorDAO.GetLessorByLessorId(id));
        }
        public int CountTotalLessor()
        {
            return lessorDAO.CountTotalLessor();
        }
    }
}
