// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCisScanConfigurationCisTargetsFactory(Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets>
{

    protected override Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets Create()
    {
        var cisTargetsResult = CreateCisTargets();
        factoryAction?.Invoke(cisTargetsResult);

        return cisTargetsResult;
    }

    private Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets CreateCisTargets()
    {
        var cisTargetsResult = new Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets();

        return cisTargetsResult;
    }

} // End Of Class

public static class InnerCisScanConfigurationCisTargetsFactoryExtensions
{
}
