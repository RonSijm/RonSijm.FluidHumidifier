// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class ContentFactory(string resourceName = null, Action<Humidifier.Wisdom.Content> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.Content>(resourceName)
{

    protected override Humidifier.Wisdom.Content Create()
    {
        var contentResult = CreateContent();
        factoryAction?.Invoke(contentResult);

        return contentResult;
    }

    private Humidifier.Wisdom.Content CreateContent()
    {
        var contentResult = new Humidifier.Wisdom.Content
        {
            GivenName = InputResourceName,
        };

        return contentResult;
    }

} // End Of Class

public static class ContentFactoryExtensions
{
}
