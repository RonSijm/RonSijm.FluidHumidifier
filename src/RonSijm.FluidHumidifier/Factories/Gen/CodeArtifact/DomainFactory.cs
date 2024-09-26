// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeArtifact;

public class DomainFactory(string resourceName = null, Action<Humidifier.CodeArtifact.Domain> factoryAction = null) : ResourceFactory<Humidifier.CodeArtifact.Domain>(resourceName)
{

    protected override Humidifier.CodeArtifact.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.CodeArtifact.Domain CreateDomain()
    {
        var domainResult = new Humidifier.CodeArtifact.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }

} // End Of Class

public static class DomainFactoryExtensions
{
}
