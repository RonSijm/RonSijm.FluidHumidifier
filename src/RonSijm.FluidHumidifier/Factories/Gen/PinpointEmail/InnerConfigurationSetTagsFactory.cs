// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerConfigurationSetTagsFactory(Action<Humidifier.PinpointEmail.ConfigurationSetTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.ConfigurationSetTypes.Tags>
{

    protected override Humidifier.PinpointEmail.ConfigurationSetTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.PinpointEmail.ConfigurationSetTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerConfigurationSetTagsFactoryExtensions
{
}
