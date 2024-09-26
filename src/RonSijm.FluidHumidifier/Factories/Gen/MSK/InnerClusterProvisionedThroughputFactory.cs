// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterProvisionedThroughputFactory(Action<Humidifier.MSK.ClusterTypes.ProvisionedThroughput> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.ProvisionedThroughput>
{

    protected override Humidifier.MSK.ClusterTypes.ProvisionedThroughput Create()
    {
        var provisionedThroughputResult = CreateProvisionedThroughput();
        factoryAction?.Invoke(provisionedThroughputResult);

        return provisionedThroughputResult;
    }

    private Humidifier.MSK.ClusterTypes.ProvisionedThroughput CreateProvisionedThroughput()
    {
        var provisionedThroughputResult = new Humidifier.MSK.ClusterTypes.ProvisionedThroughput();

        return provisionedThroughputResult;
    }

} // End Of Class

public static class InnerClusterProvisionedThroughputFactoryExtensions
{
}
