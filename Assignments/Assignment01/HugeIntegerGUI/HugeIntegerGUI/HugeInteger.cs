using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugeIntegerGUI {
    class HugeInteger {

        private const int INT_LENGTH = 40;
        private int[] integer;

        public HugeInteger()
        {
            integer = new int[INT_LENGTH];
        }

        public void Input(string input)
        {
            char[] intChar = input.ToCharArray();

            for (int i = 0; i < intChar.Length; i++)
            {
                integer[INT_LENGTH - intChar.Length + i] = intChar[i] - '0';
            }
        }

        public HugeInteger Add(HugeInteger value)
        {
            int carry = 0;
            HugeInteger result = new HugeInteger();

            for (int i = integer.Length - 1; i >= 0; i--)
            {
                if (integer[i] + value.integer[i] + carry >= 10)
                {
                    result.integer[i] = (integer[i] + value.integer[i] + carry) % 10;
                    carry = 1;
                }
                else
                {
                    result.integer[i] = integer[i] + value.integer[i] + carry;
                    carry = 0;
                }
            }

            return result;
        }

        public HugeInteger Subtract(HugeInteger value)
        {
            HugeInteger temp = new HugeInteger();

            for (int i = integer.Length - 1; i >= 0; i--)
            {
                if (integer[i] < value.integer[i])
                {
                    integer[i] += 10;

                    if (i - 1 >= 0)
                        integer[i - 1]--;
                }

                temp.integer[i] = integer[i] - value.integer[i];
            }

            return temp;
        }

        public HugeInteger Multiply(HugeInteger value)
        {
            HugeInteger result = new HugeInteger();
            HugeInteger counter = new HugeInteger();
            HugeInteger addOne = new HugeInteger();
            addOne.Input("1");

            for (HugeInteger i = counter; i.IsLessThan(value); i = i.Add(addOne))
            {
                result = result.Add(this);
            }

            return result;
        }

        public HugeInteger Divide(HugeInteger value)
        {
            HugeInteger result = new HugeInteger();
            HugeInteger divideValue = value;
            HugeInteger originalValue = this;
            HugeInteger addOne = new HugeInteger();
            addOne.Input("1");

            while (originalValue.IsLessThanOrEqualTo(divideValue))
            {
                if (originalValue.IsEqual(divideValue))
                {
                    result = result.Add(addOne);
                    return result;
                }
                else
                {
                    result = result.Add(addOne);
                    originalValue = originalValue.Subtract(divideValue);
                }
            }

            return result;
        }

        public HugeInteger Remainder(HugeInteger value)
        {
            HugeInteger temp = new HugeInteger();

            return temp;
        }

        public bool IsEqual(HugeInteger values)
        {
            for (int i = 0; i < INT_LENGTH; i++)
            {
                if (integer[i] != values.integer[i])
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsLessThan(HugeInteger values)
        {
            if (this.integer.Length < values.integer.Length)
            {
                return true;
            }
            if (this.integer.Length > values.integer.Length)
            {
                return false;
            }

            for (int i = integer.Length - 1; i >= 0; i--)
            {
                if (this.integer[i] < values.integer[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsLessThanOrEqualTo(HugeInteger values)
        {
            if (this.integer.Length <= values.integer.Length)
            {
                return true;
            }
            if (this.integer.Length >= values.integer.Length)
            {
                return false;
            }

            for (int i = integer.Length - 1; i >= 0; i--)
            {
                if (this.integer[i] <= values.integer[i])
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string outputNum = "";
            bool isAtFirstNumber = false;
            for (int i = 0; i < 40; i++)
            {
                if (integer[i] != 0)
                    isAtFirstNumber = true;

                if (isAtFirstNumber)
                    outputNum += integer[i];
            }
            return outputNum.Equals("") ? "0" : outputNum;
        }
    }
}
