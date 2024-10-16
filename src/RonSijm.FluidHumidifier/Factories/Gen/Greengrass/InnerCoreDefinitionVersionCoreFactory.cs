// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerCoreDefinitionVersionCoreFactory(Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core>
{

    protected override Humidifier.Greengrass.CoreDefinitionVersionTypes.Core Create()
    {
        var coreResult = CreateCore();
        factoryAction?.Invoke(coreResult);

        return coreResult;
    }

    private Humidifier.Greengrass.CoreDefinitionVersionTypes.Core CreateCore()
    {
        var coreResult = new Humidifier.Greengrass.CoreDefinitionVersionTypes.Core();

        return coreResult;
    }

} // End Of Class

public static class InnerCoreDefinitionVersionCoreFactoryExtensions
{
}
