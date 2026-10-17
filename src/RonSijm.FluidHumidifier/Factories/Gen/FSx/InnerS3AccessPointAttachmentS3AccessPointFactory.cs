// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerS3AccessPointAttachmentS3AccessPointFactory(Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPoint> factoryAction = null) : SubResourceFactory<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPoint>
{

    internal InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    protected override Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPoint Create()
    {
        var s3AccessPointResult = CreateS3AccessPoint();
        factoryAction?.Invoke(s3AccessPointResult);

        return s3AccessPointResult;
    }

    private Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPoint CreateS3AccessPoint()
    {
        var s3AccessPointResult = new Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPoint();

        return s3AccessPointResult;
    }
    public override void CreateChildren(Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPoint result)
    {
        base.CreateChildren(result);

        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerS3AccessPointAttachmentS3AccessPointFactoryExtensions
{
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointFactory, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration(this InnerS3AccessPointAttachmentS3AccessPointFactory parentFactory, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointFactory, T1, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointFactory, T1> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointFactory, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointFactory, T1, T2, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointFactory, T2, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointFactory, T2> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointFactory, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointFactory, T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointFactory, T2, T3, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointFactory, T3, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointFactory, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointFactory, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointFactory, T1, T2, T3, T4, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointFactory, T2, T3, T4, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointFactory, T3, T4, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointFactory, T4, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointFactory, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerS3AccessPointAttachmentS3AccessPointFactory, InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerS3AccessPointAttachmentS3AccessPointFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction).T2);
}
