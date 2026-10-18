// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerDocumentAttachmentsSourceFactory(Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> factoryAction = null) : SubResourceFactory<Humidifier.SSM.DocumentTypes.AttachmentsSource>
{

    protected override Humidifier.SSM.DocumentTypes.AttachmentsSource Create()
    {
        var attachmentsSourceResult = CreateAttachmentsSource();
        factoryAction?.Invoke(attachmentsSourceResult);

        return attachmentsSourceResult;
    }

    private Humidifier.SSM.DocumentTypes.AttachmentsSource CreateAttachmentsSource()
    {
        var attachmentsSourceResult = new Humidifier.SSM.DocumentTypes.AttachmentsSource();

        return attachmentsSourceResult;
    }

} // End Of Class

public static class InnerDocumentAttachmentsSourceFactoryExtensions
{
}
