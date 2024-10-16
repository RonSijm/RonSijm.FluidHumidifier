// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.Lex.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.Lex.ResourcePolicy>(resourceName)
{

    protected override Humidifier.Lex.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.Lex.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.Lex.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
