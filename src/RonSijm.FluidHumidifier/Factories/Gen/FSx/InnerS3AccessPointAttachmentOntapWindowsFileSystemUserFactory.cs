// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerS3AccessPointAttachmentOntapWindowsFileSystemUserFactory(Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapWindowsFileSystemUser> factoryAction = null) : SubResourceFactory<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapWindowsFileSystemUser>
{

    protected override Humidifier.FSx.S3AccessPointAttachmentTypes.OntapWindowsFileSystemUser Create()
    {
        var ontapWindowsFileSystemUserResult = CreateOntapWindowsFileSystemUser();
        factoryAction?.Invoke(ontapWindowsFileSystemUserResult);

        return ontapWindowsFileSystemUserResult;
    }

    private Humidifier.FSx.S3AccessPointAttachmentTypes.OntapWindowsFileSystemUser CreateOntapWindowsFileSystemUser()
    {
        var ontapWindowsFileSystemUserResult = new Humidifier.FSx.S3AccessPointAttachmentTypes.OntapWindowsFileSystemUser();

        return ontapWindowsFileSystemUserResult;
    }

} // End Of Class

public static class InnerS3AccessPointAttachmentOntapWindowsFileSystemUserFactoryExtensions
{
}
