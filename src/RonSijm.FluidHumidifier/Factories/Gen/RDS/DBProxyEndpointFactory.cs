// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBProxyEndpointFactory(string resourceName = null, Action<Humidifier.RDS.DBProxyEndpoint> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBProxyEndpoint>(resourceName)
{

    internal List<InnerDBProxyEndpointTagFormatFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.RDS.DBProxyEndpoint Create()
    {
        var dBProxyEndpointResult = CreateDBProxyEndpoint();
        factoryAction?.Invoke(dBProxyEndpointResult);

        return dBProxyEndpointResult;
    }

    private Humidifier.RDS.DBProxyEndpoint CreateDBProxyEndpoint()
    {
        var dBProxyEndpointResult = new Humidifier.RDS.DBProxyEndpoint
        {
            GivenName = InputResourceName,
        };

        return dBProxyEndpointResult;
    }
    public override void CreateChildren(Humidifier.RDS.DBProxyEndpoint result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DBProxyEndpointFactoryExtensions
{
    public static CombinedResult<DBProxyEndpointFactory, InnerDBProxyEndpointTagFormatFactory> WithTags(this DBProxyEndpointFactory parentFactory, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null)
    {
        var factory = new InnerDBProxyEndpointTagFormatFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DBProxyEndpointFactory, T1, InnerDBProxyEndpointTagFormatFactory> WithTags<T1>(this CombinedResult<DBProxyEndpointFactory, T1> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyEndpointFactory, InnerDBProxyEndpointTagFormatFactory> WithTags<T1>(this CombinedResult<T1, DBProxyEndpointFactory> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DBProxyEndpointFactory, T1, T2, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2>(this CombinedResult<DBProxyEndpointFactory, T1, T2> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyEndpointFactory, T2, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2>(this CombinedResult<T1, DBProxyEndpointFactory, T2> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyEndpointFactory, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, DBProxyEndpointFactory> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DBProxyEndpointFactory, T1, T2, T3, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2, T3>(this CombinedResult<DBProxyEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyEndpointFactory, T2, T3, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, DBProxyEndpointFactory, T2, T3> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyEndpointFactory, T3, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, DBProxyEndpointFactory, T3> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBProxyEndpointFactory, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, DBProxyEndpointFactory> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DBProxyEndpointFactory, T1, T2, T3, T4, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<DBProxyEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyEndpointFactory, T2, T3, T4, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, DBProxyEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyEndpointFactory, T3, T4, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, DBProxyEndpointFactory, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBProxyEndpointFactory, T4, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DBProxyEndpointFactory, T4> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DBProxyEndpointFactory, InnerDBProxyEndpointTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DBProxyEndpointFactory> combinedResult, Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
