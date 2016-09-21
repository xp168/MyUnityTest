﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Consume : IDB_BaseInt
{
	const string SQL = @"select _index, id, comment, total_cost, starting_cost, vic_cost, cost_prop_id1, cost_prop_num1, cost_prop_id2, cost_prop_num2, cost_prop_id3, cost_prop_num3 from conf_consume";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///消耗id
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///燃油总消耗
	/// </summary>
	public int Total_cost { get; set; }
	/// <summary>
	///燃油开战消耗
	/// </summary>
	public int Starting_cost { get; set; }
	/// <summary>
	///燃油胜利消耗
	/// </summary>
	public int Vic_cost { get; set; }
	/// <summary>
	///消耗道具1id
	/// </summary>
	public int Cost_prop_id1 { get; set; }
	/// <summary>
	///消耗道具1数量
	/// </summary>
	public int Cost_prop_num1 { get; set; }
	/// <summary>
	///消耗道具2id
	/// </summary>
	public int Cost_prop_id2 { get; set; }
	/// <summary>
	///消耗道具2数量
	/// </summary>
	public int Cost_prop_num2 { get; set; }
	/// <summary>
	///消耗道具3id
	/// </summary>
	public int Cost_prop_id3 { get; set; }
	/// <summary>
	///消耗道具3数量
	/// </summary>
	public int Cost_prop_num3 { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Consume module = new DB_Consume()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Total_cost		 = reader.GetInt32(3),
					Starting_cost		 = reader.GetInt32(4),
					Vic_cost		 = reader.GetInt32(5),
					Cost_prop_id1		 = reader.GetInt32(6),
					Cost_prop_num1		 = reader.GetInt32(7),
					Cost_prop_id2		 = reader.GetInt32(8),
					Cost_prop_num2		 = reader.GetInt32(9),
					Cost_prop_id3		 = reader.GetInt32(10),
					Cost_prop_num3		 = reader.GetInt32(11),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}