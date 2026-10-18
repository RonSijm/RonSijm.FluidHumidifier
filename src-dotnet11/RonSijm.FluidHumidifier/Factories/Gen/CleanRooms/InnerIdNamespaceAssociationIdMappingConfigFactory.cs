// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIdNamespaceAssociationIdMappingConfigFactory(Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig>
{

    protected override Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig Create()
    {
        var idMappingConfigResult = CreateIdMappingConfig();
        factoryAction?.Invoke(idMappingConfigResult);

        return idMappingConfigResult;
    }

    private Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig CreateIdMappingConfig()
    {
        var idMappingConfigResult = new Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig();

        return idMappingConfigResult;
    }

} // End Of Class

public static class InnerIdNamespaceAssociationIdMappingConfigFactoryExtensions
{
}
