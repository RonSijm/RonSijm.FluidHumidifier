// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerIdentityTagsFactory(Action<Humidifier.PinpointEmail.IdentityTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.IdentityTypes.Tags>
{

    protected override Humidifier.PinpointEmail.IdentityTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.PinpointEmail.IdentityTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.PinpointEmail.IdentityTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerIdentityTagsFactoryExtensions
{
}
