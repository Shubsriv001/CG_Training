using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

class SensorReading
{
    public int SensorId;
    public string? Type;
    public double Value;
    public DateTime Timestamp;
    public double Confidence;

    enum RobotAction { Stop, SlowDown, Reroute, Continue };

    // Task1
    public List<SensorReading> GetRecentReadings(List<SensorReading> sensorHistory, DateTime fromTime)
    {
        var time = sensorHistory.Where(t => t.Timestamp >= fromTime).ToList();
        return time;
    }

    // Task2
    public bool IsBatteryCritical(List<SensorReading> readings)
    {
        return readings.Any(r => r.Type == "Battery" && r.Value < 20);
    }

    // Task3
    public double GetNearestObstacleDistance(List<SensorReading> readings)
    {
        var minDist = readings.Where(r => r.Type == "Distance sensor");
        if (!minDist.Any())
        {
            return double.MaxValue;
        }
        else
        {
            var minVal = minDist.OrderBy(m => m.Value);
            return minVal.First().Value;
        }
    }

    // Task4
    public bool IsTemperatureSafe(List<SensorReading> readings)
    {
        var temp = readings.Where(v => v.Type == "Temperature").All(a => a.Value < 90);
        return temp;
    }

    // Task5
    public double GetAverageVibration(List<SensorReading> readings)
    {
        return readings.Where(v => v.Type == "Vibration").Average(avg => avg.Value);
    }

    // Task6
    // public Dictionary<string,double>CalculateSensorHealth(List<SensorReading>sensorHistory){
    // }

    // Task7
    public List<string> DetectFaultySensors(List<SensorReading> sensorHistory)
    {
        List<string> list = new List<string>();

        foreach (RobotAction i in Enum.GetValues(typeof(RobotAction)))
        {
            var fault = sensorHistory.Where(s => s.Type == i.ToString()).All(a => a.Value < 0.4);

            if (fault)
                list.Add(i.ToString());
        }
        return list;
    }

    // Task8
    // public bool IsBatteryDrainingFast(List<SensorReading>sensorHistory)
    //     {
    //     }

    // Task9
    public double GetWeightedDistance(List<SensorReading> readings)
    {
        return readings
            .Where(s => s.Type == "Distance")
            .Sum(s => s.Value * s.Confidence);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        SensorReading sr = new SensorReading();

        List<SensorReading> list = new List<SensorReading>
        {
            new SensorReading
            {
                SensorId = 101,
                Type = "Temperature",
                Value = 40.2,
                Timestamp = DateTime.Now,
                Confidence = 12.25
            }
        };

        sr.GetRecentReadings(list, DateTime.Now);
        sr.IsTemperatureSafe(list);
    }
}
