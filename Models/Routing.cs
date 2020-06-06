using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LoLPerformanceAnalysisAPI.Models
{
    public class Routing 
    {
        public enum Platform
        {
            BR,
            EUN,
            EUW,
            JP,
            KR,
            LA1,
            LA2,
            NA,
            OC,
            TR,
            RU
        }

        // Returns EUW if the platform is unrecognised
        public static Platform StringToPlatform(string platform) => platform.ToLower() switch
        {
            "br1" => Platform.BR,
            "eun1" => Platform.EUN,
            "euw1" => Platform.EUW,
            "jp1" => Platform.JP,
            "kr1" => Platform.KR,
            "la1" => Platform.LA1,
            "la2" => Platform.LA2,
            "na1" => Platform.NA,
            "oc1" => Platform.OC,
            "tr1" => Platform.TR,
            "ru1" => Platform.RU,
            _ => Platform.EUW
        };

        // Returns EUW if the platform is unrecognised
        public static string ClientPlatformToPlatform(string platform) => platform.ToLower() switch
        {
            "br" => "br1",
            "eun" => "eun1",
            "euw" => "euw1",
            "jp" => "jp1",
            "kr" => "kr1",
            "na" => "na1",
            "oc" => "oc1",
            "tr" => "tr1",
            "ru" => "ru1",
            _ => platform.ToLower()
        };

        public static string PlatformToString(Platform platform) => platform switch 
        {
            Platform.BR => "br1",
            Platform.EUN => "eun1",
            Platform.EUW => "euw1",
            Platform.JP => "jp1",
            Platform.KR => "kr1",
            Platform.LA1 => "la1",
            Platform.LA2 => "la2",
            Platform.NA => "na1",
            Platform.OC => "oc1",
            Platform.TR => "tr1",
            Platform.RU => "ru1",
            _ => "euw1"
        };

        public enum Regions
        {
            AMERICA,
            ASIA,
            EUROPE
        }

        public static Regions StringToRegions(string region) => region switch
        {
            "america" => Regions.AMERICA,
            "asia" => Regions.ASIA,
            "europe" => Regions.EUROPE,
            _ => Regions.EUROPE
        };

        public static string RegionsToString(Regions region) => region switch
        {
            Regions.AMERICA => "america",
            Regions.ASIA => "asia",
            Regions.EUROPE => "europe",
            _ => "europe"
        };
    }

}