// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerRoutingProfileCrossChannelBehaviorFactory(Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> factoryAction = null) : SubResourceFactory<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior>
{

    protected override Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior Create()
    {
        var crossChannelBehaviorResult = CreateCrossChannelBehavior();
        factoryAction?.Invoke(crossChannelBehaviorResult);

        return crossChannelBehaviorResult;
    }

    private Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior CreateCrossChannelBehavior()
    {
        var crossChannelBehaviorResult = new Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior();

        return crossChannelBehaviorResult;
    }

} // End Of Class

public static class InnerRoutingProfileCrossChannelBehaviorFactoryExtensions
{
}
