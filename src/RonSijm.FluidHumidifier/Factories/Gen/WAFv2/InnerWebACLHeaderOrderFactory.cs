// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLHeaderOrderFactory(Action<Humidifier.WAFv2.WebACLTypes.HeaderOrder> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.HeaderOrder>
{

    protected override Humidifier.WAFv2.WebACLTypes.HeaderOrder Create()
    {
        var headerOrderResult = CreateHeaderOrder();
        factoryAction?.Invoke(headerOrderResult);

        return headerOrderResult;
    }

    private Humidifier.WAFv2.WebACLTypes.HeaderOrder CreateHeaderOrder()
    {
        var headerOrderResult = new Humidifier.WAFv2.WebACLTypes.HeaderOrder();

        return headerOrderResult;
    }

} // End Of Class

public static class InnerWebACLHeaderOrderFactoryExtensions
{
}
