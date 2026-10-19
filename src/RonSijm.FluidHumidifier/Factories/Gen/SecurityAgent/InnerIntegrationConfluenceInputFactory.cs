// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerIntegrationConfluenceInputFactory(Action<Humidifier.SecurityAgent.IntegrationTypes.ConfluenceInput> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.IntegrationTypes.ConfluenceInput>
{

    protected override Humidifier.SecurityAgent.IntegrationTypes.ConfluenceInput Create()
    {
        var confluenceInputResult = CreateConfluenceInput();
        factoryAction?.Invoke(confluenceInputResult);

        return confluenceInputResult;
    }

    private Humidifier.SecurityAgent.IntegrationTypes.ConfluenceInput CreateConfluenceInput()
    {
        var confluenceInputResult = new Humidifier.SecurityAgent.IntegrationTypes.ConfluenceInput();

        return confluenceInputResult;
    }

} // End Of Class

public static class InnerIntegrationConfluenceInputFactoryExtensions
{
}
