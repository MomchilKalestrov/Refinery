using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refinery
{
    internal static class Config
    {
        public static string Port               { get; set; } = "COM3";
        public static int    Baud               { get; set; } = 9600;
        public static int    Bits               { get; set; } = 8;
        public static string StartAudioPath     { get; set; } = @".\assets\start.wav";
        public static string EndAudioPath       { get; set; } = @".\assets\end.wav";
        public static string EmergencyAudioPath { get; set; } = @".\assets\emergency.wav";
        public static string TimetablePath      { get; set; } = @".\assets\timetable";

        public static void ReadConfigFile()
        {
            string[] config = File.ReadAllLines(@".\config");
            foreach (string line in config)
            {
                string key = line.Split('=')[0].Trim();
                string value = line.Split('=')[1].Trim();
                switch(key)
                {
                    case "port":            Port = value;               break;
                    case "baud":            Baud = int.Parse(value);    break;
                    case "bits":            Bits = int.Parse(value);    break;
                    case "start-audio":     StartAudioPath = value;     break;
                    case "end-audio":       EndAudioPath = value;       break;
                    case "emergency-audio": EmergencyAudioPath = value; break;
                    case "timetable":       TimetablePath = value;      break;
                }
            }
        }

        public static void DumpToConfigFile()
        {
            if(File.Exists(@".\config"))
                File.Delete(@".\config");

            using StreamWriter sw = File.CreateText(@".\config");
            sw.Write(
                $"port = {Port}\n" +
                $"baud = {Baud}\n" +
                $"bits = {Bits}\n" +
                $"start-audio = {StartAudioPath}\n" +
                $"end-audio = {EndAudioPath}\n" +
                $"emergency-audio = {EmergencyAudioPath}\n" +
                $"timetable = {TimetablePath}"
            );
        }
    }
}
