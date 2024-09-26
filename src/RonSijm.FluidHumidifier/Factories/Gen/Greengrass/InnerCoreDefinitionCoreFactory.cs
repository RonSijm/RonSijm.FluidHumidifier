// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerCoreDefinitionCoreFactory(Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.CoreDefinitionTypes.Core>
{

    protected override Humidifier.Greengrass.CoreDefinitionTypes.Core Create()
    {
        var coreResult = CreateCore();
        factoryAction?.Invoke(coreResult);

        return coreResult;
    }

    private Humidifier.Greengrass.CoreDefinitionTypes.Core CreateCore()
    {
        var coreResult = new Humidifier.Greengrass.CoreDefinitionTypes.Core();

        return coreResult;
    }

} // End Of Class

public static class InnerCoreDefinitionCoreFactoryExtensions
{
}
