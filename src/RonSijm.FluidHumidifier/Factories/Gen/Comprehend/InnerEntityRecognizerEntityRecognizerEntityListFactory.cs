// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerEntityRecognizerEntityRecognizerEntityListFactory(Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerEntityList> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerEntityList>
{

    protected override Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerEntityList Create()
    {
        var entityRecognizerEntityListResult = CreateEntityRecognizerEntityList();
        factoryAction?.Invoke(entityRecognizerEntityListResult);

        return entityRecognizerEntityListResult;
    }

    private Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerEntityList CreateEntityRecognizerEntityList()
    {
        var entityRecognizerEntityListResult = new Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerEntityList();

        return entityRecognizerEntityListResult;
    }

} // End Of Class

public static class InnerEntityRecognizerEntityRecognizerEntityListFactoryExtensions
{
}
