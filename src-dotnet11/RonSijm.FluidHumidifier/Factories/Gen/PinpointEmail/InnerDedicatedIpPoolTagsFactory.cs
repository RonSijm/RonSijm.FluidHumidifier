// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerDedicatedIpPoolTagsFactory(Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags>
{

    protected override Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerDedicatedIpPoolTagsFactoryExtensions
{
}
