﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Skill_info : IDB_BaseIntDouble
{
	const string SQL = @"select _index, id, skill_level, skill_level_max, solt, name, comment, description, icon, release, type, subskill, condition_logic, condition, cd_time, logic, logic_param, logic_param2, skill_show, effect1, effect2, effect3, son_skill1, son_skill1_level, son_skill1_condition_logic, son_skill1_condition, son_skill1_time, son_skill2, son_skill2_level, son_skill2_condition_logic, son_skill2_condition, son_skill2_time, target_buff1, target_buff1_level, target_buff2, target_buff2_level, effect4, skill_aoe_range, skill_target_select_logic, target_type, target_number, skill_target_select_limit, skill_target_select_nParam, skill_target_select_fParam from conf_skill_info";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///技能ID
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///技能等级
	/// </summary>
	public int Skill_level { get; set; }
	/// <summary>
	///技能最大等级
	/// </summary>
	public int Skill_level_max { get; set; }
	/// <summary>
	///技能槽位
	/// </summary>
	public int Solt { get; set; }
	/// <summary>
	///技能名称
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	///技能备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///技能描述
	/// </summary>
	public string Description { get; set; }
	/// <summary>
	///技能图标
	/// </summary>
	public int Icon { get; set; }
	/// <summary>
	///释放主体：1=指挥官，2=tank
	/// </summary>
	public int Release { get; set; }
	/// <summary>
	///技能类型，1=主动释放技能，2=自动释放技能，4=属性技能
	/// </summary>
	public int Type { get; set; }
	/// <summary>
	///是否子技能：0=否，1-是
	/// </summary>
	public int Subskill { get; set; }
	/// <summary>
	///施放条件逻辑
	/// </summary>
	public int Condition_logic { get; set; }
	/// <summary>
	///施放条件
	/// </summary>
	public float Condition { get; set; }
	/// <summary>
	///冷却时间
	/// </summary>
	public float Cd_time { get; set; }
	/// <summary>
	///技能逻辑
	/// </summary>
	public int Logic { get; set; }
	/// <summary>
	///技能逻辑参数
	/// </summary>
	public int Logic_param { get; set; }
	/// <summary>
	///技能逻辑参数2
	/// </summary>
	public float Logic_param2 { get; set; }
	/// <summary>
	///技能指示特效
	/// </summary>
	public int Skill_show { get; set; }
	/// <summary>
	///技能特效1
	/// </summary>
	public int Effect1 { get; set; }
	/// <summary>
	///技能特效2
	/// </summary>
	public int Effect2 { get; set; }
	/// <summary>
	///技能特效3
	/// </summary>
	public int Effect3 { get; set; }
	/// <summary>
	///子技能1
	/// </summary>
	public int Son_skill1 { get; set; }
	/// <summary>
	///子技能1等级
	/// </summary>
	public int Son_skill1_level { get; set; }
	/// <summary>
	///子技能1触发条件逻辑
	/// </summary>
	public int Son_skill1_condition_logic { get; set; }
	/// <summary>
	///子技能1触发条件
	/// </summary>
	public float Son_skill1_condition { get; set; }
	/// <summary>
	///子技能1触发时间
	/// </summary>
	public float Son_skill1_time { get; set; }
	/// <summary>
	///子技能2
	/// </summary>
	public int Son_skill2 { get; set; }
	/// <summary>
	///子技能2等级
	/// </summary>
	public int Son_skill2_level { get; set; }
	/// <summary>
	///子技能2触发条件逻辑
	/// </summary>
	public int Son_skill2_condition_logic { get; set; }
	/// <summary>
	///子技能2触发条件
	/// </summary>
	public float Son_skill2_condition { get; set; }
	/// <summary>
	///子技能2触发时间
	/// </summary>
	public float Son_skill2_time { get; set; }
	/// <summary>
	///buff1ID
	/// </summary>
	public int Target_buff1 { get; set; }
	/// <summary>
	///buff1等级
	/// </summary>
	public int Target_buff1_level { get; set; }
	/// <summary>
	///buff2ID
	/// </summary>
	public int Target_buff2 { get; set; }
	/// <summary>
	///buff2等级
	/// </summary>
	public int Target_buff2_level { get; set; }
	/// <summary>
	///技能指示特效
	/// </summary>
	public int Effect4 { get; set; }
	/// <summary>
	///范围
	/// </summary>
	public int Skill_aoe_range { get; set; }
	/// <summary>
	///目标选择逻辑
	/// </summary>
	public int Skill_target_select_logic { get; set; }
	/// <summary>
	///目标类型
	/// </summary>
	public int Target_type { get; set; }
	/// <summary>
	///目标数量
	/// </summary>
	public int Target_number { get; set; }
	/// <summary>
	///目标选择极值
	/// </summary>
	public int Skill_target_select_limit { get; set; }
	/// <summary>
	///目标选择整形参数
	/// </summary>
	public string Skill_target_select_nParam { get; set; }
	/// <summary>
	///目标选择浮点参数
	/// </summary>
	public string Skill_target_select_fParam { get; set; }

	static Dictionary<int, Dictionary<int, IDB_BaseIntDouble>> LoadDB()
	{
		Dictionary<int, Dictionary<int, IDB_BaseIntDouble>> tmp = new Dictionary<int, Dictionary<int, IDB_BaseIntDouble>>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Skill_info module = new DB_Skill_info()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Skill_level		 = reader.GetInt32(2),
					Skill_level_max		 = reader.GetInt32(3),
					Solt		 = reader.GetInt32(4),
					Name		 = reader.GetString(5),
					Comment		 = reader.GetString(6),
					Description		 = reader.GetString(7),
					Icon		 = reader.GetInt32(8),
					Release		 = reader.GetInt32(9),
					Type		 = reader.GetInt32(10),
					Subskill		 = reader.GetInt32(11),
					Condition_logic		 = reader.GetInt32(12),
					Condition		 = reader.GetFloat(13),
					Cd_time		 = reader.GetFloat(14),
					Logic		 = reader.GetInt32(15),
					Logic_param		 = reader.GetInt32(16),
					Logic_param2		 = reader.GetFloat(17),
					Skill_show		 = reader.GetInt32(18),
					Effect1		 = reader.GetInt32(19),
					Effect2		 = reader.GetInt32(20),
					Effect3		 = reader.GetInt32(21),
					Son_skill1		 = reader.GetInt32(22),
					Son_skill1_level		 = reader.GetInt32(23),
					Son_skill1_condition_logic		 = reader.GetInt32(24),
					Son_skill1_condition		 = reader.GetFloat(25),
					Son_skill1_time		 = reader.GetFloat(26),
					Son_skill2		 = reader.GetInt32(27),
					Son_skill2_level		 = reader.GetInt32(28),
					Son_skill2_condition_logic		 = reader.GetInt32(29),
					Son_skill2_condition		 = reader.GetFloat(30),
					Son_skill2_time		 = reader.GetFloat(31),
					Target_buff1		 = reader.GetInt32(32),
					Target_buff1_level		 = reader.GetInt32(33),
					Target_buff2		 = reader.GetInt32(34),
					Target_buff2_level		 = reader.GetInt32(35),
					Effect4		 = reader.GetInt32(36),
					Skill_aoe_range		 = reader.GetInt32(37),
					Skill_target_select_logic		 = reader.GetInt32(38),
					Target_type		 = reader.GetInt32(39),
					Target_number		 = reader.GetInt32(40),
					Skill_target_select_limit		 = reader.GetInt32(41),
					Skill_target_select_nParam		 = reader.GetString(42),
					Skill_target_select_fParam		 = reader.GetString(43),
				};
				if (!tmp.ContainsKey(module.Id))
				{
					var tmpsub = new Dictionary<int, IDB_BaseIntDouble>();
					tmp.Add(module.Id, tmpsub);
				}
				tmp[module.Id].Add(module.Skill_level, module);
			}
		});
		return tmp;
	}
}
