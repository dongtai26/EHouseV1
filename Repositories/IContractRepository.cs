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
        void AddContract(ContractDTO contract);
        void UpdateContract(ContractDTO contract);
        void DeleteContract(int id);
    }
}
