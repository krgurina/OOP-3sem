using System;
using System.Collections.Generic;
using System.Text;

namespace oop8
{
    class StringEditor
    {
		/* (+) Использование лямбда-функций */

		// добавление символа в строку
		public static string AddSymbol(string str) => str += "====";

		// замена букв на верхний регистр
		public static string ToUpper(string str) => str.ToUpper();

		// замена букв на нижний регистр
		public static string ToLower(string str) => str.ToLower();

		// удаление пробелов
		public static string RemoveSpase(string str) => str.Replace(" ", string.Empty);

		//удаление знаков препинания
		public static string RemoveS(string str)                       
		{
			str = str.Replace(".", "");
			str = str.Replace(",", string.Empty);
			str = str.Replace(":", string.Empty);
			str = str.Replace(";", string.Empty);
			str = str.Replace("!", string.Empty);
			str = str.Replace("?", string.Empty);
			str = str.Replace("-", string.Empty);
			return str;
		}
	}
}
