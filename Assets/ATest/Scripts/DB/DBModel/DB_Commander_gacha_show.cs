﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Commander_gacha_show : IDB_BaseInt
{
	const string SQL = @"select _index, id, comment, cost, costnum, cdtime, dailytimes, getnum, propshowtype, propshow, mainproptype, mainpropid, gacha_group from conf_commander_gacha_show";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///抽卡id
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///消费货币
	/// </summary>
	public int Cost { get; set; }
	/// <summary>
	///消费数量
	/// </summary>
	public int Costnum { get; set; }
	/// <summary>
	///冷却时间单位秒
	/// </summary>
	public int Cdtime { get; set; }
	/// <summary>
	///每日最大次数
	/// </summary>
	public int Dailytimes { get; set; }
	/// <summary>
	///获得数量
	/// </summary>
	public int Getnum { get; set; }
	/// <summary>
	///展示类型
	/// </summary>
	public int Propshowtype { get; set; }
	/// <summary>
	///获得展示
	/// </summary>
	public string Propshow { get; set; }
	/// <summary>
	///主打商品类型
	/// </summary>
	public int Mainproptype { get; set; }
	/// <summary>
	///主打商品id
	/// </summary>
	public int Mainpropid { get; set; }
	/// <summary>
	///分组
	/// </summary>
	public int Gacha_group { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Commander_gacha_show module = new DB_Commander_gacha_show()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Cost		 = reader.GetInt32(3),
					Costnum		 = reader.GetInt32(4),
					Cdtime		 = reader.GetInt32(5),
					Dailytimes		 = reader.GetInt32(6),
					Getnum		 = reader.GetInt32(7),
					Propshowtype		 = reader.GetInt32(8),
					Propshow		 = reader.GetString(9),
					Mainproptype		 = reader.GetInt32(10),
					Mainpropid		 = reader.GetInt32(11),
					Gacha_group		 = reader.GetInt32(12),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}
