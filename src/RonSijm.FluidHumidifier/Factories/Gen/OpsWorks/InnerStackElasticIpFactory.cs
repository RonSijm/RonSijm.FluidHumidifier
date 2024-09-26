// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerStackElasticIpFactory(Action<Humidifier.OpsWorks.StackTypes.ElasticIp> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.StackTypes.ElasticIp>
{

    protected override Humidifier.OpsWorks.StackTypes.ElasticIp Create()
    {
        var elasticIpResult = CreateElasticIp();
        factoryAction?.Invoke(elasticIpResult);

        return elasticIpResult;
    }

    private Humidifier.OpsWorks.StackTypes.ElasticIp CreateElasticIp()
    {
        var elasticIpResult = new Humidifier.OpsWorks.StackTypes.ElasticIp();

        return elasticIpResult;
    }

} // End Of Class

public static class InnerStackElasticIpFactoryExtensions
{
}
