// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class AIAgentVersionFactory(string resourceName = null, Action<Humidifier.Wisdom.AIAgentVersion> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.AIAgentVersion>(resourceName)
{

    protected override Humidifier.Wisdom.AIAgentVersion Create()
    {
        var aIAgentVersionResult = CreateAIAgentVersion();
        factoryAction?.Invoke(aIAgentVersionResult);

        return aIAgentVersionResult;
    }

    private Humidifier.Wisdom.AIAgentVersion CreateAIAgentVersion()
    {
        var aIAgentVersionResult = new Humidifier.Wisdom.AIAgentVersion
        {
            GivenName = InputResourceName,
        };

        return aIAgentVersionResult;
    }

} // End Of Class

public static class AIAgentVersionFactoryExtensions
{
}
