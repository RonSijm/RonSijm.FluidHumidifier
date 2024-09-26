// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerGatewayGreengrassFactory(Action<Humidifier.IoTSiteWise.GatewayTypes.Greengrass> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.GatewayTypes.Greengrass>
{

    protected override Humidifier.IoTSiteWise.GatewayTypes.Greengrass Create()
    {
        var greengrassResult = CreateGreengrass();
        factoryAction?.Invoke(greengrassResult);

        return greengrassResult;
    }

    private Humidifier.IoTSiteWise.GatewayTypes.Greengrass CreateGreengrass()
    {
        var greengrassResult = new Humidifier.IoTSiteWise.GatewayTypes.Greengrass();

        return greengrassResult;
    }

} // End Of Class

public static class InnerGatewayGreengrassFactoryExtensions
{
}
