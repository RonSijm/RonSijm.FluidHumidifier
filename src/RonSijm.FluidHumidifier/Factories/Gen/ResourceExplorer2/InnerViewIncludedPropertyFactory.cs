// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceExplorer2;

public class InnerViewIncludedPropertyFactory(Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> factoryAction = null) : SubResourceFactory<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty>
{

    protected override Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty Create()
    {
        var includedPropertyResult = CreateIncludedProperty();
        factoryAction?.Invoke(includedPropertyResult);

        return includedPropertyResult;
    }

    private Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty CreateIncludedProperty()
    {
        var includedPropertyResult = new Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty();

        return includedPropertyResult;
    }

} // End Of Class

public static class InnerViewIncludedPropertyFactoryExtensions
{
}
