﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Npc_tank : IDB_BaseInt
{
	const string SQL = @"select _index, id, comment, name, description, tank_level, series, country, rare, recog_type, target_type, be_attacked_order, be_attacked_weight, size, health, explosion_attack, pierce_attack, burning_attack, explosion_guard, pierce_guard, burning_guard, hit, volt, bang, bang_guard, puncture, parry, res_tank_id, texture, icon, effects_group, drop1_id, drop2_id, drop3_id, drop4_id, drop5_id, drop6_id, drop7_id, drop8_id, drop9_id, drop10_id, target_logic, fire_dist, stop_dist, skill_queue, skill0, skill1, skill2, skill3, skill4, skill5, skill6 from conf_npc_tank";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///敌军ID
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///名字
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	///战车描述
	/// </summary>
	public string Description { get; set; }
	/// <summary>
	///级别
	/// </summary>
	public int Tank_level { get; set; }
	/// <summary>
	///战车表现
	/// </summary>
	public int Series { get; set; }
	/// <summary>
	///国籍
	/// </summary>
	public int Country { get; set; }
	/// <summary>
	///品质
	/// </summary>
	public int Rare { get; set; }
	/// <summary>
	///1=普通 2=精英 3=boss
	/// </summary>
	public int Recog_type { get; set; }
	/// <summary>
	///是否固定顺序 1=是 0=否,-1非目标
	/// </summary>
	public int Target_type { get; set; }
	/// <summary>
	///固定顺序
	/// </summary>
	public int Be_attacked_order { get; set; }
	/// <summary>
	///被击权重
	/// </summary>
	public int Be_attacked_weight { get; set; }
	/// <summary>
	///大小
	/// </summary>
	public int Size { get; set; }
	/// <summary>
	///生命
	/// </summary>
	public float Health { get; set; }
	/// <summary>
	///爆炸伤害
	/// </summary>
	public float Explosion_attack { get; set; }
	/// <summary>
	///穿透伤害
	/// </summary>
	public float Pierce_attack { get; set; }
	/// <summary>
	///燃烧伤害
	/// </summary>
	public float Burning_attack { get; set; }
	/// <summary>
	///爆炸防御力
	/// </summary>
	public float Explosion_guard { get; set; }
	/// <summary>
	///穿透防御力
	/// </summary>
	public float Pierce_guard { get; set; }
	/// <summary>
	///燃烧防御力
	/// </summary>
	public float Burning_guard { get; set; }
	/// <summary>
	///命中
	/// </summary>
	public float Hit { get; set; }
	/// <summary>
	///闪避
	/// </summary>
	public float Volt { get; set; }
	/// <summary>
	///暴击
	/// </summary>
	public float Bang { get; set; }
	/// <summary>
	///暴防
	/// </summary>
	public float Bang_guard { get; set; }
	/// <summary>
	///穿深
	/// </summary>
	public float Puncture { get; set; }
	/// <summary>
	///装甲
	/// </summary>
	public float Parry { get; set; }
	/// <summary>
	///模型
	/// </summary>
	public int Res_tank_id { get; set; }
	/// <summary>
	///贴图
	/// </summary>
	public int Texture { get; set; }
	/// <summary>
	///图标
	/// </summary>
	public int Icon { get; set; }
	/// <summary>
	///特效组
	/// </summary>
	public int Effects_group { get; set; }
	/// <summary>
	///掉落包1ID
	/// </summary>
	public int Drop1_id { get; set; }
	/// <summary>
	///掉落包2ID
	/// </summary>
	public int Drop2_id { get; set; }
	/// <summary>
	///掉落包3ID
	/// </summary>
	public int Drop3_id { get; set; }
	/// <summary>
	///掉落包4ID
	/// </summary>
	public int Drop4_id { get; set; }
	/// <summary>
	///掉落包5ID
	/// </summary>
	public int Drop5_id { get; set; }
	/// <summary>
	///掉落包6ID
	/// </summary>
	public int Drop6_id { get; set; }
	/// <summary>
	///掉落包7ID
	/// </summary>
	public int Drop7_id { get; set; }
	/// <summary>
	///掉落包8ID
	/// </summary>
	public int Drop8_id { get; set; }
	/// <summary>
	///掉落包9ID
	/// </summary>
	public int Drop9_id { get; set; }
	/// <summary>
	///掉落包10ID
	/// </summary>
	public int Drop10_id { get; set; }
	/// <summary>
	///目标选择逻辑
	/// </summary>
	public int Target_logic { get; set; }
	/// <summary>
	///开火距离
	/// </summary>
	public int Fire_dist { get; set; }
	/// <summary>
	///停止距离
	/// </summary>
	public int Stop_dist { get; set; }
	/// <summary>
	///技能队列
	/// </summary>
	public int Skill_queue { get; set; }
	/// <summary>
	///坦克普攻
	/// </summary>
	public int Skill0 { get; set; }
	/// <summary>
	///车体技能id
	/// </summary>
	public int Skill1 { get; set; }
	/// <summary>
	///火炮技能id
	/// </summary>
	public int Skill2 { get; set; }
	/// <summary>
	///炮塔技能id
	/// </summary>
	public int Skill3 { get; set; }
	/// <summary>
	///引擎技能id
	/// </summary>
	public int Skill4 { get; set; }
	/// <summary>
	///底盘技能id
	/// </summary>
	public int Skill5 { get; set; }
	/// <summary>
	///火控技能id
	/// </summary>
	public int Skill6 { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Npc_tank module = new DB_Npc_tank()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Name		 = reader.GetString(3),
					Description		 = reader.GetString(4),
					Tank_level		 = reader.GetInt32(5),
					Series		 = reader.GetInt32(6),
					Country		 = reader.GetInt32(7),
					Rare		 = reader.GetInt32(8),
					Recog_type		 = reader.GetInt32(9),
					Target_type		 = reader.GetInt32(10),
					Be_attacked_order		 = reader.GetInt32(11),
					Be_attacked_weight		 = reader.GetInt32(12),
					Size		 = reader.GetInt32(13),
					Health		 = reader.GetFloat(14),
					Explosion_attack		 = reader.GetFloat(15),
					Pierce_attack		 = reader.GetFloat(16),
					Burning_attack		 = reader.GetFloat(17),
					Explosion_guard		 = reader.GetFloat(18),
					Pierce_guard		 = reader.GetFloat(19),
					Burning_guard		 = reader.GetFloat(20),
					Hit		 = reader.GetFloat(21),
					Volt		 = reader.GetFloat(22),
					Bang		 = reader.GetFloat(23),
					Bang_guard		 = reader.GetFloat(24),
					Puncture		 = reader.GetFloat(25),
					Parry		 = reader.GetFloat(26),
					Res_tank_id		 = reader.GetInt32(27),
					Texture		 = reader.GetInt32(28),
					Icon		 = reader.GetInt32(29),
					Effects_group		 = reader.GetInt32(30),
					Drop1_id		 = reader.GetInt32(31),
					Drop2_id		 = reader.GetInt32(32),
					Drop3_id		 = reader.GetInt32(33),
					Drop4_id		 = reader.GetInt32(34),
					Drop5_id		 = reader.GetInt32(35),
					Drop6_id		 = reader.GetInt32(36),
					Drop7_id		 = reader.GetInt32(37),
					Drop8_id		 = reader.GetInt32(38),
					Drop9_id		 = reader.GetInt32(39),
					Drop10_id		 = reader.GetInt32(40),
					Target_logic		 = reader.GetInt32(41),
					Fire_dist		 = reader.GetInt32(42),
					Stop_dist		 = reader.GetInt32(43),
					Skill_queue		 = reader.GetInt32(44),
					Skill0		 = reader.GetInt32(45),
					Skill1		 = reader.GetInt32(46),
					Skill2		 = reader.GetInt32(47),
					Skill3		 = reader.GetInt32(48),
					Skill4		 = reader.GetInt32(49),
					Skill5		 = reader.GetInt32(50),
					Skill6		 = reader.GetInt32(51),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}