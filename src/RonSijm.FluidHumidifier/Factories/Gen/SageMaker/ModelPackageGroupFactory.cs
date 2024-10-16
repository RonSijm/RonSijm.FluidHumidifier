// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ModelPackageGroupFactory(string resourceName = null, Action<Humidifier.SageMaker.ModelPackageGroup> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.ModelPackageGroup>(resourceName)
{

    protected override Humidifier.SageMaker.ModelPackageGroup Create()
    {
        var modelPackageGroupResult = CreateModelPackageGroup();
        factoryAction?.Invoke(modelPackageGroupResult);

        return modelPackageGroupResult;
    }

    private Humidifier.SageMaker.ModelPackageGroup CreateModelPackageGroup()
    {
        var modelPackageGroupResult = new Humidifier.SageMaker.ModelPackageGroup
        {
            GivenName = InputResourceName,
        };

        return modelPackageGroupResult;
    }

} // End Of Class

public static class ModelPackageGroupFactoryExtensions
{
}
