﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Res_strengthen_level : IDB_BaseInt
{
	const string SQL = @"select _index, id, ui_sprite_id from conf_res_strengthen_level";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///强化级别ID
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///强化图标ID
	/// </summary>
	public int Ui_sprite_id { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Res_strengthen_level module = new DB_Res_strengthen_level()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Ui_sprite_id		 = reader.GetInt32(2),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}