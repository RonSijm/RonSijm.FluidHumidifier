// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VolumeAttachmentFactory(string resourceName = null, Action<Humidifier.EC2.VolumeAttachment> factoryAction = null) : ResourceFactory<Humidifier.EC2.VolumeAttachment>(resourceName)
{

    protected override Humidifier.EC2.VolumeAttachment Create()
    {
        var volumeAttachmentResult = CreateVolumeAttachment();
        factoryAction?.Invoke(volumeAttachmentResult);

        return volumeAttachmentResult;
    }

    private Humidifier.EC2.VolumeAttachment CreateVolumeAttachment()
    {
        var volumeAttachmentResult = new Humidifier.EC2.VolumeAttachment
        {
            GivenName = InputResourceName,
        };

        return volumeAttachmentResult;
    }

} // End Of Class

public static class VolumeAttachmentFactoryExtensions
{
}
