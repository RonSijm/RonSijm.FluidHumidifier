// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.SageMakerMachineLearningModelResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionVersionTypes.SageMakerMachineLearningModelResourceData>
{

    internal InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory OwnerSettingFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionVersionTypes.SageMakerMachineLearningModelResourceData Create()
    {
        var sageMakerMachineLearningModelResourceDataResult = CreateSageMakerMachineLearningModelResourceData();
        factoryAction?.Invoke(sageMakerMachineLearningModelResourceDataResult);

        return sageMakerMachineLearningModelResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionVersionTypes.SageMakerMachineLearningModelResourceData CreateSageMakerMachineLearningModelResourceData()
    {
        var sageMakerMachineLearningModelResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionVersionTypes.SageMakerMachineLearningModelResourceData();

        return sageMakerMachineLearningModelResourceDataResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionVersionTypes.SageMakerMachineLearningModelResourceData result)
    {
        base.CreateChildren(result);

        result.OwnerSetting ??= OwnerSettingFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting(this InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null)
    {
        parentFactory.OwnerSettingFactory = new InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OwnerSettingFactory);
    }

    public static CombinedResult<InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T1, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1>(this CombinedResult<InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1>(this CombinedResult<T1, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T1, T2, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T2, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T1, T2, T3, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T2, T3, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T3, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T1, T2, T3, T4, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T2, T3, T4, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T3, T4, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T4, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionSageMakerMachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T5, subFactoryAction));
}
