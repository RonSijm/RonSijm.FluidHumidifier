// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class SourceCredentialFactory(string resourceName = null, Action<Humidifier.CodeBuild.SourceCredential> factoryAction = null) : ResourceFactory<Humidifier.CodeBuild.SourceCredential>(resourceName)
{

    protected override Humidifier.CodeBuild.SourceCredential Create()
    {
        var sourceCredentialResult = CreateSourceCredential();
        factoryAction?.Invoke(sourceCredentialResult);

        return sourceCredentialResult;
    }

    private Humidifier.CodeBuild.SourceCredential CreateSourceCredential()
    {
        var sourceCredentialResult = new Humidifier.CodeBuild.SourceCredential
        {
            GivenName = InputResourceName,
        };

        return sourceCredentialResult;
    }

} // End Of Class

public static class SourceCredentialFactoryExtensions
{
}
