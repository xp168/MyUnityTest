﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Loading_tips : IDB_BaseInt
{
	const string SQL = @"select _index, id, tips from conf_loading_tips";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///用来随机的id，务必保持连贯
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///loading时的小提示文本，此列数据为对应的字典号
	/// </summary>
	public string Tips { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Loading_tips module = new DB_Loading_tips()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Tips		 = reader.GetString(2),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}