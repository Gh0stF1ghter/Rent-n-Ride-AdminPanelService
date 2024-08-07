using AdminPanel.BLL.Models;
using Mapster;
using RentGrpcService;
using System.Reflection;

namespace AdminPanel.BLL.MappingConfigurations;

public class GlobalMappingSettings : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        TypeAdapterConfig.GlobalSettings.Default.MaxDepth(3);
        TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);

        config.NewConfig<ProtoVehicleClientHistoryModel, VehicleClientHistoryModel>()
            .Map(dest => dest.StartDate, src => src.StartDate.ToDateTime())
            .Map(dest => dest.EndDate, src => src.EndDate.ToDateTime());
    }
}