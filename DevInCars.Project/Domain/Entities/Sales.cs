using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Enum;
using static System.DateTime;

namespace DevInCars.Project.Domain.Entities;

public class Sales
{
    public VehicleFactoryBase? Vehicle { get;  }
    public string SaleDate { get;  }
    public string BuyerId { get;  }
    public double SaleValue { get; }

    public Sales(VehicleFactoryBase? vehicle,  string buyerId)
    {
        Vehicle = vehicle;
        Vehicle.BuyerId = buyerId;
        Vehicle.Status = VehicleStatus.Vendido;
        SaleDate = Now.ToString("dd-MM-yyyy");
        BuyerId = buyerId;
        SaleValue = Vehicle.Value;

    }
    
    
    
    
}