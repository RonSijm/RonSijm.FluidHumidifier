// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class DirectoryRegistrationFactory(string resourceName = null, Action<Humidifier.PCAConnectorAD.DirectoryRegistration> factoryAction = null) : ResourceFactory<Humidifier.PCAConnectorAD.DirectoryRegistration>(resourceName)
{

    protected override Humidifier.PCAConnectorAD.DirectoryRegistration Create()
    {
        var directoryRegistrationResult = CreateDirectoryRegistration();
        factoryAction?.Invoke(directoryRegistrationResult);

        return directoryRegistrationResult;
    }

    private Humidifier.PCAConnectorAD.DirectoryRegistration CreateDirectoryRegistration()
    {
        var directoryRegistrationResult = new Humidifier.PCAConnectorAD.DirectoryRegistration
        {
            GivenName = InputResourceName,
        };

        return directoryRegistrationResult;
    }

} // End Of Class

public static class DirectoryRegistrationFactoryExtensions
{
}
