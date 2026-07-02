namespace UnitConverter
{
    public enum UnitType
    {
        Length,
        Volume,
        Mass,
        Time,
        Speed,
        Temperature,
        Data,
        Energy,
        Area,
        Angle
    }

    public enum MeasurmentSystem
    {
        Metric,
        Imperial
    }

    public enum VolumeUnitType
    {
        Metric,
        ImperialVolumeUS,
        ImperialVolumeUK,
        ImperialCubicLength
    }

    public enum VolumeLengthFunction
    {
        SidesOfCube,
        RadiusOfSphere,
        DiameterOfSphere
    }
}