// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerComponentComponentVariantFactory(Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant>
{

    protected override Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant Create()
    {
        var componentVariantResult = CreateComponentVariant();
        factoryAction?.Invoke(componentVariantResult);

        return componentVariantResult;
    }

    private Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant CreateComponentVariant()
    {
        var componentVariantResult = new Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant();

        return componentVariantResult;
    }

} // End Of Class

public static class InnerComponentComponentVariantFactoryExtensions
{
}
