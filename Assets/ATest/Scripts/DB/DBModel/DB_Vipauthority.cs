﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Vipauthority : IDB_BaseInt
{
	const string SQL = @"select _index, viplevel, comment, buytype1num, buytype2num, buytype3num, buytype4num, buytype5num, buytype6num, buytype7num, buytype8num, buytype9num, buytype10num from conf_vipauthority";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///vip等级
	/// </summary>
	public int Viplevel { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///vipbuytype1次数
	/// </summary>
	public int Buytype1num { get; set; }
	/// <summary>
	///vipbuytype2次数
	/// </summary>
	public int Buytype2num { get; set; }
	/// <summary>
	///vipbuytype3次数
	/// </summary>
	public int Buytype3num { get; set; }
	/// <summary>
	///vipbuytype4次数
	/// </summary>
	public int Buytype4num { get; set; }
	/// <summary>
	///vipbuytype5次数
	/// </summary>
	public int Buytype5num { get; set; }
	/// <summary>
	///vipbuytype6次数
	/// </summary>
	public int Buytype6num { get; set; }
	/// <summary>
	///vipbuytype7次数
	/// </summary>
	public int Buytype7num { get; set; }
	/// <summary>
	///vipbuytype8次数
	/// </summary>
	public int Buytype8num { get; set; }
	/// <summary>
	///vipbuytype9次数
	/// </summary>
	public int Buytype9num { get; set; }
	/// <summary>
	///vipbuytype10次数
	/// </summary>
	public int Buytype10num { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Vipauthority module = new DB_Vipauthority()
				{
					_index		 = reader.GetInt32(0),
					Viplevel		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Buytype1num		 = reader.GetInt32(3),
					Buytype2num		 = reader.GetInt32(4),
					Buytype3num		 = reader.GetInt32(5),
					Buytype4num		 = reader.GetInt32(6),
					Buytype5num		 = reader.GetInt32(7),
					Buytype6num		 = reader.GetInt32(8),
					Buytype7num		 = reader.GetInt32(9),
					Buytype8num		 = reader.GetInt32(10),
					Buytype9num		 = reader.GetInt32(11),
					Buytype10num		 = reader.GetInt32(12),
				};
				tmp.Add(module.Viplevel, module);
			}
		});
		return tmp;
	}
}