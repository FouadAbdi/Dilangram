using Dilangram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using TL;

namespace DilangramCore
{
    public static class CustomMessageParser
    {
        private static long chatIdArvanCrypto = 2077120351;
        private static long chatIdAryaSarmayeh = 2004920191;


        public static void Parse(long chatId, string msgText)
        {

            //GG Shot Leak
            if (chatId == 1751937746)
            {

                if (msgText.Contains("Entry Zone") && msgText.Contains("Accuracy") &&
                    msgText.Contains("Leverage") && msgText.Contains("Target") && msgText.Contains("Stop-Loss"))
                {

                    // Define regular expressions to extract relevant information
                    Regex coinNameRegex = new Regex(@"#(\w+)\s");
                    Regex entryZoneRegex = new Regex(@"Entry Zone: (\d+\.\d+)");
                    Regex leverageRegex = new Regex(@"Leverage: (\d+x)");
                    Regex stopLossRegex = new Regex(@"Stop-Loss: (\d+\.\d+)");
                    Regex targetRegex = new Regex(@"Target \d+ : (\d+\.\d+)");

                    // Match the regular expressions in the signal string
                    string coinName = coinNameRegex.Match(msgText).Groups[1].Value;
                    string entryZone = entryZoneRegex.Match(msgText).Groups[1].Value;
                    string leverage = leverageRegex.Match(msgText).Groups[1].Value;
                    string stopLoss = stopLossRegex.Match(msgText).Groups[1].Value;

                    string PositionSide = "";

                    if (double.Parse(entryZone) > double.Parse(stopLoss))
                    {
                        PositionSide = "🟢 Long";
                    }
                    if (double.Parse(stopLoss) > double.Parse(entryZone))
                    {
                        PositionSide = "🔴 Short";
                    }

                    var targetMatches = targetRegex.Matches(msgText).Select(x => x.Groups[0].Value);

                    string signalString = SignalFormater(coinName, PositionSide, leverage, entryZone, stopLoss, targetMatches);



                    MainForm.SendTextToChat(chatIdArvanCrypto, signalString);
                    MainForm.SendTextToChat(chatIdAryaSarmayeh, signalString);
                    MainForm.SendTextToChat(2034026667, signalString);
                }



            }


            //Signal 300
            if (chatId == 1888479457)
            {
                if (msgText.Contains("SCALPING") && msgText.Contains("🔥Stoploss") &&
                   msgText.Contains("Entry") && msgText.Contains("Entry") && msgText.Contains("Target"))
                {

                    Regex coinNameRegex = new Regex(@"\.\.\. (.*?) \.\.\.");
                    Regex directionRegex = new Regex(@"LONG|SHORT");
                    Regex entryZoneRegex = new Regex(@"Entry\s:\s(\d+\.\d+)\s-\s(\d+\.\d+)");
                    Regex leverageRegex = new Regex(@"Cross\s(\d+x)");
                    Regex stopLossRegex = new Regex(@"Stoploss\s:\s(\d+\.\d+)");
                    Regex targetRegex = new Regex(@"Target\s\d+\s-\s(\d+\.\d+)");

                    string coinName = coinNameRegex.Match(msgText).Groups[1].Value;
                    string direction = directionRegex.Match(msgText).Value;
                    Match entryZoneMatch = entryZoneRegex.Match(msgText);
                    string entryZoneStart = entryZoneMatch.Groups[1].Value;
                    string entryZoneEnd = entryZoneMatch.Groups[2].Value;
                    string leverage = leverageRegex.Match(msgText).Groups[1].Value;
                    string stopLoss = stopLossRegex.Match(msgText).Groups[1].Value;

                    List<string> tps = new List<string>();
                    MatchCollection targetMatches = targetRegex.Matches(msgText);
                    foreach (Match match in targetMatches)
                    {
                        tps.Add(match.Groups[1].Value);
                    }

                    string signalString = SignalFormater(coinName, direction, leverage, entryZoneStart + " - " + entryZoneEnd, stopLoss, tps);

                    MainForm.SendTextToChat(chatIdArvanCrypto, signalString);
                    MainForm.SendTextToChat(chatIdAryaSarmayeh, signalString);
                    MainForm.SendTextToChat(2046170109, signalString);
                }
            }

            //Haji crypto
            if (chatId == 1597843631)
            {
                if (msgText.Contains("SCALPING") && msgText.Contains("🔥Stoploss") &&
                 msgText.Contains("Entry") && msgText.Contains("Entry") && msgText.Contains("Target"))
                {
                    Regex coinNameRegex = new Regex(@"coin: #(\w+\/\w+)");
                    Regex directionRegex = new Regex(@"regular \(short\)");
                    Regex entryZoneRegex = new Regex(@"entry targets:\n([\d.]+)");
                    Regex leverageRegex = new Regex(@"leverage: cross \((\d+)х\)");
                    Regex stopLossRegex = new Regex(@"stop loss target:\n(\d+-\d+)%");
                    Regex targetRegex = new Regex(@"\d+\)([\d.]+)");

                    string coinName = coinNameRegex.Match(msgText).Groups[1].Value;
                    string direction = directionRegex.Match(msgText).Value;
                    string entryZone = entryZoneRegex.Match(msgText).Groups[1].Value;
                    string leverage = leverageRegex.Match(msgText).Groups[1].Value;
                    string stopLoss = stopLossRegex.Match(msgText).Groups[1].Value;

                    List<string> tps = new List<string>();
                    MatchCollection targetMatches = targetRegex.Matches(msgText);
                    foreach (Match match in targetMatches)
                    {
                        tps.Add(match.Groups[1].Value);
                    }

                    string signalString = SignalFormater(coinName, direction, leverage, entryZone, stopLoss, tps);

                    MainForm.SendTextToChat(chatIdArvanCrypto, signalString);
                    MainForm.SendTextToChat(chatIdAryaSarmayeh, signalString);
                    MainForm.SendTextToChat(2024200700, signalString);
                }
            }

        }




        public static string SignalFormater(string coin, string positionSide, string leverage, string entryZone, string stopLoss, IEnumerable<string> targets)
        {
            string result = $"💱 {coin}\r\n{positionSide}\r\n📊 Loverage : {leverage}\r\n💰 Entry : {entryZone}\r\n❌ Stoploss : {stopLoss}\r\n";

            foreach (var tp in targets)
            {
                if (string.IsNullOrEmpty(tp) == false)
                    result += ($"💡 Target : {tp}\r\n");
            }

            return result;
        }

    }
}
