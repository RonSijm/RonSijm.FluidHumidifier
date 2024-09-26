// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLSingleHeaderFactory(Action<Humidifier.WAFv2.WebACLTypes.SingleHeader> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.SingleHeader>
{

    protected override Humidifier.WAFv2.WebACLTypes.SingleHeader Create()
    {
        var singleHeaderResult = CreateSingleHeader();
        factoryAction?.Invoke(singleHeaderResult);

        return singleHeaderResult;
    }

    private Humidifier.WAFv2.WebACLTypes.SingleHeader CreateSingleHeader()
    {
        var singleHeaderResult = new Humidifier.WAFv2.WebACLTypes.SingleHeader();

        return singleHeaderResult;
    }

} // End Of Class

public static class InnerWebACLSingleHeaderFactoryExtensions
{
}
