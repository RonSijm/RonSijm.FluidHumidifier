// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterRollbackConfigFactory(Action<Humidifier.EKS.ClusterTypes.RollbackConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.RollbackConfig>
{

    protected override Humidifier.EKS.ClusterTypes.RollbackConfig Create()
    {
        var rollbackConfigResult = CreateRollbackConfig();
        factoryAction?.Invoke(rollbackConfigResult);

        return rollbackConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.RollbackConfig CreateRollbackConfig()
    {
        var rollbackConfigResult = new Humidifier.EKS.ClusterTypes.RollbackConfig();

        return rollbackConfigResult;
    }

} // End Of Class

public static class InnerClusterRollbackConfigFactoryExtensions
{
}
