// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerTableRetentionPropertiesFactory(Action<Humidifier.Timestream.TableTypes.RetentionProperties> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.TableTypes.RetentionProperties>
{

    protected override Humidifier.Timestream.TableTypes.RetentionProperties Create()
    {
        var retentionPropertiesResult = CreateRetentionProperties();
        factoryAction?.Invoke(retentionPropertiesResult);

        return retentionPropertiesResult;
    }

    private Humidifier.Timestream.TableTypes.RetentionProperties CreateRetentionProperties()
    {
        var retentionPropertiesResult = new Humidifier.Timestream.TableTypes.RetentionProperties();

        return retentionPropertiesResult;
    }

} // End Of Class

public static class InnerTableRetentionPropertiesFactoryExtensions
{
}
