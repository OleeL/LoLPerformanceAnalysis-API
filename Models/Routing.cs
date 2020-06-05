using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LoLPerformanceAnalysisAPI.Models
{
    public class Routing 
    {
        public enum Platform {
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
            "br" => Platform.BR,
            "eun" => Platform.EUN,
            "euw" => Platform.EUW,
            "jp" => Platform.JP,
            "kr" => Platform.KR,
            "la1" => Platform.LA1,
            "la2" => Platform.LA2,
            "na" => Platform.NA,
            "oc" => Platform.OC,
            "tr" => Platform.TR,
            "ru" => Platform.RU,
            _ => Platform.EUW
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

        public enum Regions {
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