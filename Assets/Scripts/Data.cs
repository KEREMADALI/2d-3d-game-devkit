using System.Collections.Generic;


[System.Serializable]
public class Data
{
    public string Key;
    public string Type;
    public List<string> Parameters;

    public Data(string type)
    {
        Key = string.Empty;
        Type = type;
        Parameters = new List<string>();
    }
}