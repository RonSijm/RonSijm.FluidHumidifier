// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceSpaceIdleSettingsFactory(Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings>
{

    protected override Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings Create()
    {
        var spaceIdleSettingsResult = CreateSpaceIdleSettings();
        factoryAction?.Invoke(spaceIdleSettingsResult);

        return spaceIdleSettingsResult;
    }

    private Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings CreateSpaceIdleSettings()
    {
        var spaceIdleSettingsResult = new Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings();

        return spaceIdleSettingsResult;
    }

} // End Of Class

public static class InnerSpaceSpaceIdleSettingsFactoryExtensions
{
}
