// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class VehicleFactory(string resourceName = null, Action<Humidifier.IoTFleetWise.Vehicle> factoryAction = null) : ResourceFactory<Humidifier.IoTFleetWise.Vehicle>(resourceName)
{

    internal List<InnerVehicleStateTemplateAssociationFactory> StateTemplatesFactories { get; set; } = [];

    protected override Humidifier.IoTFleetWise.Vehicle Create()
    {
        var vehicleResult = CreateVehicle();
        factoryAction?.Invoke(vehicleResult);

        return vehicleResult;
    }

    private Humidifier.IoTFleetWise.Vehicle CreateVehicle()
    {
        var vehicleResult = new Humidifier.IoTFleetWise.Vehicle
        {
            GivenName = InputResourceName,
        };

        return vehicleResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.Vehicle result)
    {
        base.CreateChildren(result);

        result.StateTemplates = StateTemplatesFactories.Any() ? StateTemplatesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class VehicleFactoryExtensions
{
    public static CombinedResult<VehicleFactory, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates(this VehicleFactory parentFactory, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null)
    {
        var factory = new InnerVehicleStateTemplateAssociationFactory(subFactoryAction);
        parentFactory.StateTemplatesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<VehicleFactory, T1, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1>(this CombinedResult<VehicleFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, WithStateTemplates(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VehicleFactory, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1>(this CombinedResult<T1, VehicleFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, WithStateTemplates(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<VehicleFactory, T1, T2, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2>(this CombinedResult<VehicleFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VehicleFactory, T2, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2>(this CombinedResult<T1, VehicleFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VehicleFactory, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2>(this CombinedResult<T1, T2, VehicleFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<VehicleFactory, T1, T2, T3, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2, T3>(this CombinedResult<VehicleFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VehicleFactory, T2, T3, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2, T3>(this CombinedResult<T1, VehicleFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VehicleFactory, T3, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2, T3>(this CombinedResult<T1, T2, VehicleFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VehicleFactory, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2, T3>(this CombinedResult<T1, T2, T3, VehicleFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<VehicleFactory, T1, T2, T3, T4, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2, T3, T4>(this CombinedResult<VehicleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VehicleFactory, T2, T3, T4, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2, T3, T4>(this CombinedResult<T1, VehicleFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VehicleFactory, T3, T4, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2, T3, T4>(this CombinedResult<T1, T2, VehicleFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VehicleFactory, T4, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VehicleFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, VehicleFactory, InnerVehicleStateTemplateAssociationFactory> WithStateTemplates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VehicleFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplates(combinedResult.T5, subFactoryAction).T2);
}
