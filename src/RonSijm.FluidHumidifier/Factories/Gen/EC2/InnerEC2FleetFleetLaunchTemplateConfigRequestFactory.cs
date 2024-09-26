// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetFleetLaunchTemplateConfigRequestFactory(Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateConfigRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateConfigRequest>
{

    internal InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory LaunchTemplateSpecificationFactory { get; set; }

    protected override Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateConfigRequest Create()
    {
        var fleetLaunchTemplateConfigRequestResult = CreateFleetLaunchTemplateConfigRequest();
        factoryAction?.Invoke(fleetLaunchTemplateConfigRequestResult);

        return fleetLaunchTemplateConfigRequestResult;
    }

    private Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateConfigRequest CreateFleetLaunchTemplateConfigRequest()
    {
        var fleetLaunchTemplateConfigRequestResult = new Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateConfigRequest();

        return fleetLaunchTemplateConfigRequestResult;
    }
    public override void CreateChildren(Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateConfigRequest result)
    {
        base.CreateChildren(result);

        result.LaunchTemplateSpecification ??= LaunchTemplateSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerEC2FleetFleetLaunchTemplateConfigRequestFactoryExtensions
{
    public static CombinedResult<InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification(this InnerEC2FleetFleetLaunchTemplateConfigRequestFactory parentFactory, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null)
    {
        parentFactory.LaunchTemplateSpecificationFactory = new InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LaunchTemplateSpecificationFactory);
    }

    public static CombinedResult<InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T1, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1>(this CombinedResult<InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T1> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1>(this CombinedResult<T1, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T1, T2, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2>(this CombinedResult<InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T1, T2> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T2, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2>(this CombinedResult<T1, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T2> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2>(this CombinedResult<T1, T2, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T1, T2, T3, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2, T3>(this CombinedResult<InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T2, T3, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2, T3>(this CombinedResult<T1, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T2, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T3, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T1, T2, T3, T4, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T2, T3, T4, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T3, T4, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T4, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory, InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEC2FleetFleetLaunchTemplateConfigRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T5, subFactoryAction));
}
