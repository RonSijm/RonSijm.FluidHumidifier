// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerIdentityPoolCognitoStreamsFactory(Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams>
{

    protected override Humidifier.Cognito.IdentityPoolTypes.CognitoStreams Create()
    {
        var cognitoStreamsResult = CreateCognitoStreams();
        factoryAction?.Invoke(cognitoStreamsResult);

        return cognitoStreamsResult;
    }

    private Humidifier.Cognito.IdentityPoolTypes.CognitoStreams CreateCognitoStreams()
    {
        var cognitoStreamsResult = new Humidifier.Cognito.IdentityPoolTypes.CognitoStreams();

        return cognitoStreamsResult;
    }

} // End Of Class

public static class InnerIdentityPoolCognitoStreamsFactoryExtensions
{
}
