// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory(Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration>
{

    protected override Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration Create()
    {
        var lakeFormationConfigurationResult = CreateLakeFormationConfiguration();
        factoryAction?.Invoke(lakeFormationConfigurationResult);

        return lakeFormationConfigurationResult;
    }

    private Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration CreateLakeFormationConfiguration()
    {
        var lakeFormationConfigurationResult = new Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration();

        return lakeFormationConfigurationResult;
    }

} // End Of Class

public static class InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactoryExtensions
{
}
