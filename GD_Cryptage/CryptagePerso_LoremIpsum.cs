using System;
using System.Collections.Generic;
using System.Text;

namespace GD_Cryptage
{
    class CryptagePerso_LoremIpsum
    {
        private string input;
        private int key;
        private string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi et dui ac lectus hendrerit facilisis sit amet vel enim. Integer eleifend nisi nec felis malesuada, nec pharetra lacus sagittis. Nullam tincidunt arcu vitae tortor rutrum, a consequat erat fringilla. Pellentesque venenatis eu eros ac sollicitudin. Quisque auctor venenatis ante, at suscipit turpis tempor quis. Cras vitae dolor hendrerit, aliquet arcu.";

        public CryptagePerso_LoremIpsum(string input, int key)
        {
            this.input = input;
            this.key = key;
        }
        // cryptage perso qui ajoute un nombre n a chaque caractere d'une chaine de caractere et qui ka retourne.
        public string CryptText()
        {

                input = input + lorem;
                char[] chars = input.ToCharArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] += (char)key;
                }

                return new string(chars);


        }
        // decryptage qui enleve le nombre n.
        public string DecryptText()
        {

                char[] chars = input.ToCharArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] -= (char)key;
                }

                string output = new string(chars);
                // 414 char a enlever
                output = output.Replace(lorem, "");
                return output;


        }



    }
}
