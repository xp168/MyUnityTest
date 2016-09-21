﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Tank_tactics : IDB_BaseInt
{
	const string SQL = @"select _index, id, target1, target2, target3, target4 from conf_tank_tactics";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///策略ID
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///攻击优先级1
	/// </summary>
	public int Target1 { get; set; }
	/// <summary>
	///攻击优先级2
	/// </summary>
	public int Target2 { get; set; }
	/// <summary>
	///攻击优先级3
	/// </summary>
	public int Target3 { get; set; }
	/// <summary>
	///攻击优先级4
	/// </summary>
	public int Target4 { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Tank_tactics module = new DB_Tank_tactics()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Target1		 = reader.GetInt32(2),
					Target2		 = reader.GetInt32(3),
					Target3		 = reader.GetInt32(4),
					Target4		 = reader.GetInt32(5),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}