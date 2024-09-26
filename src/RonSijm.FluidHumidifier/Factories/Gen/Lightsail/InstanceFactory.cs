// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InstanceFactory(string resourceName = null, Action<Humidifier.Lightsail.Instance> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.Instance>(resourceName)
{

    internal List<InnerInstanceAddOnFactory> AddOnsFactories { get; set; } = [];

    internal InnerInstanceNetworkingFactory NetworkingFactory { get; set; }

    internal InnerInstanceStateFactory StateFactory { get; set; }

    internal InnerInstanceHardwareFactory HardwareFactory { get; set; }

    internal InnerInstanceLocationFactory LocationFactory { get; set; }

    protected override Humidifier.Lightsail.Instance Create()
    {
        var instanceResult = CreateInstance();
        factoryAction?.Invoke(instanceResult);

        return instanceResult;
    }

    private Humidifier.Lightsail.Instance CreateInstance()
    {
        var instanceResult = new Humidifier.Lightsail.Instance
        {
            GivenName = InputResourceName,
        };

        return instanceResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.Instance result)
    {
        base.CreateChildren(result);

        result.AddOns = AddOnsFactories.Any() ? AddOnsFactories.Select(x => x.Build()).ToList() : null;
        result.Networking ??= NetworkingFactory?.Build();
        result.State ??= StateFactory?.Build();
        result.Hardware ??= HardwareFactory?.Build();
        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class InstanceFactoryExtensions
{
    public static CombinedResult<InstanceFactory, InnerInstanceAddOnFactory> WithAddOns(this InstanceFactory parentFactory, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null)
    {
        var factory = new InnerInstanceAddOnFactory(subFactoryAction);
        parentFactory.AddOnsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InstanceFactory, InnerInstanceNetworkingFactory> WithNetworking(this InstanceFactory parentFactory, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null)
    {
        parentFactory.NetworkingFactory = new InnerInstanceNetworkingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkingFactory);
    }

    public static CombinedResult<InstanceFactory, InnerInstanceStateFactory> WithState(this InstanceFactory parentFactory, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null)
    {
        parentFactory.StateFactory = new InnerInstanceStateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StateFactory);
    }

    public static CombinedResult<InstanceFactory, InnerInstanceHardwareFactory> WithHardware(this InstanceFactory parentFactory, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null)
    {
        parentFactory.HardwareFactory = new InnerInstanceHardwareFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HardwareFactory);
    }

    public static CombinedResult<InstanceFactory, InnerInstanceLocationFactory> WithLocation(this InstanceFactory parentFactory, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerInstanceLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<InstanceFactory, T1, InnerInstanceAddOnFactory> WithAddOns<T1>(this CombinedResult<InstanceFactory, T1> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithAddOns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, InnerInstanceAddOnFactory> WithAddOns<T1>(this CombinedResult<T1, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithAddOns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, InnerInstanceAddOnFactory> WithAddOns<T1, T2>(this CombinedResult<InstanceFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, InnerInstanceAddOnFactory> WithAddOns<T1, T2>(this CombinedResult<T1, InstanceFactory, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, InnerInstanceAddOnFactory> WithAddOns<T1, T2>(this CombinedResult<T1, T2, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, InnerInstanceAddOnFactory> WithAddOns<T1, T2, T3>(this CombinedResult<InstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, InnerInstanceAddOnFactory> WithAddOns<T1, T2, T3>(this CombinedResult<T1, InstanceFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, InnerInstanceAddOnFactory> WithAddOns<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFactory, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, InnerInstanceAddOnFactory> WithAddOns<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, T4, InnerInstanceAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<InstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, T4, InnerInstanceAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, T4, InnerInstanceAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, T4, InnerInstanceAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFactory, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFactory, InnerInstanceAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, InnerInstanceNetworkingFactory> WithNetworking<T1>(this CombinedResult<InstanceFactory, T1> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworking(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, InnerInstanceNetworkingFactory> WithNetworking<T1>(this CombinedResult<T1, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworking(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, InnerInstanceNetworkingFactory> WithNetworking<T1, T2>(this CombinedResult<InstanceFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, InnerInstanceNetworkingFactory> WithNetworking<T1, T2>(this CombinedResult<T1, InstanceFactory, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, InnerInstanceNetworkingFactory> WithNetworking<T1, T2>(this CombinedResult<T1, T2, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, InnerInstanceNetworkingFactory> WithNetworking<T1, T2, T3>(this CombinedResult<InstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, InnerInstanceNetworkingFactory> WithNetworking<T1, T2, T3>(this CombinedResult<T1, InstanceFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, InnerInstanceNetworkingFactory> WithNetworking<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFactory, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, InnerInstanceNetworkingFactory> WithNetworking<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, T4, InnerInstanceNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<InstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, T4, InnerInstanceNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, T4, InnerInstanceNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, T4, InnerInstanceNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFactory, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFactory, InnerInstanceNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, InnerInstanceStateFactory> WithState<T1>(this CombinedResult<InstanceFactory, T1> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, WithState(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, InnerInstanceStateFactory> WithState<T1>(this CombinedResult<T1, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, WithState(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, InnerInstanceStateFactory> WithState<T1, T2>(this CombinedResult<InstanceFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithState(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, InnerInstanceStateFactory> WithState<T1, T2>(this CombinedResult<T1, InstanceFactory, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithState(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, InnerInstanceStateFactory> WithState<T1, T2>(this CombinedResult<T1, T2, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithState(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, InnerInstanceStateFactory> WithState<T1, T2, T3>(this CombinedResult<InstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithState(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, InnerInstanceStateFactory> WithState<T1, T2, T3>(this CombinedResult<T1, InstanceFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithState(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, InnerInstanceStateFactory> WithState<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFactory, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithState(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, InnerInstanceStateFactory> WithState<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithState(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, T4, InnerInstanceStateFactory> WithState<T1, T2, T3, T4>(this CombinedResult<InstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithState(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, T4, InnerInstanceStateFactory> WithState<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithState(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, T4, InnerInstanceStateFactory> WithState<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithState(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, T4, InnerInstanceStateFactory> WithState<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFactory, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithState(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFactory, InnerInstanceStateFactory> WithState<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.State> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithState(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, InnerInstanceHardwareFactory> WithHardware<T1>(this CombinedResult<InstanceFactory, T1> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, WithHardware(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, InnerInstanceHardwareFactory> WithHardware<T1>(this CombinedResult<T1, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, WithHardware(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, InnerInstanceHardwareFactory> WithHardware<T1, T2>(this CombinedResult<InstanceFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, InnerInstanceHardwareFactory> WithHardware<T1, T2>(this CombinedResult<T1, InstanceFactory, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, InnerInstanceHardwareFactory> WithHardware<T1, T2>(this CombinedResult<T1, T2, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, InnerInstanceHardwareFactory> WithHardware<T1, T2, T3>(this CombinedResult<InstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, InnerInstanceHardwareFactory> WithHardware<T1, T2, T3>(this CombinedResult<T1, InstanceFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, InnerInstanceHardwareFactory> WithHardware<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFactory, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, InnerInstanceHardwareFactory> WithHardware<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, T4, InnerInstanceHardwareFactory> WithHardware<T1, T2, T3, T4>(this CombinedResult<InstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, T4, InnerInstanceHardwareFactory> WithHardware<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, T4, InnerInstanceHardwareFactory> WithHardware<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, T4, InnerInstanceHardwareFactory> WithHardware<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFactory, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFactory, InnerInstanceHardwareFactory> WithHardware<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Hardware> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHardware(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, InnerInstanceLocationFactory> WithLocation<T1>(this CombinedResult<InstanceFactory, T1> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, InnerInstanceLocationFactory> WithLocation<T1>(this CombinedResult<T1, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, InnerInstanceLocationFactory> WithLocation<T1, T2>(this CombinedResult<InstanceFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, InnerInstanceLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, InstanceFactory, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, InnerInstanceLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, InnerInstanceLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<InstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, InnerInstanceLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, InstanceFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, InnerInstanceLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFactory, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, InnerInstanceLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, T4, InnerInstanceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<InstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, T4, InnerInstanceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, T4, InnerInstanceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, T4, InnerInstanceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFactory, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFactory, InnerInstanceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction));
}
