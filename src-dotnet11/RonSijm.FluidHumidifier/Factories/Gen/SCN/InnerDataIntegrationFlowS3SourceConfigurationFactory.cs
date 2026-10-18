// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowS3SourceConfigurationFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.S3SourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.S3SourceConfiguration>
{

    internal InnerDataIntegrationFlowS3OptionsFactory OptionsFactory { get; set; }

    protected override Humidifier.SCN.DataIntegrationFlowTypes.S3SourceConfiguration Create()
    {
        var s3SourceConfigurationResult = CreateS3SourceConfiguration();
        factoryAction?.Invoke(s3SourceConfigurationResult);

        return s3SourceConfigurationResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.S3SourceConfiguration CreateS3SourceConfiguration()
    {
        var s3SourceConfigurationResult = new Humidifier.SCN.DataIntegrationFlowTypes.S3SourceConfiguration();

        return s3SourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SCN.DataIntegrationFlowTypes.S3SourceConfiguration result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDataIntegrationFlowS3SourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataIntegrationFlowS3SourceConfigurationFactory, InnerDataIntegrationFlowS3OptionsFactory> WithOptions(this InnerDataIntegrationFlowS3SourceConfigurationFactory parentFactory, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerDataIntegrationFlowS3OptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<InnerDataIntegrationFlowS3SourceConfigurationFactory, T1, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1>(this CombinedResult<InnerDataIntegrationFlowS3SourceConfigurationFactory, T1> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowS3SourceConfigurationFactory, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1>(this CombinedResult<T1, InnerDataIntegrationFlowS3SourceConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowS3SourceConfigurationFactory, T1, T2, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2>(this CombinedResult<InnerDataIntegrationFlowS3SourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowS3SourceConfigurationFactory, T2, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, InnerDataIntegrationFlowS3SourceConfigurationFactory, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowS3SourceConfigurationFactory, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, InnerDataIntegrationFlowS3SourceConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowS3SourceConfigurationFactory, T1, T2, T3, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<InnerDataIntegrationFlowS3SourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowS3SourceConfigurationFactory, T2, T3, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, InnerDataIntegrationFlowS3SourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowS3SourceConfigurationFactory, T3, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataIntegrationFlowS3SourceConfigurationFactory, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowS3SourceConfigurationFactory, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowS3SourceConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowS3SourceConfigurationFactory, T1, T2, T3, T4, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<InnerDataIntegrationFlowS3SourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowS3SourceConfigurationFactory, T2, T3, T4, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataIntegrationFlowS3SourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowS3SourceConfigurationFactory, T3, T4, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataIntegrationFlowS3SourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowS3SourceConfigurationFactory, T4, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowS3SourceConfigurationFactory, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowS3SourceConfigurationFactory, InnerDataIntegrationFlowS3OptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowS3SourceConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction).T2);
}
