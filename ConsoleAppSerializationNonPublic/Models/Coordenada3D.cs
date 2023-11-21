using System.Text.Json.Serialization;

namespace ConsoleAppSerializationNonPublic.Models;

public class Coordenada3D
{
    [JsonConstructor]
    internal Coordenada3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    [JsonInclude]
    internal double X { get; }

    [JsonInclude]
    protected double Y { get; }

    [JsonInclude]
    private double Z { get; }

    public void Show() =>   
        Console.WriteLine($"{nameof(Coordenada3D)}.{nameof(Show)}(): " +
            $"X = {X} | Y = {Y} | Z = {Z}");
}