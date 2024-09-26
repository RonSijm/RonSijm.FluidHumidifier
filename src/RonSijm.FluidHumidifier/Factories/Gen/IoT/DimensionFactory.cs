// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class DimensionFactory(string resourceName = null, Action<Humidifier.IoT.Dimension> factoryAction = null) : ResourceFactory<Humidifier.IoT.Dimension>(resourceName)
{

    protected override Humidifier.IoT.Dimension Create()
    {
        var dimensionResult = CreateDimension();
        factoryAction?.Invoke(dimensionResult);

        return dimensionResult;
    }

    private Humidifier.IoT.Dimension CreateDimension()
    {
        var dimensionResult = new Humidifier.IoT.Dimension
        {
            GivenName = InputResourceName,
        };

        return dimensionResult;
    }

} // End Of Class

public static class DimensionFactoryExtensions
{
}
