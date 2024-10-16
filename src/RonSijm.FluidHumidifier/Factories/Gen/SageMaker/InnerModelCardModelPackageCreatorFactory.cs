// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardModelPackageCreatorFactory(Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator>
{

    protected override Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator Create()
    {
        var modelPackageCreatorResult = CreateModelPackageCreator();
        factoryAction?.Invoke(modelPackageCreatorResult);

        return modelPackageCreatorResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator CreateModelPackageCreator()
    {
        var modelPackageCreatorResult = new Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator();

        return modelPackageCreatorResult;
    }

} // End Of Class

public static class InnerModelCardModelPackageCreatorFactoryExtensions
{
}
