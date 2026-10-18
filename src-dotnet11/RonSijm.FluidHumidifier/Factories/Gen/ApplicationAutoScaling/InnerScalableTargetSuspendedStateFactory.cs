// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationAutoScaling;

public class InnerScalableTargetSuspendedStateFactory(Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState>
{

    protected override Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState Create()
    {
        var suspendedStateResult = CreateSuspendedState();
        factoryAction?.Invoke(suspendedStateResult);

        return suspendedStateResult;
    }

    private Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState CreateSuspendedState()
    {
        var suspendedStateResult = new Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState();

        return suspendedStateResult;
    }

} // End Of Class

public static class InnerScalableTargetSuspendedStateFactoryExtensions
{
}
