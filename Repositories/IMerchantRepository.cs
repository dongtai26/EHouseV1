using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMerchantRepository
    {
        List<MerchantDTO> GetMerchants();
        MerchantDTO GetMerchantById(string id);
        void CreateMerchant(MerchantDTO merchantDTO);
        void EditMerchant(MerchantDTO merchantDTO);
        void DeleteMerchant(string id);

    }
}
