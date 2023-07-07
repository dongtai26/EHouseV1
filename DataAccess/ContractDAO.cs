﻿using BusinessObjects.Data;
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
    }
}