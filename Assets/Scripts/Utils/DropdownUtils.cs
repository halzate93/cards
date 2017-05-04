using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Utils
{
	public static class DropdownUtils
	{
		public static void SetOptions <T> (this Dropdown dropdown) where T : struct
		{
			if (!typeof (T).IsEnum) throw new Exception ("Not an enum!");
			string[] names = Enum.GetNames (typeof (T));
			dropdown.ClearOptions ();
			Dropdown.OptionData[] options = Array.ConvertAll (names, BuildOptionData);
			List<Dropdown.OptionData> optionsList = new List<Dropdown.OptionData> (options);
			dropdown.AddOptions (optionsList);
		}

		private static Dropdown.OptionData BuildOptionData (string name)
		{
			return new Dropdown.OptionData (name);
		}

		public static T GetValue<T> (this Dropdown dropdown) where T : struct
		{
			int index = dropdown.value;
			string selected = dropdown.options[index].text;
			return (T)Enum.Parse(typeof(T), selected);
		}
	}
}