using System;
using System.Text.Json;

public static class Language_en
{
    public static void Change_jsonEn()
    {
        string JsonPath = Language._Path + "\\" + Language._JsonName;
        Options options = new Options() { Language = 0, };
        string jsonString = JsonSerializer.Serialize(options);
        File.WriteAllText(JsonPath, jsonString);
    }
    public static void Change_en()
	{
        Language.test = "Test";
        Language.one = "One";
        Language.two = "Two";
        Language.code = "Code";
    }
}
