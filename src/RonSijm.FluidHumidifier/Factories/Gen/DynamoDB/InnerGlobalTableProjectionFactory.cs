// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableProjectionFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.Projection>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.Projection Create()
    {
        var projectionResult = CreateProjection();
        factoryAction?.Invoke(projectionResult);

        return projectionResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.Projection CreateProjection()
    {
        var projectionResult = new Humidifier.DynamoDB.GlobalTableTypes.Projection();

        return projectionResult;
    }

} // End Of Class

public static class InnerGlobalTableProjectionFactoryExtensions
{
}
