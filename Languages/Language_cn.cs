using System;
using System.Text.Json;
using System.Text.Json.Nodes;

public static class Language_cn
{
    public static void Change_jsonCn()
	{
        string JsonPath = Language._Path + "\\" + Language._JsonName;
        Options options = new Options() { Language = 1, };
        string jsonString = JsonSerializer.Serialize(options);
        File.WriteAllText(JsonPath, jsonString);
    }
	public static void Change_cn()
	{
        Language.test = "²âÊÔ";
        Language.one = "Ò»";
        Language.two = "¶þ";
        Language.code = "´úÂë";
	}
}
