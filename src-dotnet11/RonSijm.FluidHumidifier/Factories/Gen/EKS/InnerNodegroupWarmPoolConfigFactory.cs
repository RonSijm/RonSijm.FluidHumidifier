// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerNodegroupWarmPoolConfigFactory(Action<Humidifier.EKS.NodegroupTypes.WarmPoolConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.NodegroupTypes.WarmPoolConfig>
{

    protected override Humidifier.EKS.NodegroupTypes.WarmPoolConfig Create()
    {
        var warmPoolConfigResult = CreateWarmPoolConfig();
        factoryAction?.Invoke(warmPoolConfigResult);

        return warmPoolConfigResult;
    }

    private Humidifier.EKS.NodegroupTypes.WarmPoolConfig CreateWarmPoolConfig()
    {
        var warmPoolConfigResult = new Humidifier.EKS.NodegroupTypes.WarmPoolConfig();

        return warmPoolConfigResult;
    }

} // End Of Class

public static class InnerNodegroupWarmPoolConfigFactoryExtensions
{
}
