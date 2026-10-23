// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputInputDestinationFactory(Action<Humidifier.MediaLive.InputTypes.InputDestination> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.InputDestination>
{

    internal InnerInputInputDestinationVpcFactory VpcFactory { get; set; }

    protected override Humidifier.MediaLive.InputTypes.InputDestination Create()
    {
        var inputDestinationResult = CreateInputDestination();
        factoryAction?.Invoke(inputDestinationResult);

        return inputDestinationResult;
    }

    private Humidifier.MediaLive.InputTypes.InputDestination CreateInputDestination()
    {
        var inputDestinationResult = new Humidifier.MediaLive.InputTypes.InputDestination();

        return inputDestinationResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.InputTypes.InputDestination result)
    {
        base.CreateChildren(result);

        result.Vpc ??= VpcFactory?.Build();
    }

} // End Of Class

public static class InnerInputInputDestinationFactoryExtensions
{
    public static CombinedResult<InnerInputInputDestinationFactory, InnerInputInputDestinationVpcFactory> WithVpc(this InnerInputInputDestinationFactory parentFactory, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null)
    {
        parentFactory.VpcFactory = new InnerInputInputDestinationVpcFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcFactory);
    }

    public static CombinedResult<InnerInputInputDestinationFactory, T1, InnerInputInputDestinationVpcFactory> WithVpc<T1>(this CombinedResult<InnerInputInputDestinationFactory, T1> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputInputDestinationFactory, InnerInputInputDestinationVpcFactory> WithVpc<T1>(this CombinedResult<T1, InnerInputInputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInputInputDestinationFactory, T1, T2, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2>(this CombinedResult<InnerInputInputDestinationFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputInputDestinationFactory, T2, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2>(this CombinedResult<T1, InnerInputInputDestinationFactory, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputInputDestinationFactory, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2>(this CombinedResult<T1, T2, InnerInputInputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInputInputDestinationFactory, T1, T2, T3, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<InnerInputInputDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputInputDestinationFactory, T2, T3, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<T1, InnerInputInputDestinationFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputInputDestinationFactory, T3, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<T1, T2, InnerInputInputDestinationFactory, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputInputDestinationFactory, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInputInputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInputInputDestinationFactory, T1, T2, T3, T4, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<InnerInputInputDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputInputDestinationFactory, T2, T3, T4, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, InnerInputInputDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputInputDestinationFactory, T3, T4, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInputInputDestinationFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputInputDestinationFactory, T4, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInputInputDestinationFactory, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInputInputDestinationFactory, InnerInputInputDestinationVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInputInputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T5, subFactoryAction).T2);
}
