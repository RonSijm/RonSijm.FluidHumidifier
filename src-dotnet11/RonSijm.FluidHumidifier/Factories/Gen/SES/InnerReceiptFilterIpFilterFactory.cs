// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerReceiptFilterIpFilterFactory(Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> factoryAction = null) : SubResourceFactory<Humidifier.SES.ReceiptFilterTypes.IpFilter>
{

    protected override Humidifier.SES.ReceiptFilterTypes.IpFilter Create()
    {
        var ipFilterResult = CreateIpFilter();
        factoryAction?.Invoke(ipFilterResult);

        return ipFilterResult;
    }

    private Humidifier.SES.ReceiptFilterTypes.IpFilter CreateIpFilter()
    {
        var ipFilterResult = new Humidifier.SES.ReceiptFilterTypes.IpFilter();

        return ipFilterResult;
    }

} // End Of Class

public static class InnerReceiptFilterIpFilterFactoryExtensions
{
}
