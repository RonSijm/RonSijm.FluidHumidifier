// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainDefaultEbsStorageSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings>
{

    protected override Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings Create()
    {
        var defaultEbsStorageSettingsResult = CreateDefaultEbsStorageSettings();
        factoryAction?.Invoke(defaultEbsStorageSettingsResult);

        return defaultEbsStorageSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings CreateDefaultEbsStorageSettings()
    {
        var defaultEbsStorageSettingsResult = new Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings();

        return defaultEbsStorageSettingsResult;
    }

} // End Of Class

public static class InnerDomainDefaultEbsStorageSettingsFactoryExtensions
{
}
