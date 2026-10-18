// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolResourceServerResourceServerScopeTypeFactory(Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType>
{

    protected override Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType Create()
    {
        var resourceServerScopeTypeResult = CreateResourceServerScopeType();
        factoryAction?.Invoke(resourceServerScopeTypeResult);

        return resourceServerScopeTypeResult;
    }

    private Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType CreateResourceServerScopeType()
    {
        var resourceServerScopeTypeResult = new Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType();

        return resourceServerScopeTypeResult;
    }

} // End Of Class

public static class InnerUserPoolResourceServerResourceServerScopeTypeFactoryExtensions
{
}
