// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerGatewayGreengrassV2Factory(Action<Humidifier.IoTSiteWise.GatewayTypes.GreengrassV2> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.GatewayTypes.GreengrassV2>
{

    protected override Humidifier.IoTSiteWise.GatewayTypes.GreengrassV2 Create()
    {
        var greengrassV2Result = CreateGreengrassV2();
        factoryAction?.Invoke(greengrassV2Result);

        return greengrassV2Result;
    }

    private Humidifier.IoTSiteWise.GatewayTypes.GreengrassV2 CreateGreengrassV2()
    {
        var greengrassV2Result = new Humidifier.IoTSiteWise.GatewayTypes.GreengrassV2();

        return greengrassV2Result;
    }

} // End Of Class

public static class InnerGatewayGreengrassV2FactoryExtensions
{
}
