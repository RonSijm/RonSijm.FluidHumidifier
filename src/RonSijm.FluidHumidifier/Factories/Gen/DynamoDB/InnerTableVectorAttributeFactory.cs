// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableVectorAttributeFactory(Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.VectorAttribute>
{

    protected override Humidifier.DynamoDB.TableTypes.VectorAttribute Create()
    {
        var vectorAttributeResult = CreateVectorAttribute();
        factoryAction?.Invoke(vectorAttributeResult);

        return vectorAttributeResult;
    }

    private Humidifier.DynamoDB.TableTypes.VectorAttribute CreateVectorAttribute()
    {
        var vectorAttributeResult = new Humidifier.DynamoDB.TableTypes.VectorAttribute();

        return vectorAttributeResult;
    }

} // End Of Class

public static class InnerTableVectorAttributeFactoryExtensions
{
}
