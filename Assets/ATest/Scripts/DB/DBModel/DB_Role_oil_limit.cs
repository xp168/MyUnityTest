﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Role_oil_limit : IDB_BaseInt
{
	const string SQL = @"select _index, role_level, comment, next_level, exp, oil_refilled, oil_limit, unlock from conf_role_oil_limit";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///玩家等级
	/// </summary>
	public int Role_level { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///下一等级
	/// </summary>
	public int Next_level { get; set; }
	/// <summary>
	///升级所需经验
	/// </summary>
	public int Exp { get; set; }
	/// <summary>
	///升级回复燃油
	/// </summary>
	public int Oil_refilled { get; set; }
	/// <summary>
	///油料上限
	/// </summary>
	public int Oil_limit { get; set; }
	/// <summary>
	///活动解锁
	/// </summary>
	public string Unlock { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Role_oil_limit module = new DB_Role_oil_limit()
				{
					_index		 = reader.GetInt32(0),
					Role_level		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Next_level		 = reader.GetInt32(3),
					Exp		 = reader.GetInt32(4),
					Oil_refilled		 = reader.GetInt32(5),
					Oil_limit		 = reader.GetInt32(6),
					Unlock		 = reader.GetString(7),
				};
				tmp.Add(module.Role_level, module);
			}
		});
		return tmp;
	}
}
