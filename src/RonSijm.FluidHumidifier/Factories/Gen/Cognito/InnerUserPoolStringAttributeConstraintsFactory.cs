// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolStringAttributeConstraintsFactory(Action<Humidifier.Cognito.UserPoolTypes.StringAttributeConstraints> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.StringAttributeConstraints>
{

    protected override Humidifier.Cognito.UserPoolTypes.StringAttributeConstraints Create()
    {
        var stringAttributeConstraintsResult = CreateStringAttributeConstraints();
        factoryAction?.Invoke(stringAttributeConstraintsResult);

        return stringAttributeConstraintsResult;
    }

    private Humidifier.Cognito.UserPoolTypes.StringAttributeConstraints CreateStringAttributeConstraints()
    {
        var stringAttributeConstraintsResult = new Humidifier.Cognito.UserPoolTypes.StringAttributeConstraints();

        return stringAttributeConstraintsResult;
    }

} // End Of Class

public static class InnerUserPoolStringAttributeConstraintsFactoryExtensions
{
}
