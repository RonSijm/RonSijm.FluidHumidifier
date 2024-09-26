// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionS3MachineLearningModelResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.S3MachineLearningModelResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.S3MachineLearningModelResourceData>
{

    internal InnerResourceDefinitionResourceDownloadOwnerSettingFactory OwnerSettingFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.S3MachineLearningModelResourceData Create()
    {
        var s3MachineLearningModelResourceDataResult = CreateS3MachineLearningModelResourceData();
        factoryAction?.Invoke(s3MachineLearningModelResourceDataResult);

        return s3MachineLearningModelResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.S3MachineLearningModelResourceData CreateS3MachineLearningModelResourceData()
    {
        var s3MachineLearningModelResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionTypes.S3MachineLearningModelResourceData();

        return s3MachineLearningModelResourceDataResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionTypes.S3MachineLearningModelResourceData result)
    {
        base.CreateChildren(result);

        result.OwnerSetting ??= OwnerSettingFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionS3MachineLearningModelResourceDataFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting(this InnerResourceDefinitionS3MachineLearningModelResourceDataFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null)
    {
        parentFactory.OwnerSettingFactory = new InnerResourceDefinitionResourceDownloadOwnerSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OwnerSettingFactory);
    }

    public static CombinedResult<InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T1, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1>(this CombinedResult<InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1>(this CombinedResult<T1, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T1, T2, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T2, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T1, T2, T3, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T2, T3, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T3, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T1, T2, T3, T4, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T2, T3, T4, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T3, T4, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T4, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionS3MachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T5, subFactoryAction));
}
