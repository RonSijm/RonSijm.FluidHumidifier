// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolDomainFailoverTypeFactory(Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolDomainTypes.FailoverType>
{

    protected override Humidifier.Cognito.UserPoolDomainTypes.FailoverType Create()
    {
        var failoverTypeResult = CreateFailoverType();
        factoryAction?.Invoke(failoverTypeResult);

        return failoverTypeResult;
    }

    private Humidifier.Cognito.UserPoolDomainTypes.FailoverType CreateFailoverType()
    {
        var failoverTypeResult = new Humidifier.Cognito.UserPoolDomainTypes.FailoverType();

        return failoverTypeResult;
    }

} // End Of Class

public static class InnerUserPoolDomainFailoverTypeFactoryExtensions
{
}
