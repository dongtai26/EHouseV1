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
    public class ContractRepository : IContractRepository
    {
        ContractDAO contractDAO = new ContractDAO();
        public void AddContract(ContractDTO contractDTO)
        {
            contractDAO.AddContract(Mapper.mapToEntity(contractDTO));
        }
        public void DeleteContract(int id)
        {
            contractDAO.DeleteContract(id);
        }
        public List<ContractDTO> GetContracts()
        {
            return contractDAO.GetContracts().Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public void UpdateContract(ContractDTO contractDTO)
        {
            contractDAO.UpdateContract(Mapper.mapToEntity(contractDTO));
        }
        public ContractDTO GetContractById(int id)
        {
            return Mapper.mapToDTO(contractDAO.GetContactById(id));
        }
        public ContractDTO GetContractByLesseeId(int id)
        {
            return Mapper.mapToDTO(contractDAO.GetContractByLesseeId(id));
        }
        public ContractDTO GetContractByLessorId(int id)
        {
            return Mapper.mapToDTO(contractDAO.GetContractByLessorId(id));
        }
        public ContractDTO GetContractByAdminId(int id)
        {
            return Mapper.mapToDTO(contractDAO.GetContractByAdminId(id));
        }
        public List<ContractDTO> GetContractByStatusAdminId(bool StatusAdminId)
        {
            return contractDAO.GetContractByStatusAdminId(StatusAdminId).Select(m => Mapper.mapToDTO(m)).ToList();
        } 
        public List<ContractDTO> GetContractByStatusLessorId(bool StatusLessorId)
        {
            return contractDAO.GetContractByStatusLessorId(StatusLessorId).Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public List<ContractDTO> GetContractsByLessorIdAndStutasLessorId(int id, bool StatusLessorId)
        {
            return contractDAO.GetContractsByLessorIdAndStutasLessorId(id, StatusLessorId).Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public ContractDTO GetContractByLessorIdAndStutasLessorId(int id, bool StatusLessorId)
        {
            return Mapper.mapToDTO(contractDAO.GetContractByLessorIdAndStutasLessorId(id, StatusLessorId));
        }
    }
}
