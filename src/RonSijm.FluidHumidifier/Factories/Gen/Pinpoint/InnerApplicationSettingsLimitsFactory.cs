// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerApplicationSettingsLimitsFactory(Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits>
{

    protected override Humidifier.Pinpoint.ApplicationSettingsTypes.Limits Create()
    {
        var limitsResult = CreateLimits();
        factoryAction?.Invoke(limitsResult);

        return limitsResult;
    }

    private Humidifier.Pinpoint.ApplicationSettingsTypes.Limits CreateLimits()
    {
        var limitsResult = new Humidifier.Pinpoint.ApplicationSettingsTypes.Limits();

        return limitsResult;
    }

} // End Of Class

public static class InnerApplicationSettingsLimitsFactoryExtensions
{
}
