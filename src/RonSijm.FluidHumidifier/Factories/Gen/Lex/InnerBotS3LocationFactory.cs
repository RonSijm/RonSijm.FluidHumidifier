// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotS3LocationFactory(Action<Humidifier.Lex.BotTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.S3Location>
{

    protected override Humidifier.Lex.BotTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.Lex.BotTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.Lex.BotTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerBotS3LocationFactoryExtensions
{
}
