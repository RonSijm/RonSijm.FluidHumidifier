// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerIndexIndexCapacityConfigurationFactory(Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration>
{

    protected override Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration Create()
    {
        var indexCapacityConfigurationResult = CreateIndexCapacityConfiguration();
        factoryAction?.Invoke(indexCapacityConfigurationResult);

        return indexCapacityConfigurationResult;
    }

    private Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration CreateIndexCapacityConfiguration()
    {
        var indexCapacityConfigurationResult = new Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration();

        return indexCapacityConfigurationResult;
    }

} // End Of Class

public static class InnerIndexIndexCapacityConfigurationFactoryExtensions
{
}
