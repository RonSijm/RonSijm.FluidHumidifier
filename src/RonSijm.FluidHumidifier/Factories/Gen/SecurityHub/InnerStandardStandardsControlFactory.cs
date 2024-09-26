// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerStandardStandardsControlFactory(Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.StandardTypes.StandardsControl>
{

    protected override Humidifier.SecurityHub.StandardTypes.StandardsControl Create()
    {
        var standardsControlResult = CreateStandardsControl();
        factoryAction?.Invoke(standardsControlResult);

        return standardsControlResult;
    }

    private Humidifier.SecurityHub.StandardTypes.StandardsControl CreateStandardsControl()
    {
        var standardsControlResult = new Humidifier.SecurityHub.StandardTypes.StandardsControl();

        return standardsControlResult;
    }

} // End Of Class

public static class InnerStandardStandardsControlFactoryExtensions
{
}
