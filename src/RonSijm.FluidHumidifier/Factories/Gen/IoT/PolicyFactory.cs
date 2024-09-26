// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class PolicyFactory(string resourceName = null, Action<Humidifier.IoT.Policy> factoryAction = null) : ResourceFactory<Humidifier.IoT.Policy>(resourceName)
{

    protected override Humidifier.IoT.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.IoT.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.IoT.Policy
        {
            GivenName = InputResourceName,
        };

        return policyResult;
    }

} // End Of Class

public static class PolicyFactoryExtensions
{
}
