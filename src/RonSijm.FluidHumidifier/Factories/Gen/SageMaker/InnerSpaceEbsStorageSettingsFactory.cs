// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceEbsStorageSettingsFactory(Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings>
{

    protected override Humidifier.SageMaker.SpaceTypes.EbsStorageSettings Create()
    {
        var ebsStorageSettingsResult = CreateEbsStorageSettings();
        factoryAction?.Invoke(ebsStorageSettingsResult);

        return ebsStorageSettingsResult;
    }

    private Humidifier.SageMaker.SpaceTypes.EbsStorageSettings CreateEbsStorageSettings()
    {
        var ebsStorageSettingsResult = new Humidifier.SageMaker.SpaceTypes.EbsStorageSettings();

        return ebsStorageSettingsResult;
    }

} // End Of Class

public static class InnerSpaceEbsStorageSettingsFactoryExtensions
{
}
