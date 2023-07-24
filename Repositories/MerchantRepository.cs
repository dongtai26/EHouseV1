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
    public class MerchantRepository : IMerchantRepository
    {
        MerchantDAO merchantDAO = new MerchantDAO();
        public void CreateMerchant(MerchantDTO merchantDTO)
        {
            merchantDAO.CreateMerchant(Mapper.mapToEntity(merchantDTO));
        }

        public void DeleteMerchant(string id)
        {
            merchantDAO.DeleteMerchant(id);
        }

        public void EditMerchant(MerchantDTO merchantDTO)
        {
            merchantDAO.EditMerchant(Mapper.mapToEntity(merchantDTO));
        }

        public MerchantDTO GetMerchantById(string id)
        {
            return Mapper.mapToDTO(merchantDAO.GetMerchantById(id));
        }

        public List<MerchantDTO> GetMerchants()
        {
            return merchantDAO.GetMerchants().Select(m => Mapper.mapToDTO(m)).ToList();
        }
    }
}
