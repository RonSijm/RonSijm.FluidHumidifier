// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetCidrRoutingConfigFactory(Action<Humidifier.Route53.RecordSetTypes.CidrRoutingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetTypes.CidrRoutingConfig>
{

    protected override Humidifier.Route53.RecordSetTypes.CidrRoutingConfig Create()
    {
        var cidrRoutingConfigResult = CreateCidrRoutingConfig();
        factoryAction?.Invoke(cidrRoutingConfigResult);

        return cidrRoutingConfigResult;
    }

    private Humidifier.Route53.RecordSetTypes.CidrRoutingConfig CreateCidrRoutingConfig()
    {
        var cidrRoutingConfigResult = new Humidifier.Route53.RecordSetTypes.CidrRoutingConfig();

        return cidrRoutingConfigResult;
    }

} // End Of Class

public static class InnerRecordSetCidrRoutingConfigFactoryExtensions
{
}
