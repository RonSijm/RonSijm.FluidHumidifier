// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolPreTokenGenerationConfigFactory(Action<Humidifier.Cognito.UserPoolTypes.PreTokenGenerationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.PreTokenGenerationConfig>
{

    protected override Humidifier.Cognito.UserPoolTypes.PreTokenGenerationConfig Create()
    {
        var preTokenGenerationConfigResult = CreatePreTokenGenerationConfig();
        factoryAction?.Invoke(preTokenGenerationConfigResult);

        return preTokenGenerationConfigResult;
    }

    private Humidifier.Cognito.UserPoolTypes.PreTokenGenerationConfig CreatePreTokenGenerationConfig()
    {
        var preTokenGenerationConfigResult = new Humidifier.Cognito.UserPoolTypes.PreTokenGenerationConfig();

        return preTokenGenerationConfigResult;
    }

} // End Of Class

public static class InnerUserPoolPreTokenGenerationConfigFactoryExtensions
{
}
