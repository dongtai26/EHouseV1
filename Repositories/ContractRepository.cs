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
    }
}
