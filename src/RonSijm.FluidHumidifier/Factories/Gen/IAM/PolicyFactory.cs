// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class PolicyFactory(string resourceName = null, Action<Humidifier.IAM.Policy> factoryAction = null) : ResourceFactory<Humidifier.IAM.Policy>(resourceName)
{

    protected override Humidifier.IAM.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.IAM.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.IAM.Policy
        {
            GivenName = InputResourceName,
        };

        return policyResult;
    }

} // End Of Class

public static class PolicyFactoryExtensions
{
}
