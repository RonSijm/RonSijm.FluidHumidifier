// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCapacityProviderCapacityReservationSpecificationFactory(Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationSpecification> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationSpecification>
{

    internal InnerCapacityProviderCapacityReservationTargetFactory CapacityReservationTargetFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationSpecification Create()
    {
        var capacityReservationSpecificationResult = CreateCapacityReservationSpecification();
        factoryAction?.Invoke(capacityReservationSpecificationResult);

        return capacityReservationSpecificationResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationSpecification CreateCapacityReservationSpecification()
    {
        var capacityReservationSpecificationResult = new Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationSpecification();

        return capacityReservationSpecificationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationSpecification result)
    {
        base.CreateChildren(result);

        result.CapacityReservationTarget ??= CapacityReservationTargetFactory?.Build();
    }

} // End Of Class

public static class InnerCapacityProviderCapacityReservationSpecificationFactoryExtensions
{
    public static CombinedResult<InnerCapacityProviderCapacityReservationSpecificationFactory, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget(this InnerCapacityProviderCapacityReservationSpecificationFactory parentFactory, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null)
    {
        parentFactory.CapacityReservationTargetFactory = new InnerCapacityProviderCapacityReservationTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationTargetFactory);
    }

    public static CombinedResult<InnerCapacityProviderCapacityReservationSpecificationFactory, T1, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1>(this CombinedResult<InnerCapacityProviderCapacityReservationSpecificationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderCapacityReservationSpecificationFactory, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1>(this CombinedResult<T1, InnerCapacityProviderCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderCapacityReservationSpecificationFactory, T1, T2, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<InnerCapacityProviderCapacityReservationSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderCapacityReservationSpecificationFactory, T2, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<T1, InnerCapacityProviderCapacityReservationSpecificationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderCapacityReservationSpecificationFactory, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<T1, T2, InnerCapacityProviderCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderCapacityReservationSpecificationFactory, T1, T2, T3, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<InnerCapacityProviderCapacityReservationSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderCapacityReservationSpecificationFactory, T2, T3, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, InnerCapacityProviderCapacityReservationSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderCapacityReservationSpecificationFactory, T3, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapacityProviderCapacityReservationSpecificationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderCapacityReservationSpecificationFactory, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapacityProviderCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderCapacityReservationSpecificationFactory, T1, T2, T3, T4, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<InnerCapacityProviderCapacityReservationSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderCapacityReservationSpecificationFactory, T2, T3, T4, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapacityProviderCapacityReservationSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderCapacityReservationSpecificationFactory, T3, T4, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapacityProviderCapacityReservationSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderCapacityReservationSpecificationFactory, T4, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapacityProviderCapacityReservationSpecificationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCapacityProviderCapacityReservationSpecificationFactory, InnerCapacityProviderCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapacityProviderCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T5, subFactoryAction).T2);
}
