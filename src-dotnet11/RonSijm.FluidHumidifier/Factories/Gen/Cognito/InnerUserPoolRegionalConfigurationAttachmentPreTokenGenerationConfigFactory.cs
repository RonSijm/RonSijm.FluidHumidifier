// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRegionalConfigurationAttachmentPreTokenGenerationConfigFactory(Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.PreTokenGenerationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.PreTokenGenerationConfig>
{

    protected override Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.PreTokenGenerationConfig Create()
    {
        var preTokenGenerationConfigResult = CreatePreTokenGenerationConfig();
        factoryAction?.Invoke(preTokenGenerationConfigResult);

        return preTokenGenerationConfigResult;
    }

    private Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.PreTokenGenerationConfig CreatePreTokenGenerationConfig()
    {
        var preTokenGenerationConfigResult = new Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.PreTokenGenerationConfig();

        return preTokenGenerationConfigResult;
    }

} // End Of Class

public static class InnerUserPoolRegionalConfigurationAttachmentPreTokenGenerationConfigFactoryExtensions
{
}
