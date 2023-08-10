using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ContractDAO
    {
        public List<Contract> GetContracts()
        {
            var listContract = new List<Contract>();
            try
            {
                using (var context = new AppDbContext())
                {
                    listContract = context.Contracts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listContract;
        }
        public void AddContract(Contract contract)
        {
            try
            {
                var db = new AppDbContext();
                db.Contracts.Add(contract);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateContract(Contract contract)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<Contract>(contract).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteContract(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var rDelete = context.Contracts.SingleOrDefault(x => x.ConId == id);
                    context.Contracts.Remove(rDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Contract GetContactById(int id)
        {
            Contract contract = new Contract();
            try
            {
                var db = new AppDbContext();
                contract = db.Contracts.SingleOrDefault(x => x.ConId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return contract;
        }
        public List<Contract> GetContractByLesseeId(int id)
        {
            var listContract = new List<Contract>();
            try
            {
                var db = new AppDbContext();
                listContract = db.Contracts.Where(x => x.LesId == id).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listContract;
        }
        public List<Contract> GetContractByLessorId(int id)
        {
            var listContract = new List<Contract>();
            try
            {
                var db = new AppDbContext();
                listContract = db.Contracts.Where(x => x.LeId == id).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listContract;
        }
        public List<Contract> GetContractByAdminId(int id)
        {
            var listContract = new List<Contract>();
            try
            {
                var db = new AppDbContext();
                listContract = db.Contracts.Where(x => x.AdId == id).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listContract;
        }
        public List<Contract> GetContractByStatusAdminId(bool statusAdminId)
        {
            var ListContract = new List<Contract>();
            try
            {
                using(var context = new AppDbContext())
                {
                    ListContract = context.Contracts.Where(x => x.StatusAdminId == statusAdminId).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListContract;
        }
        public List<Contract> GetContractByStatusLessorId(bool StatusLessorId)
        {
            var ListContract = new List<Contract>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListContract = context.Contracts.Where(x => x.StatusLessorId == StatusLessorId).ToList();   
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListContract;
        }
        public List<Contract> GetContractsByLessorIdAndStutasLessorId(int id, bool StatusLessorId)
        {
            var ListContract = new List<Contract>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListContract = context.Contracts.Where(x => x.LeId == id && x.StatusLessorId == StatusLessorId).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListContract;
        }
        public Contract GetContractByLessorIdAndStutasLessorId (int id, bool StatusLessorId)
        {
            Contract contract = new Contract();
            try
            {
                var db = new AppDbContext();
                contract = db.Contracts.SingleOrDefault(x => x.LeId == id && x.StatusLessorId == StatusLessorId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return contract;
        }
    }
}
