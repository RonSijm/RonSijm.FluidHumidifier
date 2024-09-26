// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBProxyTargetGroupFactory(string resourceName = null, Action<Humidifier.RDS.DBProxyTargetGroup> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBProxyTargetGroup>(resourceName)
{

    internal InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory ConnectionPoolConfigurationInfoFactory { get; set; }

    protected override Humidifier.RDS.DBProxyTargetGroup Create()
    {
        var dBProxyTargetGroupResult = CreateDBProxyTargetGroup();
        factoryAction?.Invoke(dBProxyTargetGroupResult);

        return dBProxyTargetGroupResult;
    }

    private Humidifier.RDS.DBProxyTargetGroup CreateDBProxyTargetGroup()
    {
        var dBProxyTargetGroupResult = new Humidifier.RDS.DBProxyTargetGroup
        {
            GivenName = InputResourceName,
        };

        return dBProxyTargetGroupResult;
    }
    public override void CreateChildren(Humidifier.RDS.DBProxyTargetGroup result)
    {
        base.CreateChildren(result);

        result.ConnectionPoolConfigurationInfo ??= ConnectionPoolConfigurationInfoFactory?.Build();
    }

} // End Of Class

public static class DBProxyTargetGroupFactoryExtensions
{
    public static CombinedResult<DBProxyTargetGroupFactory, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo(this DBProxyTargetGroupFactory parentFactory, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null)
    {
        parentFactory.ConnectionPoolConfigurationInfoFactory = new InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectionPoolConfigurationInfoFactory);
    }

    public static CombinedResult<DBProxyTargetGroupFactory, T1, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1>(this CombinedResult<DBProxyTargetGroupFactory, T1> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyTargetGroupFactory, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1>(this CombinedResult<T1, DBProxyTargetGroupFactory> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DBProxyTargetGroupFactory, T1, T2, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2>(this CombinedResult<DBProxyTargetGroupFactory, T1, T2> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyTargetGroupFactory, T2, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2>(this CombinedResult<T1, DBProxyTargetGroupFactory, T2> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyTargetGroupFactory, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2>(this CombinedResult<T1, T2, DBProxyTargetGroupFactory> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DBProxyTargetGroupFactory, T1, T2, T3, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2, T3>(this CombinedResult<DBProxyTargetGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyTargetGroupFactory, T2, T3, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2, T3>(this CombinedResult<T1, DBProxyTargetGroupFactory, T2, T3> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyTargetGroupFactory, T3, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2, T3>(this CombinedResult<T1, T2, DBProxyTargetGroupFactory, T3> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBProxyTargetGroupFactory, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, DBProxyTargetGroupFactory> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DBProxyTargetGroupFactory, T1, T2, T3, T4, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2, T3, T4>(this CombinedResult<DBProxyTargetGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyTargetGroupFactory, T2, T3, T4, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2, T3, T4>(this CombinedResult<T1, DBProxyTargetGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyTargetGroupFactory, T3, T4, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, DBProxyTargetGroupFactory, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBProxyTargetGroupFactory, T4, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DBProxyTargetGroupFactory, T4> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DBProxyTargetGroupFactory, InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory> WithConnectionPoolConfigurationInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DBProxyTargetGroupFactory> combinedResult, Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionPoolConfigurationInfo(combinedResult.T5, subFactoryAction));
}
