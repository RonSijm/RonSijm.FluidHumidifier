// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerWorkteamCognitoMemberDefinitionFactory(Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition>
{

    protected override Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition Create()
    {
        var cognitoMemberDefinitionResult = CreateCognitoMemberDefinition();
        factoryAction?.Invoke(cognitoMemberDefinitionResult);

        return cognitoMemberDefinitionResult;
    }

    private Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition CreateCognitoMemberDefinition()
    {
        var cognitoMemberDefinitionResult = new Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition();

        return cognitoMemberDefinitionResult;
    }

} // End Of Class

public static class InnerWorkteamCognitoMemberDefinitionFactoryExtensions
{
}
