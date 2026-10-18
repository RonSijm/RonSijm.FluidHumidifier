// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageDeletionSettingsFactory(Action<Humidifier.ImageBuilder.ImageTypes.DeletionSettings> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageTypes.DeletionSettings>
{

    protected override Humidifier.ImageBuilder.ImageTypes.DeletionSettings Create()
    {
        var deletionSettingsResult = CreateDeletionSettings();
        factoryAction?.Invoke(deletionSettingsResult);

        return deletionSettingsResult;
    }

    private Humidifier.ImageBuilder.ImageTypes.DeletionSettings CreateDeletionSettings()
    {
        var deletionSettingsResult = new Humidifier.ImageBuilder.ImageTypes.DeletionSettings();

        return deletionSettingsResult;
    }

} // End Of Class

public static class InnerImageDeletionSettingsFactoryExtensions
{
}
