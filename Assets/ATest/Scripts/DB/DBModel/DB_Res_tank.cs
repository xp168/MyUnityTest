﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Res_tank : IDB_BaseInt
{
	const string SQL = @"select _index, id, name, comment, mesh_path, series, turret_type, underpan_type, normal_ui_sprite_id, click_ui_sprite_id, scale, slot1_intermediate_x, slot1_intermediate_y, slot1_end_x, slot1_end_y, slot2_intermediate_x, slot2_intermediate_y, slot2_end_x, slot2_end_y, slot3_intermediate_x, slot3_intermediate_y, slot3_end_x, slot3_end_y, slot4_intermediate_x, slot4_intermediate_y, slot4_end_x, slot4_end_y, slot5_intermediate_x, slot5_intermediate_y, slot5_end_x, slot5_end_y from conf_res_tank";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///模型ID
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///坦克名字
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	///描述
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///路径
	/// </summary>
	public string Mesh_path { get; set; }
	/// <summary>
	///战车表现
	/// </summary>
	public int Series { get; set; }
	/// <summary>
	///坦克炮塔类型
	/// </summary>
	public int Turret_type { get; set; }
	/// <summary>
	///坦克底盘类型
	/// </summary>
	public int Underpan_type { get; set; }
	/// <summary>
	///一般图标
	/// </summary>
	public int Normal_ui_sprite_id { get; set; }
	/// <summary>
	///图标点击
	/// </summary>
	public int Click_ui_sprite_id { get; set; }
	/// <summary>
	///缩放比例
	/// </summary>
	public float Scale { get; set; }
	/// <summary>
	///装备1中间点x
	/// </summary>
	public float Slot1_intermediate_x { get; set; }
	/// <summary>
	///装备1中间点y
	/// </summary>
	public float Slot1_intermediate_y { get; set; }
	/// <summary>
	///装备1终点x
	/// </summary>
	public float Slot1_end_x { get; set; }
	/// <summary>
	///装备1终点y
	/// </summary>
	public float Slot1_end_y { get; set; }
	/// <summary>
	///装备2中间点x
	/// </summary>
	public float Slot2_intermediate_x { get; set; }
	/// <summary>
	///装备2中间点y
	/// </summary>
	public float Slot2_intermediate_y { get; set; }
	/// <summary>
	///装备2终点x
	/// </summary>
	public float Slot2_end_x { get; set; }
	/// <summary>
	///装备2终点y
	/// </summary>
	public float Slot2_end_y { get; set; }
	/// <summary>
	///装备3中间点x
	/// </summary>
	public float Slot3_intermediate_x { get; set; }
	/// <summary>
	///装备3中间点y
	/// </summary>
	public float Slot3_intermediate_y { get; set; }
	/// <summary>
	///装备3终点x
	/// </summary>
	public float Slot3_end_x { get; set; }
	/// <summary>
	///装备3终点y
	/// </summary>
	public float Slot3_end_y { get; set; }
	/// <summary>
	///装备4中间点x
	/// </summary>
	public float Slot4_intermediate_x { get; set; }
	/// <summary>
	///装备4中间点y
	/// </summary>
	public float Slot4_intermediate_y { get; set; }
	/// <summary>
	///装备4终点x
	/// </summary>
	public float Slot4_end_x { get; set; }
	/// <summary>
	///装备4终点y
	/// </summary>
	public float Slot4_end_y { get; set; }
	/// <summary>
	///装备5中间点x
	/// </summary>
	public float Slot5_intermediate_x { get; set; }
	/// <summary>
	///装备5中间点y
	/// </summary>
	public float Slot5_intermediate_y { get; set; }
	/// <summary>
	///装备5终点x
	/// </summary>
	public float Slot5_end_x { get; set; }
	/// <summary>
	///装备5终点y
	/// </summary>
	public float Slot5_end_y { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Res_tank module = new DB_Res_tank()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Name		 = reader.GetString(2),
					Comment		 = reader.GetString(3),
					Mesh_path		 = reader.GetString(4),
					Series		 = reader.GetInt32(5),
					Turret_type		 = reader.GetInt32(6),
					Underpan_type		 = reader.GetInt32(7),
					Normal_ui_sprite_id		 = reader.GetInt32(8),
					Click_ui_sprite_id		 = reader.GetInt32(9),
					Scale		 = reader.GetFloat(10),
					Slot1_intermediate_x		 = reader.GetFloat(11),
					Slot1_intermediate_y		 = reader.GetFloat(12),
					Slot1_end_x		 = reader.GetFloat(13),
					Slot1_end_y		 = reader.GetFloat(14),
					Slot2_intermediate_x		 = reader.GetFloat(15),
					Slot2_intermediate_y		 = reader.GetFloat(16),
					Slot2_end_x		 = reader.GetFloat(17),
					Slot2_end_y		 = reader.GetFloat(18),
					Slot3_intermediate_x		 = reader.GetFloat(19),
					Slot3_intermediate_y		 = reader.GetFloat(20),
					Slot3_end_x		 = reader.GetFloat(21),
					Slot3_end_y		 = reader.GetFloat(22),
					Slot4_intermediate_x		 = reader.GetFloat(23),
					Slot4_intermediate_y		 = reader.GetFloat(24),
					Slot4_end_x		 = reader.GetFloat(25),
					Slot4_end_y		 = reader.GetFloat(26),
					Slot5_intermediate_x		 = reader.GetFloat(27),
					Slot5_intermediate_y		 = reader.GetFloat(28),
					Slot5_end_x		 = reader.GetFloat(29),
					Slot5_end_y		 = reader.GetFloat(30),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}
