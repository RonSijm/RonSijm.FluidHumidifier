// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIdMappingTableIdMappingTableInputReferenceConfigFactory(Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig>
{

    protected override Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig Create()
    {
        var idMappingTableInputReferenceConfigResult = CreateIdMappingTableInputReferenceConfig();
        factoryAction?.Invoke(idMappingTableInputReferenceConfigResult);

        return idMappingTableInputReferenceConfigResult;
    }

    private Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig CreateIdMappingTableInputReferenceConfig()
    {
        var idMappingTableInputReferenceConfigResult = new Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig();

        return idMappingTableInputReferenceConfigResult;
    }

} // End Of Class

public static class InnerIdMappingTableIdMappingTableInputReferenceConfigFactoryExtensions
{
}
