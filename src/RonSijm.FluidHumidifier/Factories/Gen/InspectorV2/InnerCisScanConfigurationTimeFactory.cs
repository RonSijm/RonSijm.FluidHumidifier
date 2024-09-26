// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCisScanConfigurationTimeFactory(Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CisScanConfigurationTypes.Time>
{

    protected override Humidifier.InspectorV2.CisScanConfigurationTypes.Time Create()
    {
        var timeResult = CreateTime();
        factoryAction?.Invoke(timeResult);

        return timeResult;
    }

    private Humidifier.InspectorV2.CisScanConfigurationTypes.Time CreateTime()
    {
        var timeResult = new Humidifier.InspectorV2.CisScanConfigurationTypes.Time();

        return timeResult;
    }

} // End Of Class

public static class InnerCisScanConfigurationTimeFactoryExtensions
{
}
