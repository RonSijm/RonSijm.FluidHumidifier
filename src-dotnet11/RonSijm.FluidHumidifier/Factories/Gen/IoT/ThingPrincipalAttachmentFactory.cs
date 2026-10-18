// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class ThingPrincipalAttachmentFactory(string resourceName = null, Action<Humidifier.IoT.ThingPrincipalAttachment> factoryAction = null) : ResourceFactory<Humidifier.IoT.ThingPrincipalAttachment>(resourceName)
{

    protected override Humidifier.IoT.ThingPrincipalAttachment Create()
    {
        var thingPrincipalAttachmentResult = CreateThingPrincipalAttachment();
        factoryAction?.Invoke(thingPrincipalAttachmentResult);

        return thingPrincipalAttachmentResult;
    }

    private Humidifier.IoT.ThingPrincipalAttachment CreateThingPrincipalAttachment()
    {
        var thingPrincipalAttachmentResult = new Humidifier.IoT.ThingPrincipalAttachment
        {
            GivenName = InputResourceName,
        };

        return thingPrincipalAttachmentResult;
    }

} // End Of Class

public static class ThingPrincipalAttachmentFactoryExtensions
{
}
