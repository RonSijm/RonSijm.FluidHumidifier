// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerVehicleStateTemplateAssociationFactory(Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation>
{

    internal InnerVehicleStateTemplateUpdateStrategyFactory StateTemplateUpdateStrategyFactory { get; set; }

    protected override Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation Create()
    {
        var stateTemplateAssociationResult = CreateStateTemplateAssociation();
        factoryAction?.Invoke(stateTemplateAssociationResult);

        return stateTemplateAssociationResult;
    }

    private Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation CreateStateTemplateAssociation()
    {
        var stateTemplateAssociationResult = new Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation();

        return stateTemplateAssociationResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation result)
    {
        base.CreateChildren(result);

        result.StateTemplateUpdateStrategy ??= StateTemplateUpdateStrategyFactory?.Build();
    }

} // End Of Class

public static class InnerVehicleStateTemplateAssociationFactoryExtensions
{
    public static CombinedResult<InnerVehicleStateTemplateAssociationFactory, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy(this InnerVehicleStateTemplateAssociationFactory parentFactory, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null)
    {
        parentFactory.StateTemplateUpdateStrategyFactory = new InnerVehicleStateTemplateUpdateStrategyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StateTemplateUpdateStrategyFactory);
    }

    public static CombinedResult<InnerVehicleStateTemplateAssociationFactory, T1, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1>(this CombinedResult<InnerVehicleStateTemplateAssociationFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehicleStateTemplateAssociationFactory, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1>(this CombinedResult<T1, InnerVehicleStateTemplateAssociationFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerVehicleStateTemplateAssociationFactory, T1, T2, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2>(this CombinedResult<InnerVehicleStateTemplateAssociationFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehicleStateTemplateAssociationFactory, T2, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2>(this CombinedResult<T1, InnerVehicleStateTemplateAssociationFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVehicleStateTemplateAssociationFactory, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2>(this CombinedResult<T1, T2, InnerVehicleStateTemplateAssociationFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerVehicleStateTemplateAssociationFactory, T1, T2, T3, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2, T3>(this CombinedResult<InnerVehicleStateTemplateAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehicleStateTemplateAssociationFactory, T2, T3, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2, T3>(this CombinedResult<T1, InnerVehicleStateTemplateAssociationFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVehicleStateTemplateAssociationFactory, T3, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2, T3>(this CombinedResult<T1, T2, InnerVehicleStateTemplateAssociationFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerVehicleStateTemplateAssociationFactory, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVehicleStateTemplateAssociationFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerVehicleStateTemplateAssociationFactory, T1, T2, T3, T4, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2, T3, T4>(this CombinedResult<InnerVehicleStateTemplateAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehicleStateTemplateAssociationFactory, T2, T3, T4, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2, T3, T4>(this CombinedResult<T1, InnerVehicleStateTemplateAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVehicleStateTemplateAssociationFactory, T3, T4, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVehicleStateTemplateAssociationFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerVehicleStateTemplateAssociationFactory, T4, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVehicleStateTemplateAssociationFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerVehicleStateTemplateAssociationFactory, InnerVehicleStateTemplateUpdateStrategyFactory> WithStateTemplateUpdateStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVehicleStateTemplateAssociationFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateStrategy(combinedResult.T5, subFactoryAction).T2);
}
