// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerQuickResponseQuickResponseContentProviderFactory(Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider>
{

    protected override Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider Create()
    {
        var quickResponseContentProviderResult = CreateQuickResponseContentProvider();
        factoryAction?.Invoke(quickResponseContentProviderResult);

        return quickResponseContentProviderResult;
    }

    private Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider CreateQuickResponseContentProvider()
    {
        var quickResponseContentProviderResult = new Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider();

        return quickResponseContentProviderResult;
    }

} // End Of Class

public static class InnerQuickResponseQuickResponseContentProviderFactoryExtensions
{
}
