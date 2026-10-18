// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerSecurityConfigurationJobBookmarksEncryptionFactory(Action<Humidifier.Glue.SecurityConfigurationTypes.JobBookmarksEncryption> factoryAction = null) : SubResourceFactory<Humidifier.Glue.SecurityConfigurationTypes.JobBookmarksEncryption>
{

    protected override Humidifier.Glue.SecurityConfigurationTypes.JobBookmarksEncryption Create()
    {
        var jobBookmarksEncryptionResult = CreateJobBookmarksEncryption();
        factoryAction?.Invoke(jobBookmarksEncryptionResult);

        return jobBookmarksEncryptionResult;
    }

    private Humidifier.Glue.SecurityConfigurationTypes.JobBookmarksEncryption CreateJobBookmarksEncryption()
    {
        var jobBookmarksEncryptionResult = new Humidifier.Glue.SecurityConfigurationTypes.JobBookmarksEncryption();

        return jobBookmarksEncryptionResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationJobBookmarksEncryptionFactoryExtensions
{
}
