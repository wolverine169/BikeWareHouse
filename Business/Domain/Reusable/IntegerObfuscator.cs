using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWareHouse.Domain
{
    public class IntegerObfuscator
        {

            private int obfuscationValueForXOR;

            public IntegerObfuscator(int obfuscationValueForXOR)
            {
                this.obfuscationValueForXOR = obfuscationValueForXOR;
            }

            private static string getZeroPaddedString(string s, int length)
            {
                int count = length - s.Length;
                char[] chars = new char[count];
                for (int i = 0; i < count; i++)
                {
                    chars[i] = '0';
                }
                string result = new string(chars);
                result += s;
                return result;
            }

            public virtual int getObfuscated(int value)
            {

                string valueAsBitString = Convert.ToString(value, 2);
                StringBuilder sb = new StringBuilder(getZeroPaddedString(valueAsBitString, 31)); // one less for the sign bit
                Reverse(sb);
                sb.Insert(0, '0'); // make sure sign bit is 0
                // pad with zeroes to get a 64 bit string
                string reversedAndPaddedValueAsBitAString = getZeroPaddedString(sb.ToString(), 64);
                long obfuscated = Convert.ToInt64(reversedAndPaddedValueAsBitAString, 2);
                obfuscated = obfuscated ^ this.obfuscationValueForXOR;
                int result = (int)obfuscated;
                return result;
            }

            public virtual int getUnobfuscated(int obfuscated)
            {
                long asLong = obfuscated;
                asLong = asLong ^ this.obfuscationValueForXOR;
                string reversedValueAsBinaryString = Convert.ToString(asLong) + '0'; // extra 0 for sign bit after reversal
                string reversedAndPaddedValueAsBitString = getZeroPaddedString(reversedValueAsBinaryString, 32);
                StringBuilder sb = new StringBuilder(reversedAndPaddedValueAsBitString);
                Reverse(sb);
                string valueAsBitString = getZeroPaddedString(sb.ToString(), 64);
                long value = Convert.ToInt64(valueAsBitString, 2);
                int result = (int)value;
                return result;
            }

            private static void Reverse(StringBuilder text)
            {
                if (text.Length > 1)
                {
                    int pivotPos = text.Length / 2;
                    for (int i = 0; i < pivotPos; i++)
                    {
                        int iRight = text.Length - (i + 1);
                        char rightChar = text[i];
                        char leftChar = text[iRight];
                        text[i] = leftChar;
                        text[iRight] = rightChar;
                    }
                }
            }
        }
    
}
