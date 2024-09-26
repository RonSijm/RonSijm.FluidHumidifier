// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerApiKeyStageKeyFactory(Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.ApiKeyTypes.StageKey>
{

    protected override Humidifier.ApiGateway.ApiKeyTypes.StageKey Create()
    {
        var stageKeyResult = CreateStageKey();
        factoryAction?.Invoke(stageKeyResult);

        return stageKeyResult;
    }

    private Humidifier.ApiGateway.ApiKeyTypes.StageKey CreateStageKey()
    {
        var stageKeyResult = new Humidifier.ApiGateway.ApiKeyTypes.StageKey();

        return stageKeyResult;
    }

} // End Of Class

public static class InnerApiKeyStageKeyFactoryExtensions
{
}
