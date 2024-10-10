using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace BinaryEvaluator
{
    public static class BinaryEvaluatorClass
    {
        
        public static string ValidateBinaryString(string binaryString)
        {
           Dictionary<char, int> bitsCountMap = new Dictionary<char, int>()
            {
                { '0', 0},
                { '1', 0}
            };
            foreach (char c in binaryString) 
            {
                bitsCountMap[c]++;

                if (bitsCountMap['0'] > bitsCountMap['1'])
                    return Constants.Bad;
            }

            return bitsCountMap['0'] == bitsCountMap['1'] ? Constants.Good : Constants.Bad;
        }
        public static bool IsBinaryString(string? input) => 
            !string.IsNullOrEmpty(input) && input.All(c => c == '0' || c == '1');
    }
}
