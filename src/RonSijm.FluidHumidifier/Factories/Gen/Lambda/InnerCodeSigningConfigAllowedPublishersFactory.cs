// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerCodeSigningConfigAllowedPublishersFactory(Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers>
{

    protected override Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers Create()
    {
        var allowedPublishersResult = CreateAllowedPublishers();
        factoryAction?.Invoke(allowedPublishersResult);

        return allowedPublishersResult;
    }

    private Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers CreateAllowedPublishers()
    {
        var allowedPublishersResult = new Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers();

        return allowedPublishersResult;
    }

} // End Of Class

public static class InnerCodeSigningConfigAllowedPublishersFactoryExtensions
{
}
