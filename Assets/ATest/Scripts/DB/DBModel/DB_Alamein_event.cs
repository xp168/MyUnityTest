﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Alamein_event : IDB_BaseInt
{
	const string SQL = @"select _index, id, comment, battle_type_id, event_battle_id, unlock_level from conf_alamein_event";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///关卡id
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///战斗类型id
	/// </summary>
	public int Battle_type_id { get; set; }
	/// <summary>
	///活动战场id
	/// </summary>
	public int Event_battle_id { get; set; }
	/// <summary>
	///解锁等级
	/// </summary>
	public int Unlock_level { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Alamein_event module = new DB_Alamein_event()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Battle_type_id		 = reader.GetInt32(3),
					Event_battle_id		 = reader.GetInt32(4),
					Unlock_level		 = reader.GetInt32(5),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}
