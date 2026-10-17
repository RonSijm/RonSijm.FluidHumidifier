// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerIndexMappingsFactory(Action<Humidifier.OpenSearchServerless.IndexTypes.Mappings> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.IndexTypes.Mappings>
{

    protected override Humidifier.OpenSearchServerless.IndexTypes.Mappings Create()
    {
        var mappingsResult = CreateMappings();
        factoryAction?.Invoke(mappingsResult);

        return mappingsResult;
    }

    private Humidifier.OpenSearchServerless.IndexTypes.Mappings CreateMappings()
    {
        var mappingsResult = new Humidifier.OpenSearchServerless.IndexTypes.Mappings();

        return mappingsResult;
    }

} // End Of Class

public static class InnerIndexMappingsFactoryExtensions
{
}
