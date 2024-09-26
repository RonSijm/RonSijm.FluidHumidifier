// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory(Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider>
{

    protected override Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider Create()
    {
        var verifiedAccessTrustProviderResult = CreateVerifiedAccessTrustProvider();
        factoryAction?.Invoke(verifiedAccessTrustProviderResult);

        return verifiedAccessTrustProviderResult;
    }

    private Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider CreateVerifiedAccessTrustProvider()
    {
        var verifiedAccessTrustProviderResult = new Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider();

        return verifiedAccessTrustProviderResult;
    }

} // End Of Class

public static class InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactoryExtensions
{
}
