﻿using DataAccess.DTO;
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
        List<ContractDTO> GetContractByStatusAdminId(bool StatusAdminId);
        List<ContractDTO> GetContractByStatusLessorId(bool StatusLessorId);
        List<ContractDTO> GetContractsByLessorIdAndStutasLessorId(int id, bool StatusLessorId);
        ContractDTO GetContractByLessorIdAndStutasLessorId(int id, bool StatusLessorId);
        ContractDTO GetContractById(int id);
        ContractInfomationDTO GetInformationContractById(int id);
        List<ContractDTO> GetContractByLesseeId(int id);
        List<ContractDTO> GetContractByLessorId(int id);
        List<ContractDTO> GetContractByAdminId(int id);
        int CountContractByLessorId(int id);
        void AddContract(ContractDTO contract);
        void UpdateContract(ContractDTO contract);
        void DeleteContract(int id);
    }
}
