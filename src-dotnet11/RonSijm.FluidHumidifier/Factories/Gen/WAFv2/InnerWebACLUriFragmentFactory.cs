// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLUriFragmentFactory(Action<Humidifier.WAFv2.WebACLTypes.UriFragment> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.UriFragment>
{

    protected override Humidifier.WAFv2.WebACLTypes.UriFragment Create()
    {
        var uriFragmentResult = CreateUriFragment();
        factoryAction?.Invoke(uriFragmentResult);

        return uriFragmentResult;
    }

    private Humidifier.WAFv2.WebACLTypes.UriFragment CreateUriFragment()
    {
        var uriFragmentResult = new Humidifier.WAFv2.WebACLTypes.UriFragment();

        return uriFragmentResult;
    }

} // End Of Class

public static class InnerWebACLUriFragmentFactoryExtensions
{
}
