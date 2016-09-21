﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Res_ui_sprite : IDB_BaseInt
{
	const string SQL = @"select _index, id, sprite_path, sprite_name, comment, is_atlas from conf_res_ui_sprite";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///id
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///路径
	/// </summary>
	public string Sprite_path { get; set; }
	/// <summary>
	///名称
	/// </summary>
	public string Sprite_name { get; set; }
	/// <summary>
	///备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///是否图集
	/// </summary>
	public int Is_atlas { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Res_ui_sprite module = new DB_Res_ui_sprite()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Sprite_path		 = reader.GetString(2),
					Sprite_name		 = reader.GetString(3),
					Comment		 = reader.GetString(4),
					Is_atlas		 = reader.GetInt32(5),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}
