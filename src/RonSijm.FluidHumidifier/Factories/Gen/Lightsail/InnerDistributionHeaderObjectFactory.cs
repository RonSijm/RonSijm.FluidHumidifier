// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDistributionHeaderObjectFactory(Action<Humidifier.Lightsail.DistributionTypes.HeaderObject> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DistributionTypes.HeaderObject>
{

    protected override Humidifier.Lightsail.DistributionTypes.HeaderObject Create()
    {
        var headerObjectResult = CreateHeaderObject();
        factoryAction?.Invoke(headerObjectResult);

        return headerObjectResult;
    }

    private Humidifier.Lightsail.DistributionTypes.HeaderObject CreateHeaderObject()
    {
        var headerObjectResult = new Humidifier.Lightsail.DistributionTypes.HeaderObject();

        return headerObjectResult;
    }

} // End Of Class

public static class InnerDistributionHeaderObjectFactoryExtensions
{
}
