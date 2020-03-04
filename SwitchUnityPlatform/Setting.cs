using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchUnityPlatform
{
	public class Setting
	{
		private static readonly string SETTING_PATH = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "SwitchUnityPlatform_Setting.json";

		private static Setting ms_Instance;

		public string WorkDirectory;

		public static Setting GetInstance()
		{
			if (ms_Instance == null)
			{
				try
				{
					ms_Instance = LitJson.JsonMapper.ToObject<Setting>(File.ReadAllText(SETTING_PATH));
				}
				catch (Exception)
				{
					ms_Instance = new Setting();
					new SettingForm().ShowDialog();
				}
			}
			return ms_Instance;
		}

		public void Save()
		{
			File.WriteAllText(SETTING_PATH, LitJson.JsonMapper.ToJson(ms_Instance));
		}
	}
}