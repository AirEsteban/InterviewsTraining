using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsCode.TwoSum
{
    internal class TwoSum
    {
        public static int[] DoTwoSum(int[] nums, int target)
        {
            var numsAux = new Dictionary<int, int>();
            var arrReturn = new List<int>();

            // Doing some math and saving into a hashmap/dictionary
            for (var i = 0; i < nums.Length; i++)
            {
                if (!numsAux.ContainsKey(target - nums[i]))
                {
                    numsAux.Add(target - nums[i], i);
                }
            }

            // Getting the result
            for(var i = 0; i < nums.Length; i++){
                    if(numsAux.ContainsKey(nums[i]) && i != numsAux[nums[i]]){
                        arrReturn.Add(i);
                        arrReturn.Add(numsAux[nums[i]]);
                        break;
                    }
            }
            // Print output in console
            foreach(var result in arrReturn)
            {
                Console.WriteLine(result);
            }

            return arrReturn.ToArray();
        }
    }
}
