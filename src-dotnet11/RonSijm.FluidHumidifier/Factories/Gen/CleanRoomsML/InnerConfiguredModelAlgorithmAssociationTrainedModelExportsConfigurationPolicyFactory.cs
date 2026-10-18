// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory(Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsConfigurationPolicy> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsConfigurationPolicy>
{

    internal InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory MaxSizeFactory { get; set; }

    protected override Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsConfigurationPolicy Create()
    {
        var trainedModelExportsConfigurationPolicyResult = CreateTrainedModelExportsConfigurationPolicy();
        factoryAction?.Invoke(trainedModelExportsConfigurationPolicyResult);

        return trainedModelExportsConfigurationPolicyResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsConfigurationPolicy CreateTrainedModelExportsConfigurationPolicy()
    {
        var trainedModelExportsConfigurationPolicyResult = new Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsConfigurationPolicy();

        return trainedModelExportsConfigurationPolicyResult;
    }
    public override void CreateChildren(Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsConfigurationPolicy result)
    {
        base.CreateChildren(result);

        result.MaxSize ??= MaxSizeFactory?.Build();
    }

} // End Of Class

public static class InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactoryExtensions
{
    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize(this InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory parentFactory, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null)
    {
        parentFactory.MaxSizeFactory = new InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaxSizeFactory);
    }

    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T1, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1>(this CombinedResult<InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T1> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaxSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1>(this CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaxSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T1, T2, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2>(this CombinedResult<InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T1, T2> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T2, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2>(this CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T2> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T1, T2, T3, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2, T3>(this CombinedResult<InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T2, T3, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T3, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T3> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T1, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T3, T4, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T4, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory> WithMaxSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationTrainedModelExportsConfigurationPolicyFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaxSize(combinedResult.T5, subFactoryAction).T2);
}
