// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerIndexIndexFactory(Action<Humidifier.OpenSearchServerless.IndexTypes.Index> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.IndexTypes.Index>
{

    protected override Humidifier.OpenSearchServerless.IndexTypes.Index Create()
    {
        var indexResult = CreateIndex();
        factoryAction?.Invoke(indexResult);

        return indexResult;
    }

    private Humidifier.OpenSearchServerless.IndexTypes.Index CreateIndex()
    {
        var indexResult = new Humidifier.OpenSearchServerless.IndexTypes.Index();

        return indexResult;
    }

} // End Of Class

public static class InnerIndexIndexFactoryExtensions
{
}
