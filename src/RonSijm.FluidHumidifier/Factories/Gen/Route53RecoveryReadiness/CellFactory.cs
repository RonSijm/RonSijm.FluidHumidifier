// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryReadiness;

public class CellFactory(string resourceName = null, Action<Humidifier.Route53RecoveryReadiness.Cell> factoryAction = null) : ResourceFactory<Humidifier.Route53RecoveryReadiness.Cell>(resourceName)
{

    protected override Humidifier.Route53RecoveryReadiness.Cell Create()
    {
        var cellResult = CreateCell();
        factoryAction?.Invoke(cellResult);

        return cellResult;
    }

    private Humidifier.Route53RecoveryReadiness.Cell CreateCell()
    {
        var cellResult = new Humidifier.Route53RecoveryReadiness.Cell
        {
            GivenName = InputResourceName,
        };

        return cellResult;
    }

} // End Of Class

public static class CellFactoryExtensions
{
}
