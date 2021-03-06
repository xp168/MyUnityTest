﻿using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class SQL2TextConstClassModel
{

    const string SQL = @"select key, value from conf_data_dictionary";
    public Dictionary<string, string> textKey = new Dictionary<string, string>();

    public void Export()
    {
        LoadDB();
        CreateClass(JoinClass());
    }

    public void CheckExport()
    {
        LoadDB();
        ParsePrimaryKey();
    }

    void LoadDB()
    {
#if SQL2TextConstClassModel
        string path = Path.Combine(Application.persistentDataPath, "tk.db");
        DBHelper.Instance.OpenConnection(path);

        DBHelper.Instance.Query(SQL, (reader) =>
        {
            if (reader == null) return;

            while (reader.Read())
            {
                string key = Excel2ClassUtils.FormatString(reader.GetString(0));
                if (key.IndexOf("//") != -1 || string.IsNullOrEmpty(key))
                {
                    continue;
                }

                textKey.Add(key, Excel2ClassUtils.FormatString(reader.GetString(1)));
            }
        });

        DBHelper.Instance.CloseConnection();
#endif
    }

    // 生成类
    void CreateClass(StringBuilder builder)
    {
        string OutDir = Application.dataPath + "/Scripts/DB/";

        if (!Directory.Exists(OutDir))
        {
            Directory.CreateDirectory(OutDir);
        }

        using (var fs = new FileStream(OutDir + "DB_TEXT_CONST.cs", FileMode.Create))
        {
            using (var sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.Write(builder.ToString());
                sw.Flush();
                sw.Close();
            }
            fs.Close();
        }

        Debug.Log("导出Text常量类完成");
    }

    // 拼接类
    StringBuilder JoinClass()
    {
        StringBuilder builder = new StringBuilder();

        builder.AppendLine("/// <summary>");
        builder.AppendLine("/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!");
        builder.AppendLine("/// </summary>");
        builder.AppendLine("public class DB_TEXT_CONST");
        builder.AppendLine("{");

        foreach (var item in textKey)
        {
            builder.Append("\t").AppendLine("/// <summary>");
            builder.Append("\t/// ").AppendLine(item.Value);
            builder.AppendLine("\t/// </summary>");
            builder.Append("\t").Append("public const string ").Append(item.Key).Append(" = \"").Append(item.Key).AppendLine("\";");
        }

        builder.AppendLine("}");

        return builder;
    }

    void ParsePrimaryKey()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("<color=red>");

        bool exist = false;

        foreach (var item in textKey)
        {
            if (isInvalid(item.Key))     
            {
                builder.Append("无效的Key: ").AppendLine(item.Key);
                exist = true;
            }
        }

        builder.Append("</color>");
        if (exist)
        {
            Debug.Log(builder.ToString());
        }
        else
        {
            Debug.Log("检查完成，没有发现问题");
        }
    }

    string[] NUMBERS = {
        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
    };

    bool isInvalid(string key)
    {
        if (key.IndexOf(" ") != -1)
        {
            // 含有空格
            return true;
        }

        var firstChar = key.Substring(0, 1);
        foreach (var item in NUMBERS)
        {
            if (item.Equals(firstChar))
            {
                // 数字开头
                return true;
            }
        }
        return false;
    }
}


