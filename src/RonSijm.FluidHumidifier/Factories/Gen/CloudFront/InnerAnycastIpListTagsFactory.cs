// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerAnycastIpListTagsFactory(Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.AnycastIpListTypes.Tags>
{

    protected override Humidifier.CloudFront.AnycastIpListTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.CloudFront.AnycastIpListTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.CloudFront.AnycastIpListTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerAnycastIpListTagsFactoryExtensions
{
}
