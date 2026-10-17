// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableVectorAttributeFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute Create()
    {
        var vectorAttributeResult = CreateVectorAttribute();
        factoryAction?.Invoke(vectorAttributeResult);

        return vectorAttributeResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute CreateVectorAttribute()
    {
        var vectorAttributeResult = new Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute();

        return vectorAttributeResult;
    }

} // End Of Class

public static class InnerGlobalTableVectorAttributeFactoryExtensions
{
}
