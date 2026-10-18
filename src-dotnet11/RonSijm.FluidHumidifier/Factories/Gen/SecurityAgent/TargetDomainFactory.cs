// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class TargetDomainFactory(string resourceName = null, Action<Humidifier.SecurityAgent.TargetDomain> factoryAction = null) : ResourceFactory<Humidifier.SecurityAgent.TargetDomain>(resourceName)
{

    protected override Humidifier.SecurityAgent.TargetDomain Create()
    {
        var targetDomainResult = CreateTargetDomain();
        factoryAction?.Invoke(targetDomainResult);

        return targetDomainResult;
    }

    private Humidifier.SecurityAgent.TargetDomain CreateTargetDomain()
    {
        var targetDomainResult = new Humidifier.SecurityAgent.TargetDomain
        {
            GivenName = InputResourceName,
        };

        return targetDomainResult;
    }

} // End Of Class

public static class TargetDomainFactoryExtensions
{
}
