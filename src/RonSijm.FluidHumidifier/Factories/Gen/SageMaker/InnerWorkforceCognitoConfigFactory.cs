// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerWorkforceCognitoConfigFactory(Action<Humidifier.SageMaker.WorkforceTypes.CognitoConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.WorkforceTypes.CognitoConfig>
{

    protected override Humidifier.SageMaker.WorkforceTypes.CognitoConfig Create()
    {
        var cognitoConfigResult = CreateCognitoConfig();
        factoryAction?.Invoke(cognitoConfigResult);

        return cognitoConfigResult;
    }

    private Humidifier.SageMaker.WorkforceTypes.CognitoConfig CreateCognitoConfig()
    {
        var cognitoConfigResult = new Humidifier.SageMaker.WorkforceTypes.CognitoConfig();

        return cognitoConfigResult;
    }

} // End Of Class

public static class InnerWorkforceCognitoConfigFactoryExtensions
{
}
