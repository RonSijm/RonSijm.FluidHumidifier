// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerApplicationSettingsQuietTimeFactory(Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime>
{

    protected override Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime Create()
    {
        var quietTimeResult = CreateQuietTime();
        factoryAction?.Invoke(quietTimeResult);

        return quietTimeResult;
    }

    private Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime CreateQuietTime()
    {
        var quietTimeResult = new Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime();

        return quietTimeResult;
    }

} // End Of Class

public static class InnerApplicationSettingsQuietTimeFactoryExtensions
{
}
