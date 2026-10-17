// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerS3AccessPointAttachmentOntapUnixFileSystemUserFactory(Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapUnixFileSystemUser> factoryAction = null) : SubResourceFactory<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapUnixFileSystemUser>
{

    protected override Humidifier.FSx.S3AccessPointAttachmentTypes.OntapUnixFileSystemUser Create()
    {
        var ontapUnixFileSystemUserResult = CreateOntapUnixFileSystemUser();
        factoryAction?.Invoke(ontapUnixFileSystemUserResult);

        return ontapUnixFileSystemUserResult;
    }

    private Humidifier.FSx.S3AccessPointAttachmentTypes.OntapUnixFileSystemUser CreateOntapUnixFileSystemUser()
    {
        var ontapUnixFileSystemUserResult = new Humidifier.FSx.S3AccessPointAttachmentTypes.OntapUnixFileSystemUser();

        return ontapUnixFileSystemUserResult;
    }

} // End Of Class

public static class InnerS3AccessPointAttachmentOntapUnixFileSystemUserFactoryExtensions
{
}
