using System;
using System.Text.Json;

public static class Language
{
    public static string? _Path;
    public static string? _JsonName;
    //初始化 入口代码 Path为文件夹路径 JsonName为创建的json名字:例如Json.json
    public static void LanguageReady(string Path,string JsonName)
    {
        string JsonPath = Path + "\\" + JsonName;
        if (!Directory.Exists(Path))
            Directory.CreateDirectory(Path);
        if (!File.Exists(JsonPath))
        {
            Options options = new Options() { Language = 0, };
            string jsonString = JsonSerializer.Serialize(options);
            File.WriteAllText(JsonPath, jsonString);
        }
        _Path = Path;
        _JsonName = JsonName;
    }
    //监视语言代码 自动修改语言文件 JsonName为创建的json名字:例如Json.json
    public static void LanguageObserve(string? Path,string? JsonName)
    {
        string? JsonPath = Path + "\\" + JsonName;
        string? jsonString = File.ReadAllText(JsonPath);
        Options? json = JsonSerializer.Deserialize<Options>(jsonString);
        //如果Langeuage属性为x则执行指定方法
        if (json?.Language == 0)
            Language_en.Change_en();
        if (json?.Language == 1)
            Language_cn.Change_cn();
    }

    public static string? test;
    public static string? one;
    public static string? two;
    public static string? code;
}
