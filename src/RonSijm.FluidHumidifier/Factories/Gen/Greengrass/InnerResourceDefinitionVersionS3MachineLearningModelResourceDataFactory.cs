// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.S3MachineLearningModelResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionVersionTypes.S3MachineLearningModelResourceData>
{

    internal InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory OwnerSettingFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionVersionTypes.S3MachineLearningModelResourceData Create()
    {
        var s3MachineLearningModelResourceDataResult = CreateS3MachineLearningModelResourceData();
        factoryAction?.Invoke(s3MachineLearningModelResourceDataResult);

        return s3MachineLearningModelResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionVersionTypes.S3MachineLearningModelResourceData CreateS3MachineLearningModelResourceData()
    {
        var s3MachineLearningModelResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionVersionTypes.S3MachineLearningModelResourceData();

        return s3MachineLearningModelResourceDataResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionVersionTypes.S3MachineLearningModelResourceData result)
    {
        base.CreateChildren(result);

        result.OwnerSetting ??= OwnerSettingFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting(this InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null)
    {
        parentFactory.OwnerSettingFactory = new InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OwnerSettingFactory);
    }

    public static CombinedResult<InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T1, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1>(this CombinedResult<InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1>(this CombinedResult<T1, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T1, T2, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T2, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T1, T2, T3, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T2, T3, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T3, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T1, T2, T3, T4, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T2, T3, T4, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T3, T4, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T4, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionS3MachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T5, subFactoryAction));
}
