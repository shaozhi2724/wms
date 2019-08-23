namespace Reports
{
    public class ReportFunction
    {
        public static string ConvertToChinese(decimal x)
        {
            string s = x.ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A");
            string d = System.Text.RegularExpressions.Regex.Replace(s, @"((?<=-|^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[.]|$))))", "${b}${z}");
            var result = System.Text.RegularExpressions.Regex.Replace(d, ".", m => "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万億兆京垓秭穰"[m.Value[0] - '-'].ToString());
            if (result.EndsWith("元"))
            {
                result += "整";
            }
            return result;
        }
    }
}