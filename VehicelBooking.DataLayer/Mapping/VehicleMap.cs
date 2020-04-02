using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.Entities;

namespace VehicelBooking.DataLayer.Mapping
{
     public  class VehicleMap : ClassMap<Vehicle>
     {

        public VehicleMap()
        {
            Id(x => x.VehicleId);

            Map(x => x.Vehiclename);

            Map(x => x.VehiclePrice);
            Map(x => x.BranchId);
            
            Table("vehicle");

        }  

    }
}
