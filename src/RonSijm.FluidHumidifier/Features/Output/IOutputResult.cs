namespace RonSijm.FluidHumidifier.Features.Output;

public interface IOutputResult<T> : IOutputResult
{
    T Stack { get; set; }
}

public interface IOutputResult
{
    string BaseDir { get; set; }
    string RelativePath { get; set; }
    string LinuxRelativePath { get; }
    string FileName { get; }
    string Name { get; set; }
    string Description { get; }
}