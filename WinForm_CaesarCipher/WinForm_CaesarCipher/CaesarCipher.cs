using System;
using System.Text;

namespace WinForm_CaesarCipher
{
    public static class CaesarCipher
    {
        public static string Encrypt(string text, int key)
        {
            char[] temp = text.ToCharArray();
            int shiftKey = key % 26;

            for (int i = 0; i < temp.Length; i++)
            {
                if (!Char.IsLetter(temp[i]))
                {
                    temp[i] = temp[i];
                }
                else
                {
                    if (Char.IsUpper(temp[i]))
                    {
                        temp[i] = (char)(temp[i] + shiftKey);

                        if (temp[i] > 'Z')
                        {
                            temp[i] = (char)(temp[i] - 26);
                        }
                    }
                    else
                    {
                        temp[i] = (char)(temp[i] + shiftKey);

                        if (temp[i] > 'z')
                        {
                            temp[i] = (char)(temp[i] - 26);
                        }
                    }
                }
            }

            return CreateString(temp);
        }

        public static string Decrypt(string text, int key)
        {
            char[] temp = text.ToCharArray();
            int shiftKey = key % 26;

            for (int i = 0; i < temp.Length; i++)
            {
                if (!Char.IsLetter(temp[i]))
                {
                    temp[i] = temp[i];
                }
                else
                {
                    if (Char.IsUpper(temp[i]))
                    {
                        temp[i] = (char)(temp[i] - shiftKey);

                        if (temp[i] < 'A')
                        {
                            temp[i] = (char)(temp[i] + 26);
                        }
                    }
                    else
                    {
                        temp[i] = (char)(temp[i] - shiftKey);

                        if (temp[i] < 'a')
                        {
                            temp[i] = (char)(temp[i] + 26);
                        }
                    }
                }
            }

            return CreateString(temp);
        }

        private static string CreateString(char[] tempString)
        {
            var temp = new StringBuilder();

            foreach (var item in tempString)
            {
                temp.Append(item);
            }

            return temp.ToString();
        }
    }
}
