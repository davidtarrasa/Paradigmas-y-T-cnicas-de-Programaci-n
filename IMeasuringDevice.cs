namespace Practice2
{
    public interface IMeasuringDevice
    {
        void Measure(Vehicle vehicle);
        string GetLastMeasurement();
    }
}
