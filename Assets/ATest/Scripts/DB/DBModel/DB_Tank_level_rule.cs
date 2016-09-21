﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Tank_level_rule : IDB_BaseInt
{
	const string SQL = @"select _index, tank_level, exp_need, money_need, gold_need, prop1_id, prop2_id, prop3_id, prop4_id, prop5_id, prop6_id from conf_tank_level_rule";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///坦克等级
	/// </summary>
	public int Tank_level { get; set; }
	/// <summary>
	///升级所需经验
	/// </summary>
	public int Exp_need { get; set; }
	/// <summary>
	///升级所需游戏币
	/// </summary>
	public int Money_need { get; set; }
	/// <summary>
	///升级所需金币
	/// </summary>
	public int Gold_need { get; set; }
	/// <summary>
	///强化道具1ID
	/// </summary>
	public int Prop1_id { get; set; }
	/// <summary>
	///强化道具2ID
	/// </summary>
	public int Prop2_id { get; set; }
	/// <summary>
	///强化道具3ID
	/// </summary>
	public int Prop3_id { get; set; }
	/// <summary>
	///强化道具4ID
	/// </summary>
	public int Prop4_id { get; set; }
	/// <summary>
	///强化道具5ID
	/// </summary>
	public int Prop5_id { get; set; }
	/// <summary>
	///强化道具6ID
	/// </summary>
	public int Prop6_id { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Tank_level_rule module = new DB_Tank_level_rule()
				{
					_index		 = reader.GetInt32(0),
					Tank_level		 = reader.GetInt32(1),
					Exp_need		 = reader.GetInt32(2),
					Money_need		 = reader.GetInt32(3),
					Gold_need		 = reader.GetInt32(4),
					Prop1_id		 = reader.GetInt32(5),
					Prop2_id		 = reader.GetInt32(6),
					Prop3_id		 = reader.GetInt32(7),
					Prop4_id		 = reader.GetInt32(8),
					Prop5_id		 = reader.GetInt32(9),
					Prop6_id		 = reader.GetInt32(10),
				};
				tmp.Add(module.Tank_level, module);
			}
		});
		return tmp;
	}
}
