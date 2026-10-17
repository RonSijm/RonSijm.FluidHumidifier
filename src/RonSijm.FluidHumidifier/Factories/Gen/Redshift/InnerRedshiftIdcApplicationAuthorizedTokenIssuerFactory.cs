// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class InnerRedshiftIdcApplicationAuthorizedTokenIssuerFactory(Action<Humidifier.Redshift.RedshiftIdcApplicationTypes.AuthorizedTokenIssuer> factoryAction = null) : SubResourceFactory<Humidifier.Redshift.RedshiftIdcApplicationTypes.AuthorizedTokenIssuer>
{

    protected override Humidifier.Redshift.RedshiftIdcApplicationTypes.AuthorizedTokenIssuer Create()
    {
        var authorizedTokenIssuerResult = CreateAuthorizedTokenIssuer();
        factoryAction?.Invoke(authorizedTokenIssuerResult);

        return authorizedTokenIssuerResult;
    }

    private Humidifier.Redshift.RedshiftIdcApplicationTypes.AuthorizedTokenIssuer CreateAuthorizedTokenIssuer()
    {
        var authorizedTokenIssuerResult = new Humidifier.Redshift.RedshiftIdcApplicationTypes.AuthorizedTokenIssuer();

        return authorizedTokenIssuerResult;
    }

} // End Of Class

public static class InnerRedshiftIdcApplicationAuthorizedTokenIssuerFactoryExtensions
{
}
