// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionRevisionCodeConfigFactory(Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig>
{

    internal InnerWebFunctionRevisionS3ObjectFactory S3ObjectFactory { get; set; }

    protected override Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig Create()
    {
        var codeConfigResult = CreateCodeConfig();
        factoryAction?.Invoke(codeConfigResult);

        return codeConfigResult;
    }

    private Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig CreateCodeConfig()
    {
        var codeConfigResult = new Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig();

        return codeConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig result)
    {
        base.CreateChildren(result);

        result.S3Object ??= S3ObjectFactory?.Build();
    }

} // End Of Class

public static class InnerWebFunctionRevisionCodeConfigFactoryExtensions
{
    public static CombinedResult<InnerWebFunctionRevisionCodeConfigFactory, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object(this InnerWebFunctionRevisionCodeConfigFactory parentFactory, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null)
    {
        parentFactory.S3ObjectFactory = new InnerWebFunctionRevisionS3ObjectFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ObjectFactory);
    }

    public static CombinedResult<InnerWebFunctionRevisionCodeConfigFactory, T1, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1>(this CombinedResult<InnerWebFunctionRevisionCodeConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Object(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionCodeConfigFactory, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1>(this CombinedResult<T1, InnerWebFunctionRevisionCodeConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Object(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionCodeConfigFactory, T1, T2, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2>(this CombinedResult<InnerWebFunctionRevisionCodeConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionCodeConfigFactory, T2, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2>(this CombinedResult<T1, InnerWebFunctionRevisionCodeConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionCodeConfigFactory, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2>(this CombinedResult<T1, T2, InnerWebFunctionRevisionCodeConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionCodeConfigFactory, T1, T2, T3, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2, T3>(this CombinedResult<InnerWebFunctionRevisionCodeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionCodeConfigFactory, T2, T3, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2, T3>(this CombinedResult<T1, InnerWebFunctionRevisionCodeConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionCodeConfigFactory, T3, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebFunctionRevisionCodeConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionCodeConfigFactory, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionCodeConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionCodeConfigFactory, T1, T2, T3, T4, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2, T3, T4>(this CombinedResult<InnerWebFunctionRevisionCodeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionCodeConfigFactory, T2, T3, T4, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebFunctionRevisionCodeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionCodeConfigFactory, T3, T4, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebFunctionRevisionCodeConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionCodeConfigFactory, T4, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionCodeConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionCodeConfigFactory, InnerWebFunctionRevisionS3ObjectFactory> WithS3Object<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionCodeConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Object(combinedResult.T5, subFactoryAction).T2);
}
