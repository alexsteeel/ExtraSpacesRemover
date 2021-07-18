using System.Text;

namespace ExtraSpacesRemover
{
    /// <summary>
    /// Удаление лишних пробелов.
    /// </summary>
    public static class StringExtensions
    {
        public static string RemoveExtraSpaces(this string input)
        {
            if (input.Length == 0)
                return string.Empty;

            var sb = new StringBuilder(input);
            var removeCount = 0;
            var startIndex = 0;

            for (int i = 0; i < sb.Length; i++)
            {
                if (i + 1 < sb.Length
                    && sb[i] == '_'
                    && sb[i] == sb[i + 1])
                {
                    if (startIndex == 0)
                    {
                        startIndex = i + 1;
                    }

                    removeCount++;
                }
                else if (removeCount > 0)
                {
                    sb.Remove(startIndex, removeCount);
                    i -= removeCount;
                    removeCount = 0;
                    startIndex = 0;
                }
            }

            if (sb[0] == '_')
            {
                sb.Remove(0, 1);
            }

            if (sb.Length > 0 && sb[^1] == '_')
            {
                sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }
    }
}
