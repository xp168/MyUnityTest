﻿using System.Collections.Generic; 

/// <summary>
/// THIS SOURCE CODE WAS AUTO-GENERATED BY TOOL, DO NOT MODIFY IT!
/// </summary>
public class DB_Newbie_task : IDB_BaseInt
{
	const string SQL = @"select _index, id, comment, adjutant_anim_type, audio_path, task_type, class_name, guide_content, arrow_direction_type, talk_title_content, talk_content, condition, show_type, open_mask_type, close_mask_type, param1, param2, paramEx1, paramEx2 from conf_newbie_task";

	/// <summary>
	///序号
	/// </summary>
	public int _index { get; set; }
	/// <summary>
	///task id
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	///开发备注
	/// </summary>
	public string Comment { get; set; }
	/// <summary>
	///女副官动画播放类型
	/// </summary>
	public int Adjutant_anim_type { get; set; }
	/// <summary>
	///节点语音资源路径
	/// </summary>
	public string Audio_path { get; set; }
	/// <summary>
	///task类型
	/// </summary>
	public int Task_type { get; set; }
	/// <summary>
	///ClassName
	/// </summary>
	public string Class_name { get; set; }
	/// <summary>
	///引导文本
	/// </summary>
	public string Guide_content { get; set; }
	/// <summary>
	///指示方向
	/// </summary>
	public int Arrow_direction_type { get; set; }
	/// <summary>
	///剧情抬头
	/// </summary>
	public string Talk_title_content { get; set; }
	/// <summary>
	///剧情内容
	/// </summary>
	public string Talk_content { get; set; }
	/// <summary>
	///条件
	/// </summary>
	public string Condition { get; set; }
	/// <summary>
	///显示类型
	/// </summary>
	public int Show_type { get; set; }
	/// <summary>
	///打开时遮罩类型
	/// </summary>
	public int Open_mask_type { get; set; }
	/// <summary>
	///关闭时遮罩类型
	/// </summary>
	public int Close_mask_type { get; set; }
	/// <summary>
	///参数1
	/// </summary>
	public int Param1 { get; set; }
	/// <summary>
	///参数2
	/// </summary>
	public float Param2 { get; set; }
	/// <summary>
	///扩展参数1
	/// </summary>
	public int ParamEx1 { get; set; }
	/// <summary>
	///扩展参数2
	/// </summary>
	public float ParamEx2 { get; set; }

	static Dictionary<int, IDB_BaseInt> LoadDB()
	{
		Dictionary<int, IDB_BaseInt> tmp = new Dictionary<int, IDB_BaseInt>();
		DBHelper.Instance.Query(SQL, (reader) =>
		{
			if (reader == null) return;

			while (reader.Read())
			{
				DB_Newbie_task module = new DB_Newbie_task()
				{
					_index		 = reader.GetInt32(0),
					Id		 = reader.GetInt32(1),
					Comment		 = reader.GetString(2),
					Adjutant_anim_type		 = reader.GetInt32(3),
					Audio_path		 = reader.GetString(4),
					Task_type		 = reader.GetInt32(5),
					Class_name		 = reader.GetString(6),
					Guide_content		 = reader.GetString(7),
					Arrow_direction_type		 = reader.GetInt32(8),
					Talk_title_content		 = reader.GetString(9),
					Talk_content		 = reader.GetString(10),
					Condition		 = reader.GetString(11),
					Show_type		 = reader.GetInt32(12),
					Open_mask_type		 = reader.GetInt32(13),
					Close_mask_type		 = reader.GetInt32(14),
					Param1		 = reader.GetInt32(15),
					Param2		 = reader.GetFloat(16),
					ParamEx1		 = reader.GetInt32(17),
					ParamEx2		 = reader.GetFloat(18),
				};
				tmp.Add(module.Id, module);
			}
		});
		return tmp;
	}
}
