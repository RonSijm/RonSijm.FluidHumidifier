// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBProxyFactory(string resourceName = null, Action<Humidifier.RDS.DBProxy> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBProxy>(resourceName)
{

    internal List<InnerDBProxyAuthFormatFactory> AuthFactories { get; set; } = [];

    internal List<InnerDBProxyTagFormatFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.RDS.DBProxy Create()
    {
        var dBProxyResult = CreateDBProxy();
        factoryAction?.Invoke(dBProxyResult);

        return dBProxyResult;
    }

    private Humidifier.RDS.DBProxy CreateDBProxy()
    {
        var dBProxyResult = new Humidifier.RDS.DBProxy
        {
            GivenName = InputResourceName,
        };

        return dBProxyResult;
    }
    public override void CreateChildren(Humidifier.RDS.DBProxy result)
    {
        base.CreateChildren(result);

        result.Auth = AuthFactories.Any() ? AuthFactories.Select(x => x.Build()).ToList() : null;
        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DBProxyFactoryExtensions
{
    public static CombinedResult<DBProxyFactory, InnerDBProxyAuthFormatFactory> WithAuth(this DBProxyFactory parentFactory, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null)
    {
        var factory = new InnerDBProxyAuthFormatFactory(subFactoryAction);
        parentFactory.AuthFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DBProxyFactory, InnerDBProxyTagFormatFactory> WithTags(this DBProxyFactory parentFactory, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null)
    {
        var factory = new InnerDBProxyTagFormatFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DBProxyFactory, T1, InnerDBProxyAuthFormatFactory> WithAuth<T1>(this CombinedResult<DBProxyFactory, T1> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyFactory, InnerDBProxyAuthFormatFactory> WithAuth<T1>(this CombinedResult<T1, DBProxyFactory> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DBProxyFactory, T1, T2, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2>(this CombinedResult<DBProxyFactory, T1, T2> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyFactory, T2, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2>(this CombinedResult<T1, DBProxyFactory, T2> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyFactory, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2>(this CombinedResult<T1, T2, DBProxyFactory> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DBProxyFactory, T1, T2, T3, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2, T3>(this CombinedResult<DBProxyFactory, T1, T2, T3> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyFactory, T2, T3, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, DBProxyFactory, T2, T3> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyFactory, T3, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, T2, DBProxyFactory, T3> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBProxyFactory, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, T2, T3, DBProxyFactory> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DBProxyFactory, T1, T2, T3, T4, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<DBProxyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyFactory, T2, T3, T4, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, DBProxyFactory, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyFactory, T3, T4, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, DBProxyFactory, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBProxyFactory, T4, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DBProxyFactory, T4> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DBProxyFactory, InnerDBProxyAuthFormatFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DBProxyFactory> combinedResult, Action<Humidifier.RDS.DBProxyTypes.AuthFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DBProxyFactory, T1, InnerDBProxyTagFormatFactory> WithTags<T1>(this CombinedResult<DBProxyFactory, T1> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyFactory, InnerDBProxyTagFormatFactory> WithTags<T1>(this CombinedResult<T1, DBProxyFactory> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DBProxyFactory, T1, T2, InnerDBProxyTagFormatFactory> WithTags<T1, T2>(this CombinedResult<DBProxyFactory, T1, T2> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyFactory, T2, InnerDBProxyTagFormatFactory> WithTags<T1, T2>(this CombinedResult<T1, DBProxyFactory, T2> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyFactory, InnerDBProxyTagFormatFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, DBProxyFactory> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DBProxyFactory, T1, T2, T3, InnerDBProxyTagFormatFactory> WithTags<T1, T2, T3>(this CombinedResult<DBProxyFactory, T1, T2, T3> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyFactory, T2, T3, InnerDBProxyTagFormatFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, DBProxyFactory, T2, T3> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyFactory, T3, InnerDBProxyTagFormatFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, DBProxyFactory, T3> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBProxyFactory, InnerDBProxyTagFormatFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, DBProxyFactory> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DBProxyFactory, T1, T2, T3, T4, InnerDBProxyTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<DBProxyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBProxyFactory, T2, T3, T4, InnerDBProxyTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, DBProxyFactory, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBProxyFactory, T3, T4, InnerDBProxyTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, DBProxyFactory, T3, T4> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBProxyFactory, T4, InnerDBProxyTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DBProxyFactory, T4> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DBProxyFactory, InnerDBProxyTagFormatFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DBProxyFactory> combinedResult, Action<Humidifier.RDS.DBProxyTypes.TagFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
