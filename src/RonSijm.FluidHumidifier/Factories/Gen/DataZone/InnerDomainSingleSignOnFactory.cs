// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerDomainSingleSignOnFactory(Action<Humidifier.DataZone.DomainTypes.SingleSignOn> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.DomainTypes.SingleSignOn>
{

    protected override Humidifier.DataZone.DomainTypes.SingleSignOn Create()
    {
        var singleSignOnResult = CreateSingleSignOn();
        factoryAction?.Invoke(singleSignOnResult);

        return singleSignOnResult;
    }

    private Humidifier.DataZone.DomainTypes.SingleSignOn CreateSingleSignOn()
    {
        var singleSignOnResult = new Humidifier.DataZone.DomainTypes.SingleSignOn();

        return singleSignOnResult;
    }

} // End Of Class

public static class InnerDomainSingleSignOnFactoryExtensions
{
}
