// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetGroupCidrRoutingConfigFactory(Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig>
{

    protected override Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig Create()
    {
        var cidrRoutingConfigResult = CreateCidrRoutingConfig();
        factoryAction?.Invoke(cidrRoutingConfigResult);

        return cidrRoutingConfigResult;
    }

    private Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig CreateCidrRoutingConfig()
    {
        var cidrRoutingConfigResult = new Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig();

        return cidrRoutingConfigResult;
    }

} // End Of Class

public static class InnerRecordSetGroupCidrRoutingConfigFactoryExtensions
{
}
