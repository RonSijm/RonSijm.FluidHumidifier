// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerIngressPointTrustStoreFactory(Action<Humidifier.SES.MailManagerIngressPointTypes.TrustStore> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerIngressPointTypes.TrustStore>
{

    protected override Humidifier.SES.MailManagerIngressPointTypes.TrustStore Create()
    {
        var trustStoreResult = CreateTrustStore();
        factoryAction?.Invoke(trustStoreResult);

        return trustStoreResult;
    }

    private Humidifier.SES.MailManagerIngressPointTypes.TrustStore CreateTrustStore()
    {
        var trustStoreResult = new Humidifier.SES.MailManagerIngressPointTypes.TrustStore();

        return trustStoreResult;
    }

} // End Of Class

public static class InnerMailManagerIngressPointTrustStoreFactoryExtensions
{
}
