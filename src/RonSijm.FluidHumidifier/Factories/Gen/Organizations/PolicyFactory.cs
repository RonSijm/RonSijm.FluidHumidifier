// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Organizations;

public class PolicyFactory(string resourceName = null, Action<Humidifier.Organizations.Policy> factoryAction = null) : ResourceFactory<Humidifier.Organizations.Policy>(resourceName)
{

    protected override Humidifier.Organizations.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.Organizations.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.Organizations.Policy
        {
            GivenName = InputResourceName,
        };

        return policyResult;
    }

} // End Of Class

public static class PolicyFactoryExtensions
{
}
