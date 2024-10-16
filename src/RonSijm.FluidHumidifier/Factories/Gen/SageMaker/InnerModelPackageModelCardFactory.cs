// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageModelCardFactory(Action<Humidifier.SageMaker.ModelPackageTypes.ModelCard> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.ModelCard>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.ModelCard Create()
    {
        var modelCardResult = CreateModelCard();
        factoryAction?.Invoke(modelCardResult);

        return modelCardResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.ModelCard CreateModelCard()
    {
        var modelCardResult = new Humidifier.SageMaker.ModelPackageTypes.ModelCard();

        return modelCardResult;
    }

} // End Of Class

public static class InnerModelPackageModelCardFactoryExtensions
{
}
