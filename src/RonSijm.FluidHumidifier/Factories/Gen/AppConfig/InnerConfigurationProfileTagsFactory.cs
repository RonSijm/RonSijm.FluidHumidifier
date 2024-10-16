// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class InnerConfigurationProfileTagsFactory(Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.AppConfig.ConfigurationProfileTypes.Tags>
{

    protected override Humidifier.AppConfig.ConfigurationProfileTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.AppConfig.ConfigurationProfileTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.AppConfig.ConfigurationProfileTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerConfigurationProfileTagsFactoryExtensions
{
}
