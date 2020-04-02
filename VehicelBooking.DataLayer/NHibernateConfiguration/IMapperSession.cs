using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicelBooking.Entities;

namespace VehicelBooking.DataLayer.NHibernateConfiguration
{
    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(Vehicle entity);
        System.Threading.Tasks.Task Delete(Vehicle entity);
        IQueryable<Vehicle> vehicle { get; }
    }
}
