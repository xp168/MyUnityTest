﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Equip_rareup_rule : IDB_BaseInt
{
	const string SQL = @"select _index, rareup_id, comment, money_cost, material1_id, material1_cost, material2_id, material2_cost, material3_id, material3_cost, prop1_id, prop1_cost, prop2_id, prop2_cost, prop3_id, prop3_cost from conf_equip_rareup_rule";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///装备规则id
	/// </summary>
	public int Rareup_id { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///金钱消耗
	/// </summary>
	public int Money_cost { get; set; }
	/// <summary>
	///消耗材料1ID
	/// </summary>
	public int Material1_id { get; set; }
	/// <summary>
	///消耗材料1数量
	/// </summary>
	public int Material1_cost { get; set; }
	/// <summary>
	///消耗材料2ID
	/// </summary>
	public int Material2_id { get; set; }
	/// <summary>
	///消耗材料2数量
	/// </summary>
	public int Material2_cost { get; set; }
	/// <summary>
	///消耗材料3ID
	/// </summary>
	public int Material3_id { get; set; }
	/// <summary>
	///消耗材料3数量
	/// </summary>
	public int Material3_cost { get; set; }
	/// <summary>
	///道具1ID
	/// </summary>
	public int Prop1_id { get; set; }
	/// <summary>
	///消耗道具1数量
	/// </summary>
	public int Prop1_cost { get; set; }
	/// <summary>
	///消耗道具2ID
	/// </summary>
	public int Prop2_id { get; set; }
	/// <summary>
	///消耗道具2数量
	/// </summary>
	public int Prop2_cost { get; set; }
	/// <summary>
	///消耗道具3ID
	/// </summary>
	public int Prop3_id { get; set; }
	/// <summary>
	///消耗道具3数量
	/// </summary>
	public int Prop3_cost { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Equip_rareup_rule module = new DB_Equip_rareup_rule()
				{
					_index		 = reader.GetInt32(0),
					Rareup_id		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Money_cost		 = reader.GetInt32(3),
					Material1_id		 = reader.GetInt32(4),
					Material1_cost		 = reader.GetInt32(5),
					Material2_id		 = reader.GetInt32(6),
					Material2_cost		 = reader.GetInt32(7),
					Material3_id		 = reader.GetInt32(8),
					Material3_cost		 = reader.GetInt32(9),
					Prop1_id		 = reader.GetInt32(10),
					Prop1_cost		 = reader.GetInt32(11),
					Prop2_id		 = reader.GetInt32(12),
					Prop2_cost		 = reader.GetInt32(13),
					Prop3_id		 = reader.GetInt32(14),
					Prop3_cost		 = reader.GetInt32(15),
				};
				tmp.Add(module.Rareup_id, module);
			}
		});
		return tmp;
	}
}
