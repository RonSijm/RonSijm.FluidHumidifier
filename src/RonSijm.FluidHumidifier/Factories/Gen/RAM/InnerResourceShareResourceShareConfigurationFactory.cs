// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RAM;

public class InnerResourceShareResourceShareConfigurationFactory(Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration>
{

    protected override Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration Create()
    {
        var resourceShareConfigurationResult = CreateResourceShareConfiguration();
        factoryAction?.Invoke(resourceShareConfigurationResult);

        return resourceShareConfigurationResult;
    }

    private Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration CreateResourceShareConfiguration()
    {
        var resourceShareConfigurationResult = new Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration();

        return resourceShareConfigurationResult;
    }

} // End Of Class

public static class InnerResourceShareResourceShareConfigurationFactoryExtensions
{
}
