public class Solution {

    public string Encode(IList<string> strs) {
       var sb = new StringBuilder(); 
       foreach (var str in strs) {
        if (string.IsNullOrEmpty(str)) {
            sb.Append("/s/");
            continue;
        }

        var count = 0;
        char? last = str[0];
        foreach (var c in str) {
            if (c == last) {
                count++;
            }
            else {
                sb.Append(count);
                sb.Append(last);
                sb.Append(",s,");
                count = 1;
                last = c;
            }
        }

        sb.Append(count);
        sb.Append(last);
        sb.Append("/s/");
       }

       return sb.ToString();
    }

    public List<string> Decode(string s) {
        var strs = new List<string>();
        var sb = new StringBuilder("");

        var count = 0;
        char last = '0';
        foreach (var str in s.Split("/s/").SkipLast(1)) {
            if (string.IsNullOrEmpty(str)) {
                strs.Add("");
                continue;
            }

            foreach (var group in str.Split(",s,")) {
                count = int.Parse(string.Join("", group.Take(group.Length - 1)));
                last = group[group.Length - 1];
                sb.Append(last, count);
            }

            strs.Add(sb.ToString());
            sb.Clear();
        }

        return strs;
   }
}
