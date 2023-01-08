namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
			string stringCount = count.ToString();

			if (stringCount[stringCount.Length - 1] == '1')
			{
				if (stringCount.Length > 1 && stringCount[stringCount.Length - 2] != '1' || stringCount.Length < 2)
				{
					return "рубль";
				}
			}

			if ((stringCount[stringCount.Length - 1] == '2' || stringCount[stringCount.Length - 1] == '3' 
				|| stringCount[stringCount.Length - 1] == '4') && (stringCount.Length > 1 
				&& stringCount[stringCount.Length - 2] != '1' || stringCount.Length < 2))
			{
				return "рубля";
			}
			else
			{
				return "рублей";
			}
		}
	}
}