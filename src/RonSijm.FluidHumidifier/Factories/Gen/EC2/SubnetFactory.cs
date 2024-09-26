// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SubnetFactory(string resourceName = null, Action<Humidifier.EC2.Subnet> factoryAction = null) : ResourceFactory<Humidifier.EC2.Subnet>(resourceName)
{

    internal InnerSubnetPrivateDnsNameOptionsOnLaunchFactory PrivateDnsNameOptionsOnLaunchFactory { get; set; }

    protected override Humidifier.EC2.Subnet Create()
    {
        var subnetResult = CreateSubnet();
        factoryAction?.Invoke(subnetResult);

        return subnetResult;
    }

    private Humidifier.EC2.Subnet CreateSubnet()
    {
        var subnetResult = new Humidifier.EC2.Subnet
        {
            GivenName = InputResourceName,
        };

        return subnetResult;
    }
    public override void CreateChildren(Humidifier.EC2.Subnet result)
    {
        base.CreateChildren(result);

        result.PrivateDnsNameOptionsOnLaunch ??= PrivateDnsNameOptionsOnLaunchFactory?.Build();
    }

} // End Of Class

public static class SubnetFactoryExtensions
{
    public static CombinedResult<SubnetFactory, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch(this SubnetFactory parentFactory, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null)
    {
        parentFactory.PrivateDnsNameOptionsOnLaunchFactory = new InnerSubnetPrivateDnsNameOptionsOnLaunchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrivateDnsNameOptionsOnLaunchFactory);
    }

    public static CombinedResult<SubnetFactory, T1, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1>(this CombinedResult<SubnetFactory, T1> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubnetFactory, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1>(this CombinedResult<T1, SubnetFactory> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SubnetFactory, T1, T2, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2>(this CombinedResult<SubnetFactory, T1, T2> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubnetFactory, T2, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2>(this CombinedResult<T1, SubnetFactory, T2> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubnetFactory, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2>(this CombinedResult<T1, T2, SubnetFactory> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SubnetFactory, T1, T2, T3, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2, T3>(this CombinedResult<SubnetFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubnetFactory, T2, T3, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2, T3>(this CombinedResult<T1, SubnetFactory, T2, T3> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubnetFactory, T3, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2, T3>(this CombinedResult<T1, T2, SubnetFactory, T3> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubnetFactory, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2, T3>(this CombinedResult<T1, T2, T3, SubnetFactory> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SubnetFactory, T1, T2, T3, T4, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2, T3, T4>(this CombinedResult<SubnetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubnetFactory, T2, T3, T4, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2, T3, T4>(this CombinedResult<T1, SubnetFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubnetFactory, T3, T4, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2, T3, T4>(this CombinedResult<T1, T2, SubnetFactory, T3, T4> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubnetFactory, T4, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SubnetFactory, T4> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SubnetFactory, InnerSubnetPrivateDnsNameOptionsOnLaunchFactory> WithPrivateDnsNameOptionsOnLaunch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SubnetFactory> combinedResult, Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameOptionsOnLaunch(combinedResult.T5, subFactoryAction));
}
