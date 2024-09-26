// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetFilterExpressionFactory(Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.FilterExpression>
{

    protected override Humidifier.DataBrew.DatasetTypes.FilterExpression Create()
    {
        var filterExpressionResult = CreateFilterExpression();
        factoryAction?.Invoke(filterExpressionResult);

        return filterExpressionResult;
    }

    private Humidifier.DataBrew.DatasetTypes.FilterExpression CreateFilterExpression()
    {
        var filterExpressionResult = new Humidifier.DataBrew.DatasetTypes.FilterExpression();

        return filterExpressionResult;
    }

} // End Of Class

public static class InnerDatasetFilterExpressionFactoryExtensions
{
}
