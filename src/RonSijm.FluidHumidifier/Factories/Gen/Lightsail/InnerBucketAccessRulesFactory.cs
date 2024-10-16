// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerBucketAccessRulesFactory(Action<Humidifier.Lightsail.BucketTypes.AccessRules> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.BucketTypes.AccessRules>
{

    protected override Humidifier.Lightsail.BucketTypes.AccessRules Create()
    {
        var accessRulesResult = CreateAccessRules();
        factoryAction?.Invoke(accessRulesResult);

        return accessRulesResult;
    }

    private Humidifier.Lightsail.BucketTypes.AccessRules CreateAccessRules()
    {
        var accessRulesResult = new Humidifier.Lightsail.BucketTypes.AccessRules();

        return accessRulesResult;
    }

} // End Of Class

public static class InnerBucketAccessRulesFactoryExtensions
{
}
