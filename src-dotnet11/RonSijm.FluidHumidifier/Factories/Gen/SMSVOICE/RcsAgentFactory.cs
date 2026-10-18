// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class RcsAgentFactory(string resourceName = null, Action<Humidifier.SMSVOICE.RcsAgent> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.RcsAgent>(resourceName)
{

    protected override Humidifier.SMSVOICE.RcsAgent Create()
    {
        var rcsAgentResult = CreateRcsAgent();
        factoryAction?.Invoke(rcsAgentResult);

        return rcsAgentResult;
    }

    private Humidifier.SMSVOICE.RcsAgent CreateRcsAgent()
    {
        var rcsAgentResult = new Humidifier.SMSVOICE.RcsAgent
        {
            GivenName = InputResourceName,
        };

        return rcsAgentResult;
    }

} // End Of Class

public static class RcsAgentFactoryExtensions
{
}
