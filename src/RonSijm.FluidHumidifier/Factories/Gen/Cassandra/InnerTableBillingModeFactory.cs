// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableBillingModeFactory(Action<Humidifier.Cassandra.TableTypes.BillingMode> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.BillingMode>
{

    internal InnerTableProvisionedThroughputFactory ProvisionedThroughputFactory { get; set; }

    protected override Humidifier.Cassandra.TableTypes.BillingMode Create()
    {
        var billingModeResult = CreateBillingMode();
        factoryAction?.Invoke(billingModeResult);

        return billingModeResult;
    }

    private Humidifier.Cassandra.TableTypes.BillingMode CreateBillingMode()
    {
        var billingModeResult = new Humidifier.Cassandra.TableTypes.BillingMode();

        return billingModeResult;
    }
    public override void CreateChildren(Humidifier.Cassandra.TableTypes.BillingMode result)
    {
        base.CreateChildren(result);

        result.ProvisionedThroughput ??= ProvisionedThroughputFactory?.Build();
    }

} // End Of Class

public static class InnerTableBillingModeFactoryExtensions
{
    public static CombinedResult<InnerTableBillingModeFactory, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput(this InnerTableBillingModeFactory parentFactory, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null)
    {
        parentFactory.ProvisionedThroughputFactory = new InnerTableProvisionedThroughputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProvisionedThroughputFactory);
    }

    public static CombinedResult<InnerTableBillingModeFactory, T1, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1>(this CombinedResult<InnerTableBillingModeFactory, T1> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableBillingModeFactory, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1>(this CombinedResult<T1, InnerTableBillingModeFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableBillingModeFactory, T1, T2, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2>(this CombinedResult<InnerTableBillingModeFactory, T1, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableBillingModeFactory, T2, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2>(this CombinedResult<T1, InnerTableBillingModeFactory, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableBillingModeFactory, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2>(this CombinedResult<T1, T2, InnerTableBillingModeFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableBillingModeFactory, T1, T2, T3, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3>(this CombinedResult<InnerTableBillingModeFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableBillingModeFactory, T2, T3, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3>(this CombinedResult<T1, InnerTableBillingModeFactory, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableBillingModeFactory, T3, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableBillingModeFactory, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableBillingModeFactory, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableBillingModeFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableBillingModeFactory, T1, T2, T3, T4, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<InnerTableBillingModeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableBillingModeFactory, T2, T3, T4, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableBillingModeFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableBillingModeFactory, T3, T4, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableBillingModeFactory, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableBillingModeFactory, T4, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableBillingModeFactory, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableBillingModeFactory, InnerTableProvisionedThroughputFactory> WithProvisionedThroughput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableBillingModeFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.ProvisionedThroughput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedThroughput(combinedResult.T5, subFactoryAction));
}
