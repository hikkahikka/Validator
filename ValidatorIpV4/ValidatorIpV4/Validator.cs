using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidatorIpV4
{
    /// <summary>
    /// класс, проверяющий валидность IP
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// паттерн IP
        /// </summary>
        private readonly static string _IPv4Pattern = @"^(([0-9]|[1-9][0-9]|1[0-9][0-9]|2[1-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9][0-9]|2[1-4][0-9]|25[0-5])$";




        /// <summary>
        /// проверка IP адреса
        /// </summary>
        /// <param name="IP">строка IP из IPtextBox</param>
        /// <returns>валидный ли IP</returns>
        public static bool ValidateIP(string? IP)
        {
            Regex regex = new Regex(_IPv4Pattern);
            MatchCollection matches = regex.Matches(IP);

            if (matches.Count == 1)
            {
                return true;

            }
            
            return false;
                
        }


       
    }
}