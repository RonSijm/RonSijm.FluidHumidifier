// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerPluginAPISchemaFactory(Action<Humidifier.QBusiness.PluginTypes.APISchema> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.PluginTypes.APISchema>
{

    internal InnerPluginS3Factory S3Factory { get; set; }

    protected override Humidifier.QBusiness.PluginTypes.APISchema Create()
    {
        var aPISchemaResult = CreateAPISchema();
        factoryAction?.Invoke(aPISchemaResult);

        return aPISchemaResult;
    }

    private Humidifier.QBusiness.PluginTypes.APISchema CreateAPISchema()
    {
        var aPISchemaResult = new Humidifier.QBusiness.PluginTypes.APISchema();

        return aPISchemaResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.PluginTypes.APISchema result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerPluginAPISchemaFactoryExtensions
{
    public static CombinedResult<InnerPluginAPISchemaFactory, InnerPluginS3Factory> WithS3(this InnerPluginAPISchemaFactory parentFactory, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerPluginS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerPluginAPISchemaFactory, T1, InnerPluginS3Factory> WithS3<T1>(this CombinedResult<InnerPluginAPISchemaFactory, T1> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPluginAPISchemaFactory, InnerPluginS3Factory> WithS3<T1>(this CombinedResult<T1, InnerPluginAPISchemaFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPluginAPISchemaFactory, T1, T2, InnerPluginS3Factory> WithS3<T1, T2>(this CombinedResult<InnerPluginAPISchemaFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPluginAPISchemaFactory, T2, InnerPluginS3Factory> WithS3<T1, T2>(this CombinedResult<T1, InnerPluginAPISchemaFactory, T2> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPluginAPISchemaFactory, InnerPluginS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerPluginAPISchemaFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPluginAPISchemaFactory, T1, T2, T3, InnerPluginS3Factory> WithS3<T1, T2, T3>(this CombinedResult<InnerPluginAPISchemaFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPluginAPISchemaFactory, T2, T3, InnerPluginS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerPluginAPISchemaFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPluginAPISchemaFactory, T3, InnerPluginS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerPluginAPISchemaFactory, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPluginAPISchemaFactory, InnerPluginS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPluginAPISchemaFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPluginAPISchemaFactory, T1, T2, T3, T4, InnerPluginS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerPluginAPISchemaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPluginAPISchemaFactory, T2, T3, T4, InnerPluginS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerPluginAPISchemaFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPluginAPISchemaFactory, T3, T4, InnerPluginS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPluginAPISchemaFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPluginAPISchemaFactory, T4, InnerPluginS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPluginAPISchemaFactory, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPluginAPISchemaFactory, InnerPluginS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPluginAPISchemaFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
