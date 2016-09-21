﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Strategy : IDB_BaseInt
{
	const string SQL = @"select _index, strategy_id, comment, strategy_type, strategy_battle, strategy_icon, strategy_level, strategy_recommend, strategy_title, strategy_stay, strategy_skill, strategy_skill_limit, sp_skill_icon, str_strategy, str_level from conf_strategy";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///据点id（防线ID+据点编号）
	/// </summary>
	public int Strategy_id { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///据点类型：1=玩家初始据点；2=战斗据点；3=资源据点；4=核心要塞；5=敌军集结地
	/// </summary>
	public int Strategy_type { get; set; }
	/// <summary>
	///据点战斗，数据从conf_activities_battle_public取得
	/// </summary>
	public int Strategy_battle { get; set; }
	/// <summary>
	///据点图标
	/// </summary>
	public int Strategy_icon { get; set; }
	/// <summary>
	///推荐等级
	/// </summary>
	public string Strategy_level { get; set; }
	/// <summary>
	///推荐坦克
	/// </summary>
	public string Strategy_recommend { get; set; }
	/// <summary>
	///标题
	/// </summary>
	public string Strategy_title { get; set; }
	/// <summary>
	///据点位置
	/// </summary>
	public int Strategy_stay { get; set; }
	/// <summary>
	///敌方战区内使用技能(使用从表conf_skill_info_public.xlsx中查找id)
	/// </summary>
	public string Strategy_skill { get; set; }
	/// <summary>
	///禁用玩家技能(禁用从表conf_skill_info_public.xlsx中查找id)
	/// </summary>
	public string Strategy_skill_limit { get; set; }
	/// <summary>
	///战区技能icon显示（conconf_res_ui_sprite_client.xlsx中找id）
	/// </summary>
	public int Sp_skill_icon { get; set; }
	/// <summary>
	///被强化据点
	/// </summary>
	public string Str_strategy { get; set; }
	/// <summary>
	///强化强度
	/// </summary>
	public int Str_level { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Strategy module = new DB_Strategy()
				{
					_index		 = reader.GetInt32(0),
					Strategy_id		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Strategy_type		 = reader.GetInt32(3),
					Strategy_battle		 = reader.GetInt32(4),
					Strategy_icon		 = reader.GetInt32(5),
					Strategy_level		 = reader.GetString(6),
					Strategy_recommend		 = reader.GetString(7),
					Strategy_title		 = reader.GetString(8),
					Strategy_stay		 = reader.GetInt32(9),
					Strategy_skill		 = reader.GetString(10),
					Strategy_skill_limit		 = reader.GetString(11),
					Sp_skill_icon		 = reader.GetInt32(12),
					Str_strategy		 = reader.GetString(13),
					Str_level		 = reader.GetInt32(14),
				};
				tmp.Add(module.Strategy_id, module);
			}
		});
		return tmp;
	}
}
