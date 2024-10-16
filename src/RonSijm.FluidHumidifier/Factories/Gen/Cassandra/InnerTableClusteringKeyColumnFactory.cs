// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableClusteringKeyColumnFactory(Action<Humidifier.Cassandra.TableTypes.ClusteringKeyColumn> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.ClusteringKeyColumn>
{

    internal InnerTableColumnFactory ColumnFactory { get; set; }

    protected override Humidifier.Cassandra.TableTypes.ClusteringKeyColumn Create()
    {
        var clusteringKeyColumnResult = CreateClusteringKeyColumn();
        factoryAction?.Invoke(clusteringKeyColumnResult);

        return clusteringKeyColumnResult;
    }

    private Humidifier.Cassandra.TableTypes.ClusteringKeyColumn CreateClusteringKeyColumn()
    {
        var clusteringKeyColumnResult = new Humidifier.Cassandra.TableTypes.ClusteringKeyColumn();

        return clusteringKeyColumnResult;
    }
    public override void CreateChildren(Humidifier.Cassandra.TableTypes.ClusteringKeyColumn result)
    {
        base.CreateChildren(result);

        result.Column ??= ColumnFactory?.Build();
    }

} // End Of Class

public static class InnerTableClusteringKeyColumnFactoryExtensions
{
    public static CombinedResult<InnerTableClusteringKeyColumnFactory, InnerTableColumnFactory> WithColumn(this InnerTableClusteringKeyColumnFactory parentFactory, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null)
    {
        parentFactory.ColumnFactory = new InnerTableColumnFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ColumnFactory);
    }

    public static CombinedResult<InnerTableClusteringKeyColumnFactory, T1, InnerTableColumnFactory> WithColumn<T1>(this CombinedResult<InnerTableClusteringKeyColumnFactory, T1> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableClusteringKeyColumnFactory, InnerTableColumnFactory> WithColumn<T1>(this CombinedResult<T1, InnerTableClusteringKeyColumnFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableClusteringKeyColumnFactory, T1, T2, InnerTableColumnFactory> WithColumn<T1, T2>(this CombinedResult<InnerTableClusteringKeyColumnFactory, T1, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableClusteringKeyColumnFactory, T2, InnerTableColumnFactory> WithColumn<T1, T2>(this CombinedResult<T1, InnerTableClusteringKeyColumnFactory, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableClusteringKeyColumnFactory, InnerTableColumnFactory> WithColumn<T1, T2>(this CombinedResult<T1, T2, InnerTableClusteringKeyColumnFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableClusteringKeyColumnFactory, T1, T2, T3, InnerTableColumnFactory> WithColumn<T1, T2, T3>(this CombinedResult<InnerTableClusteringKeyColumnFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableClusteringKeyColumnFactory, T2, T3, InnerTableColumnFactory> WithColumn<T1, T2, T3>(this CombinedResult<T1, InnerTableClusteringKeyColumnFactory, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableClusteringKeyColumnFactory, T3, InnerTableColumnFactory> WithColumn<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableClusteringKeyColumnFactory, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableClusteringKeyColumnFactory, InnerTableColumnFactory> WithColumn<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableClusteringKeyColumnFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableClusteringKeyColumnFactory, T1, T2, T3, T4, InnerTableColumnFactory> WithColumn<T1, T2, T3, T4>(this CombinedResult<InnerTableClusteringKeyColumnFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableClusteringKeyColumnFactory, T2, T3, T4, InnerTableColumnFactory> WithColumn<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableClusteringKeyColumnFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableClusteringKeyColumnFactory, T3, T4, InnerTableColumnFactory> WithColumn<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableClusteringKeyColumnFactory, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableClusteringKeyColumnFactory, T4, InnerTableColumnFactory> WithColumn<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableClusteringKeyColumnFactory, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableClusteringKeyColumnFactory, InnerTableColumnFactory> WithColumn<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableClusteringKeyColumnFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.Column> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumn(combinedResult.T5, subFactoryAction));
}
