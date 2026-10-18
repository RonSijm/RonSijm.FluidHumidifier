// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDistributionInputOriginFactory(Action<Humidifier.Lightsail.DistributionTypes.InputOrigin> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DistributionTypes.InputOrigin>
{

    protected override Humidifier.Lightsail.DistributionTypes.InputOrigin Create()
    {
        var inputOriginResult = CreateInputOrigin();
        factoryAction?.Invoke(inputOriginResult);

        return inputOriginResult;
    }

    private Humidifier.Lightsail.DistributionTypes.InputOrigin CreateInputOrigin()
    {
        var inputOriginResult = new Humidifier.Lightsail.DistributionTypes.InputOrigin();

        return inputOriginResult;
    }

} // End Of Class

public static class InnerDistributionInputOriginFactoryExtensions
{
}
