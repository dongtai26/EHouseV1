using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IContractRepository
    {
        List<ContractDTO> GetContracts();
        ContractDTO GetContractById(int id);
        ContractDTO GetContractByLesseeId(int id);
        ContractDTO GetContractByLessorId(int id);
        ContractDTO GetContractByAdminId(int id);
        void AddContract(ContractDTO contract);
        void UpdateContract(ContractDTO contract);
        void DeleteContract(int id);
    }
}
