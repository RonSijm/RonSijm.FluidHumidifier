// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class FleetFactory(string resourceName = null, Action<Humidifier.AppStream.Fleet> factoryAction = null) : ResourceFactory<Humidifier.AppStream.Fleet>(resourceName)
{

    internal InnerFleetComputeCapacityFactory ComputeCapacityFactory { get; set; }

    internal InnerFleetVpcConfigFactory VpcConfigFactory { get; set; }

    internal InnerFleetDomainJoinInfoFactory DomainJoinInfoFactory { get; set; }

    internal InnerFleetS3LocationFactory SessionScriptS3LocationFactory { get; set; }

    protected override Humidifier.AppStream.Fleet Create()
    {
        var fleetResult = CreateFleet();
        factoryAction?.Invoke(fleetResult);

        return fleetResult;
    }

    private Humidifier.AppStream.Fleet CreateFleet()
    {
        var fleetResult = new Humidifier.AppStream.Fleet
        {
            GivenName = InputResourceName,
        };

        return fleetResult;
    }
    public override void CreateChildren(Humidifier.AppStream.Fleet result)
    {
        base.CreateChildren(result);

        result.ComputeCapacity ??= ComputeCapacityFactory?.Build();
        result.VpcConfig ??= VpcConfigFactory?.Build();
        result.DomainJoinInfo ??= DomainJoinInfoFactory?.Build();
        result.SessionScriptS3Location ??= SessionScriptS3LocationFactory?.Build();
    }

} // End Of Class

public static class FleetFactoryExtensions
{
    public static CombinedResult<FleetFactory, InnerFleetComputeCapacityFactory> WithComputeCapacity(this FleetFactory parentFactory, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null)
    {
        parentFactory.ComputeCapacityFactory = new InnerFleetComputeCapacityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComputeCapacityFactory);
    }

    public static CombinedResult<FleetFactory, InnerFleetVpcConfigFactory> WithVpcConfig(this FleetFactory parentFactory, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerFleetVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<FleetFactory, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo(this FleetFactory parentFactory, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null)
    {
        parentFactory.DomainJoinInfoFactory = new InnerFleetDomainJoinInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DomainJoinInfoFactory);
    }

    public static CombinedResult<FleetFactory, InnerFleetS3LocationFactory> WithSessionScriptS3Location(this FleetFactory parentFactory, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.SessionScriptS3LocationFactory = new InnerFleetS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SessionScriptS3LocationFactory);
    }

    public static CombinedResult<FleetFactory, T1, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1>(this CombinedResult<FleetFactory, T1> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1>(this CombinedResult<T1, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2>(this CombinedResult<FleetFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2>(this CombinedResult<T1, FleetFactory, T2> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2>(this CombinedResult<T1, T2, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2, T3>(this CombinedResult<FleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2, T3>(this CombinedResult<T1, FleetFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2, T3>(this CombinedResult<T1, T2, FleetFactory, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2, T3>(this CombinedResult<T1, T2, T3, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, T4, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2, T3, T4>(this CombinedResult<FleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, T4, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2, T3, T4>(this CombinedResult<T1, FleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, T4, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, FleetFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, T4, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FleetFactory, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FleetFactory, InnerFleetComputeCapacityFactory> WithComputeCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeCapacity(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, InnerFleetVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<FleetFactory, T1> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, InnerFleetVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<FleetFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, FleetFactory, T2> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<FleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, FleetFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, FleetFactory, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, T4, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<FleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, T4, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, FleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, T4, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, FleetFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, T4, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FleetFactory, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FleetFactory, InnerFleetVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1>(this CombinedResult<FleetFactory, T1> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1>(this CombinedResult<T1, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2>(this CombinedResult<FleetFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2>(this CombinedResult<T1, FleetFactory, T2> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2>(this CombinedResult<T1, T2, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3>(this CombinedResult<FleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3>(this CombinedResult<T1, FleetFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3>(this CombinedResult<T1, T2, FleetFactory, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, T4, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<FleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, T4, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<T1, FleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, T4, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, FleetFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, T4, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FleetFactory, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FleetFactory, InnerFleetDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1>(this CombinedResult<FleetFactory, T1> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1>(this CombinedResult<T1, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2>(this CombinedResult<FleetFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2>(this CombinedResult<T1, FleetFactory, T2> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2>(this CombinedResult<T1, T2, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2, T3>(this CombinedResult<FleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2, T3>(this CombinedResult<T1, FleetFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2, T3>(this CombinedResult<T1, T2, FleetFactory, T3> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, T4, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2, T3, T4>(this CombinedResult<FleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, T4, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2, T3, T4>(this CombinedResult<T1, FleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, T4, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, FleetFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, T4, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FleetFactory, T4> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FleetFactory, InnerFleetS3LocationFactory> WithSessionScriptS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FleetFactory> combinedResult, Action<Humidifier.AppStream.FleetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionScriptS3Location(combinedResult.T5, subFactoryAction));
}
