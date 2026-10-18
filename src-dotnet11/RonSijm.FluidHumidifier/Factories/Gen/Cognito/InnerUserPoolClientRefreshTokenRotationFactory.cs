// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolClientRefreshTokenRotationFactory(Action<Humidifier.Cognito.UserPoolClientTypes.RefreshTokenRotation> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolClientTypes.RefreshTokenRotation>
{

    protected override Humidifier.Cognito.UserPoolClientTypes.RefreshTokenRotation Create()
    {
        var refreshTokenRotationResult = CreateRefreshTokenRotation();
        factoryAction?.Invoke(refreshTokenRotationResult);

        return refreshTokenRotationResult;
    }

    private Humidifier.Cognito.UserPoolClientTypes.RefreshTokenRotation CreateRefreshTokenRotation()
    {
        var refreshTokenRotationResult = new Humidifier.Cognito.UserPoolClientTypes.RefreshTokenRotation();

        return refreshTokenRotationResult;
    }

} // End Of Class

public static class InnerUserPoolClientRefreshTokenRotationFactoryExtensions
{
}
