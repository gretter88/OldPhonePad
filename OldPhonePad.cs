using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePadApp
{
    public static class OldPhonePad
    {
        private static readonly Dictionary<char, string> keypad = new Dictionary<char, string>
        {
            { '1', "" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };

        public static string Convert(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || !input.EndsWith("#"))
                return "";

            var sb = new StringBuilder();
            var currentSequence = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '#')
                {
                    AppendCharacter(sb, currentSequence.ToString());
                    break;
                }
                else if (ch == '*')
                {
                    if (sb.Length > 0)
                        sb.Remove(sb.Length - 1, 1);
                    currentSequence.Clear();
                }
                else if (ch == ' ')
                {
                    AppendCharacter(sb, currentSequence.ToString());
                    currentSequence.Clear();
                }
                else if (char.IsDigit(ch))
                {
                    if (currentSequence.Length > 0 && currentSequence[0] != ch)
                    {
                        AppendCharacter(sb, currentSequence.ToString());
                        currentSequence.Clear();
                    }
                    currentSequence.Append(ch);
                }
            }

            return sb.ToString();
        }

        private static void AppendCharacter(StringBuilder sb, string sequence)
        {
            if (string.IsNullOrEmpty(sequence)) return;

            char key = sequence[0];
            int count = sequence.Length;

            if (keypad.ContainsKey(key) && keypad[key].Length > 0)
            {
                var letters = keypad[key];
                int index = (count - 1) % letters.Length;
                sb.Append(letters[index]);
            }
            else if (key == '0')
            {
                sb.Append(" ");
            }
        }
    }
}