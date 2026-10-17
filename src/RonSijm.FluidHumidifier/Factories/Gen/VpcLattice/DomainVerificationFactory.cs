// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class DomainVerificationFactory(string resourceName = null, Action<Humidifier.VpcLattice.DomainVerification> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.DomainVerification>(resourceName)
{

    protected override Humidifier.VpcLattice.DomainVerification Create()
    {
        var domainVerificationResult = CreateDomainVerification();
        factoryAction?.Invoke(domainVerificationResult);

        return domainVerificationResult;
    }

    private Humidifier.VpcLattice.DomainVerification CreateDomainVerification()
    {
        var domainVerificationResult = new Humidifier.VpcLattice.DomainVerification
        {
            GivenName = InputResourceName,
        };

        return domainVerificationResult;
    }

} // End Of Class

public static class DomainVerificationFactoryExtensions
{
}
