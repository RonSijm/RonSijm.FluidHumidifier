// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory(Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> factoryAction = null) : SubResourceFactory<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser>
{

    protected override Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser Create()
    {
        var openZFSPosixFileSystemUserResult = CreateOpenZFSPosixFileSystemUser();
        factoryAction?.Invoke(openZFSPosixFileSystemUserResult);

        return openZFSPosixFileSystemUserResult;
    }

    private Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser CreateOpenZFSPosixFileSystemUser()
    {
        var openZFSPosixFileSystemUserResult = new Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser();

        return openZFSPosixFileSystemUserResult;
    }

} // End Of Class

public static class InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactoryExtensions
{
}
