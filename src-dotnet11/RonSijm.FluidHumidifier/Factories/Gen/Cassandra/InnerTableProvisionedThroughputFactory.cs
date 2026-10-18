// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableProvisionedThroughputFactory(Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.ProvisionedThroughput>
{

    protected override Humidifier.Cassandra.TableTypes.ProvisionedThroughput Create()
    {
        var provisionedThroughputResult = CreateProvisionedThroughput();
        factoryAction?.Invoke(provisionedThroughputResult);

        return provisionedThroughputResult;
    }

    private Humidifier.Cassandra.TableTypes.ProvisionedThroughput CreateProvisionedThroughput()
    {
        var provisionedThroughputResult = new Humidifier.Cassandra.TableTypes.ProvisionedThroughput();

        return provisionedThroughputResult;
    }

} // End Of Class

public static class InnerTableProvisionedThroughputFactoryExtensions
{
}
