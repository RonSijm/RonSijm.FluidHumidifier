// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class TagFactory(string resourceName = null, Action<Humidifier.LakeFormation.Tag> factoryAction = null) : ResourceFactory<Humidifier.LakeFormation.Tag>(resourceName)
{

    protected override Humidifier.LakeFormation.Tag Create()
    {
        var tagResult = CreateTag();
        factoryAction?.Invoke(tagResult);

        return tagResult;
    }

    private Humidifier.LakeFormation.Tag CreateTag()
    {
        var tagResult = new Humidifier.LakeFormation.Tag
        {
            GivenName = InputResourceName,
        };

        return tagResult;
    }

} // End Of Class

public static class TagFactoryExtensions
{
}
