using Entities.Models;
using Repositories.Contrats;
using Repositories.EF_Core;
using Services.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeCardManager : IEmployeeCardService
    {
        private readonly IRepositoryManager _manager;

        public EmployeCardManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public EmployeeCard CreateService(EmployeeCard entity) 
        { 
            _manager.EmployeeCard.Create(entity);
            _manager.Save();
            return entity;
        }

        public void DeleteService(int id, bool trackChanges)
        {
            var entity = _manager.EmployeeCard.GetEmployeeCardByID(id, trackChanges);
            if (entity is null)
            {
                throw new Exception($"EmployeeCard With ID : {id} Could Not Found.");
            }
            _manager.EmployeeCard.Delete(entity);
            _manager.Save();
        }

        public IEnumerable<EmployeeCard> GetAllService(bool trackChanges)
        {
            return _manager.EmployeeCard.GetAllEmployeeCard(trackChanges);
        }

        public EmployeeCard GetByIDService(int id, bool trackChanges)
        {
            return _manager.EmployeeCard.GetEmployeeCardByID(id,trackChanges);
        }

        public void UpdateService(EmployeeCard employeeCard, int id, bool trackChanges)
        {
            var entity = _manager.EmployeeCard.GetEmployeeCardByID(id, trackChanges);
            if (entity is null)
            {
                throw new Exception($"EmployeeCard With ID : {id} Could Not Found.");
            }

            entity.Id = employeeCard.Id;
            entity.EmployeeId = employeeCard.EmployeeId;
            entity.CardType = employeeCard.CardType;
            entity.CardIdRaw = employeeCard.CardIdRaw;
            entity.CardIdReverse = employeeCard.CardIdReverse;
            entity.CardId4Byte = employeeCard.CardId4Byte;
            entity.CardId4ByteHex = employeeCard.CardId4ByteHex;
            entity.CardId4ByteReverse = employeeCard.CardId4ByteReverse;
            entity.CardId4ByteReverseHex = employeeCard.CardId4ByteReverseHex;
            entity.CardId7Byte = employeeCard.CardId7Byte;
            entity.CardId7ByteHex = employeeCard.CardId7ByteHex;
            entity.CardId7ByteReverse = employeeCard.CardId7ByteReverse;
            entity.CardId7ByteReverseHex = employeeCard.CardId7ByteReverseHex;
            entity.StartDate = employeeCard.StartDate;
            entity.FinishDate = employeeCard.FinishDate;
            entity.DefineDate = employeeCard.DefineDate;
            entity.Cancelled = employeeCard.Cancelled;
            entity.CancelDate = employeeCard.CancelDate;
            entity.CancelUserId = employeeCard.CancelUserId;
            entity.CancelReason = employeeCard.CancelReason;
            entity.IsPrimary = employeeCard.IsPrimary;
            entity.CardStatus = employeeCard.CardStatus;
            entity.CardActive = employeeCard.CardActive;
            entity.CardNew = employeeCard.CardNew;
            entity.Update_Date = employeeCard.Update_Date;

            _manager.EmployeeCard.Update(entity);
            _manager.Save();
        }
    }
}
