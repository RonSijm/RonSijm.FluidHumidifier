// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationAutoScaling;

public class InnerScalableTargetScalableTargetActionFactory(Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction>
{

    protected override Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction Create()
    {
        var scalableTargetActionResult = CreateScalableTargetAction();
        factoryAction?.Invoke(scalableTargetActionResult);

        return scalableTargetActionResult;
    }

    private Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction CreateScalableTargetAction()
    {
        var scalableTargetActionResult = new Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction();

        return scalableTargetActionResult;
    }

} // End Of Class

public static class InnerScalableTargetScalableTargetActionFactoryExtensions
{
}
