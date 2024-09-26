// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceOwnershipSettingsFactory(Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.OwnershipSettings>
{

    protected override Humidifier.SageMaker.SpaceTypes.OwnershipSettings Create()
    {
        var ownershipSettingsResult = CreateOwnershipSettings();
        factoryAction?.Invoke(ownershipSettingsResult);

        return ownershipSettingsResult;
    }

    private Humidifier.SageMaker.SpaceTypes.OwnershipSettings CreateOwnershipSettings()
    {
        var ownershipSettingsResult = new Humidifier.SageMaker.SpaceTypes.OwnershipSettings();

        return ownershipSettingsResult;
    }

} // End Of Class

public static class InnerSpaceOwnershipSettingsFactoryExtensions
{
}
