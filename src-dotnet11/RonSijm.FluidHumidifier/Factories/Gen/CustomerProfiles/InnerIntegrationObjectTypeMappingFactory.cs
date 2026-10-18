// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationObjectTypeMappingFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping>
{

    protected override Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping Create()
    {
        var objectTypeMappingResult = CreateObjectTypeMapping();
        factoryAction?.Invoke(objectTypeMappingResult);

        return objectTypeMappingResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping CreateObjectTypeMapping()
    {
        var objectTypeMappingResult = new Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping();

        return objectTypeMappingResult;
    }

} // End Of Class

public static class InnerIntegrationObjectTypeMappingFactoryExtensions
{
}
