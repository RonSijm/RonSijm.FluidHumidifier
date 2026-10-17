// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerLayoutLayoutSectionsFactory(Action<Humidifier.Cases.LayoutTypes.LayoutSections> factoryAction = null) : SubResourceFactory<Humidifier.Cases.LayoutTypes.LayoutSections>
{

    protected override Humidifier.Cases.LayoutTypes.LayoutSections Create()
    {
        var layoutSectionsResult = CreateLayoutSections();
        factoryAction?.Invoke(layoutSectionsResult);

        return layoutSectionsResult;
    }

    private Humidifier.Cases.LayoutTypes.LayoutSections CreateLayoutSections()
    {
        var layoutSectionsResult = new Humidifier.Cases.LayoutTypes.LayoutSections();

        return layoutSectionsResult;
    }

} // End Of Class

public static class InnerLayoutLayoutSectionsFactoryExtensions
{
}
