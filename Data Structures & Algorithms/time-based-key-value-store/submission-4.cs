public class TimeMap {
    private Dictionary<string, List<(string value, int timestamp)>> _map;

    public TimeMap() {
        _map = new();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!_map.ContainsKey(key)) _map[key] = new();
        _map[key].Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if (!_map.ContainsKey(key)) return "";

        int l = 0;
        int r = _map[key].Count;

        while (l < r) {
            int m = (l + r) / 2;
            if (_map[key][m].timestamp <= timestamp) l = m + 1;
            else r = m;
        }

        return l > 0 && _map[key][l - 1].timestamp <= timestamp ? _map[key][l - 1].value : "";
    }
}
