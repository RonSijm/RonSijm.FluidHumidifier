// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.SageMakerMachineLearningModelResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.SageMakerMachineLearningModelResourceData>
{

    internal InnerResourceDefinitionResourceDownloadOwnerSettingFactory OwnerSettingFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.SageMakerMachineLearningModelResourceData Create()
    {
        var sageMakerMachineLearningModelResourceDataResult = CreateSageMakerMachineLearningModelResourceData();
        factoryAction?.Invoke(sageMakerMachineLearningModelResourceDataResult);

        return sageMakerMachineLearningModelResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.SageMakerMachineLearningModelResourceData CreateSageMakerMachineLearningModelResourceData()
    {
        var sageMakerMachineLearningModelResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionTypes.SageMakerMachineLearningModelResourceData();

        return sageMakerMachineLearningModelResourceDataResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionTypes.SageMakerMachineLearningModelResourceData result)
    {
        base.CreateChildren(result);

        result.OwnerSetting ??= OwnerSettingFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting(this InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null)
    {
        parentFactory.OwnerSettingFactory = new InnerResourceDefinitionResourceDownloadOwnerSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OwnerSettingFactory);
    }

    public static CombinedResult<InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T1, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1>(this CombinedResult<InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1>(this CombinedResult<T1, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T1, T2, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T2, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T1, T2, T3, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T2, T3, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T3, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T1, T2, T3, T4, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T2, T3, T4, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T3, T4, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T4, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory, InnerResourceDefinitionResourceDownloadOwnerSettingFactory> WithOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionSageMakerMachineLearningModelResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnerSetting(combinedResult.T5, subFactoryAction));
}
