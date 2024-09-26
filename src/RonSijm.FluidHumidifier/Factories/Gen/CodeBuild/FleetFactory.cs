// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class FleetFactory(string resourceName = null, Action<Humidifier.CodeBuild.Fleet> factoryAction = null) : ResourceFactory<Humidifier.CodeBuild.Fleet>(resourceName)
{

    internal InnerFleetVpcConfigFactory FleetVpcConfigFactory { get; set; }

    protected override Humidifier.CodeBuild.Fleet Create()
    {
        var fleetResult = CreateFleet();
        factoryAction?.Invoke(fleetResult);

        return fleetResult;
    }

    private Humidifier.CodeBuild.Fleet CreateFleet()
    {
        var fleetResult = new Humidifier.CodeBuild.Fleet
        {
            GivenName = InputResourceName,
        };

        return fleetResult;
    }
    public override void CreateChildren(Humidifier.CodeBuild.Fleet result)
    {
        base.CreateChildren(result);

        result.FleetVpcConfig ??= FleetVpcConfigFactory?.Build();
    }

} // End Of Class

public static class FleetFactoryExtensions
{
    public static CombinedResult<FleetFactory, InnerFleetVpcConfigFactory> WithFleetVpcConfig(this FleetFactory parentFactory, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.FleetVpcConfigFactory = new InnerFleetVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FleetVpcConfigFactory);
    }

    public static CombinedResult<FleetFactory, T1, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1>(this CombinedResult<FleetFactory, T1> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1>(this CombinedResult<T1, FleetFactory> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2>(this CombinedResult<FleetFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2>(this CombinedResult<T1, FleetFactory, T2> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2>(this CombinedResult<T1, T2, FleetFactory> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2, T3>(this CombinedResult<FleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2, T3>(this CombinedResult<T1, FleetFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, FleetFactory, T3> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, FleetFactory> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, T4, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2, T3, T4>(this CombinedResult<FleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, T4, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, FleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, T4, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, FleetFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, T4, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FleetFactory, T4> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FleetFactory, InnerFleetVpcConfigFactory> WithFleetVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FleetFactory> combinedResult, Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleetVpcConfig(combinedResult.T5, subFactoryAction));
}
