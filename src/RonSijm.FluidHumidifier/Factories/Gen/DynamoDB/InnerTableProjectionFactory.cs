// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableProjectionFactory(Action<Humidifier.DynamoDB.TableTypes.Projection> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.Projection>
{

    protected override Humidifier.DynamoDB.TableTypes.Projection Create()
    {
        var projectionResult = CreateProjection();
        factoryAction?.Invoke(projectionResult);

        return projectionResult;
    }

    private Humidifier.DynamoDB.TableTypes.Projection CreateProjection()
    {
        var projectionResult = new Humidifier.DynamoDB.TableTypes.Projection();

        return projectionResult;
    }

} // End Of Class

public static class InnerTableProjectionFactoryExtensions
{
}
