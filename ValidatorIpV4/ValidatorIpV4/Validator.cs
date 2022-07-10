using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidatorIpV4
{

    public class Validator
    {
        private readonly static string _IPv4Pattern= @"(\d{1,3}\.){3}\d{1,3}$";
        

        public static bool ValidateIP(string? IP)
        {
            Regex regex = new Regex(_IPv4Pattern);
            MatchCollection matches = regex.Matches(IP);

            if (matches.Count == 1)
            {
                return CheckToMaximumAllowableValue(GetValuesOfIP(IP));

            }
            
            return false;
                
        }

        private static int[] GetValuesOfIP(string? IP)
        {
            
            string[] values = new string[4];
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0;;)
                {

                    if (String.IsNullOrEmpty(IP))
                        break;
                    if (IP[i] != '.')
                    {
                        values[j] += IP[i];
                        IP=IP.Remove(i,1);
                    }
                    else
                    {
                        IP = IP.Remove(i,1);

                        break;
                    }
                }
            }
            int[] rightValues = new int [4];
            for (int i = 0; i < rightValues.Length;i++)
            {
                rightValues[i] = Convert.ToInt32(values[i]);
            }

            return rightValues;
        }

        private static bool CheckToMaximumAllowableValue(int[] values)
        {
            bool result = true;

            for(int i = 0; i < values.Length; i++)
            {
                if (values[i] > 255)
                {
                    result = false;
                    break;
                }
                  
            }

            return result;
        }
    }
}