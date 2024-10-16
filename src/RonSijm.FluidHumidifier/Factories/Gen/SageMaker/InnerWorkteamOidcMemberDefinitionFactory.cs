// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerWorkteamOidcMemberDefinitionFactory(Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition>
{

    protected override Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition Create()
    {
        var oidcMemberDefinitionResult = CreateOidcMemberDefinition();
        factoryAction?.Invoke(oidcMemberDefinitionResult);

        return oidcMemberDefinitionResult;
    }

    private Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition CreateOidcMemberDefinition()
    {
        var oidcMemberDefinitionResult = new Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition();

        return oidcMemberDefinitionResult;
    }

} // End Of Class

public static class InnerWorkteamOidcMemberDefinitionFactoryExtensions
{
}
