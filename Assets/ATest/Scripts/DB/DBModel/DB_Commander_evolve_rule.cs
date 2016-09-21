﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Commander_evolve_rule : IDB_BaseInt
{
	const string SQL = @"select _index, Commander_evolve_rule_id, Comment, Evolve_Commander_00, Evolve_Commander_01, Evolve_Commander_02, Evolve_Cost from conf_commander_evolve_rule";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///指挥官进阶规则id
	/// </summary>
	public int Commander_evolve_rule_id { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///进阶所需的指挥官1
	/// </summary>
	public int Evolve_Commander_00 { get; set; }
	/// <summary>
	///进阶所需指挥官2
	/// </summary>
	public int Evolve_Commander_01 { get; set; }
	/// <summary>
	///进阶所需指挥官3
	/// </summary>
	public int Evolve_Commander_02 { get; set; }
	/// <summary>
	///进阶所需金钱
	/// </summary>
	public int Evolve_Cost { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Commander_evolve_rule module = new DB_Commander_evolve_rule()
				{
					_index		 = reader.GetInt32(0),
					Commander_evolve_rule_id		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Evolve_Commander_00		 = reader.GetInt32(3),
					Evolve_Commander_01		 = reader.GetInt32(4),
					Evolve_Commander_02		 = reader.GetInt32(5),
					Evolve_Cost		 = reader.GetInt32(6),
				};
				tmp.Add(module.Commander_evolve_rule_id, module);
			}
		});
		return tmp;
	}
}
