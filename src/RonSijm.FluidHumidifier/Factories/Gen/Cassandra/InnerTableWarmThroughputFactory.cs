// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableWarmThroughputFactory(Action<Humidifier.Cassandra.TableTypes.WarmThroughput> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.WarmThroughput>
{

    protected override Humidifier.Cassandra.TableTypes.WarmThroughput Create()
    {
        var warmThroughputResult = CreateWarmThroughput();
        factoryAction?.Invoke(warmThroughputResult);

        return warmThroughputResult;
    }

    private Humidifier.Cassandra.TableTypes.WarmThroughput CreateWarmThroughput()
    {
        var warmThroughputResult = new Humidifier.Cassandra.TableTypes.WarmThroughput();

        return warmThroughputResult;
    }

} // End Of Class

public static class InnerTableWarmThroughputFactoryExtensions
{
}
