// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLSingleQueryArgumentFactory(Action<Humidifier.WAFv2.WebACLTypes.SingleQueryArgument> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.SingleQueryArgument>
{

    protected override Humidifier.WAFv2.WebACLTypes.SingleQueryArgument Create()
    {
        var singleQueryArgumentResult = CreateSingleQueryArgument();
        factoryAction?.Invoke(singleQueryArgumentResult);

        return singleQueryArgumentResult;
    }

    private Humidifier.WAFv2.WebACLTypes.SingleQueryArgument CreateSingleQueryArgument()
    {
        var singleQueryArgumentResult = new Humidifier.WAFv2.WebACLTypes.SingleQueryArgument();

        return singleQueryArgumentResult;
    }

} // End Of Class

public static class InnerWebACLSingleQueryArgumentFactoryExtensions
{
}
