// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CE;

public class InnerCostCategoryResourceTagFactory(Action<Humidifier.CE.CostCategoryTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.CE.CostCategoryTypes.ResourceTag>
{

    protected override Humidifier.CE.CostCategoryTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.CE.CostCategoryTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.CE.CostCategoryTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerCostCategoryResourceTagFactoryExtensions
{
}
