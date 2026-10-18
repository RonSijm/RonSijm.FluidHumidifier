// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolNumberAttributeConstraintsFactory(Action<Humidifier.Cognito.UserPoolTypes.NumberAttributeConstraints> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.NumberAttributeConstraints>
{

    protected override Humidifier.Cognito.UserPoolTypes.NumberAttributeConstraints Create()
    {
        var numberAttributeConstraintsResult = CreateNumberAttributeConstraints();
        factoryAction?.Invoke(numberAttributeConstraintsResult);

        return numberAttributeConstraintsResult;
    }

    private Humidifier.Cognito.UserPoolTypes.NumberAttributeConstraints CreateNumberAttributeConstraints()
    {
        var numberAttributeConstraintsResult = new Humidifier.Cognito.UserPoolTypes.NumberAttributeConstraints();

        return numberAttributeConstraintsResult;
    }

} // End Of Class

public static class InnerUserPoolNumberAttributeConstraintsFactoryExtensions
{
}
