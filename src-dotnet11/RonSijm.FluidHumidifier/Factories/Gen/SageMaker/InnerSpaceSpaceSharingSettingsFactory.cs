// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceSpaceSharingSettingsFactory(Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings>
{

    protected override Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings Create()
    {
        var spaceSharingSettingsResult = CreateSpaceSharingSettings();
        factoryAction?.Invoke(spaceSharingSettingsResult);

        return spaceSharingSettingsResult;
    }

    private Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings CreateSpaceSharingSettings()
    {
        var spaceSharingSettingsResult = new Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings();

        return spaceSharingSettingsResult;
    }

} // End Of Class

public static class InnerSpaceSpaceSharingSettingsFactoryExtensions
{
}
