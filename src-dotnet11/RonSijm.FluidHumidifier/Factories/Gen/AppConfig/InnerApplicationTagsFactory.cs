// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class InnerApplicationTagsFactory(Action<Humidifier.AppConfig.ApplicationTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.AppConfig.ApplicationTypes.Tags>
{

    protected override Humidifier.AppConfig.ApplicationTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.AppConfig.ApplicationTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.AppConfig.ApplicationTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerApplicationTagsFactoryExtensions
{
}
