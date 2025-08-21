using System.Text.RegularExpressions;

namespace MessageParserConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msgText = "꧁༺ 𝓢𝓒𝓐𝓛𝓟𝓘𝓝𝓖 300 ༻꧂\n\n✬S◦C°A˚L°P◦I... CHZUSDT ...N◦G°3˚0°0◦0✬\n𝓓𝓲𝓻𝓮𝓬𝓽𝓲𝓸𝓷 : LONG\nLeverage : Cross 20x\n★ Entry : 0.1338 - 0.13294 ★\n\n🔥Stoploss : 0.123096🔥\n\nミ★ SCALPING ★彡\nTarget 1 - 0.134469\nTarget 2 - 0.135138\nTarget 3 - 0.136476\nミ★ DAY TRADING ★彡\nTarget 4 - 0.137814\nTarget 5 - 0.139152\nTarget 6 - 0.14049\nミ★ SWING TRADING ★彡\nTarget 7 - 0.141828\nTarget 8 - 0.143166";
            
            
            Regex coinNameRegex = new Regex(@"\.\.\. (.*?) \.\.\.");

            var coinNameMatch = coinNameRegex.Match(msgText).Groups[1].Value;
            


            Console.ReadLine();
        }
    }
}
