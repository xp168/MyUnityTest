﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Glory_intro : IDB_BaseInt
{
	const string SQL = @"select _index, id, comment, name, introduction, type_name, description from conf_glory_intro";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///ID
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///关卡名称
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	///关卡描述
	/// </summary>
	public string Introduction { get; set; }
	/// <summary>
	///关卡类型名称
	/// </summary>
	public string Type_name { get; set; }
	/// <summary>
	///战役目标
	/// </summary>
	public string Description { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Glory_intro module = new DB_Glory_intro()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Name		 = reader.GetString(3),
					Introduction		 = reader.GetString(4),
					Type_name		 = reader.GetString(5),
					Description		 = reader.GetString(6),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}
