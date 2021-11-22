using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        #region
        public static List<int> ReturnSquareRoot(List<int> numbers)
        {
            return numbers.Select(x => (int)Math.Sqrt(x)).ToList(); //+
        }

        public static List<int> GetAgeFromUsers(List<User> users)
        {
            return users.Select(x => x.Age).ToList(); //+
        }

        public static List<int> GetDistinctAges(List<User> users)
        {
            return users.Select(x => x.Age).Distinct().ToList(); //+
        }

        public static List<User> GetLimitedUserList(List<User> users, int limit)
        {
          
            return users.Take(limit).ToList(); //+
        }

        public static int CountUsersOlderThen25(List<User> users)
        {
          return users.Where(x => x.Age > 25).Count(); //+
        }

        public static List<string> MapToUpperCase(List<string> strings)
        {
          return strings.Select(s => s.ToUpper()).ToList(); //+
        }

        public static int Sum(List<int> integers)
        {
          return integers.Sum(); //+
        }

        public static List<int> Skip(List<int> integers, int toSkip)
        {
          return integers.Skip(toSkip).ToList(); //+
        }

        public static List<string> GetFirstNames(List<string> names)
        {
          return names.Select(x => x.Substring(0, x.IndexOf(" "))).ToList(); //+
        }
        #endregion
        public static List<string> GetDistinctLetters(List<string> names)
        {
          return null;
          //return names.Select(x => x.Select(y => y.ToCharArray().ToString())).ToList();
        }

        public static string SeparateNamesByComma(List<User> users)
        {
            return null;
            //return users.Select(x => (string)x.Name).ToList().TakeWhile((fruit, index) => fruit.Length >= index);
        }
        #region
        public static double GetAverageAge(List<User> users)
        {
          return users.Select(x => x.Age).Average(); //+
        }

        public static int GetMaxAge(List<User> users)
        {
            return users.Select(x => x.Age).Max(); //+
        }

        public static int GetMinAge(List<User> users)
        {
            return users.Select(x => x.Age).Min(); //+
        }
        #endregion
        public static Dictionary<bool, List<User>> PartionUsersByGender(List<User> users)
        {
            return users.GroupBy(u => u.IsMale).ToDictionary(x => x.Key, x => x.ToList());
        }

        public static Dictionary<int, List<User>> GroupByAge(List<User> users)
        {
            return users.GroupBy(u => u.Age).ToDictionary(x => x.Key, x => x.ToList());
        }

        public static Dictionary<bool, int> CountGender(List<User> users)
        {
            return null;
            //return users.GroupBy(u => u.IsMale).ToDictionary(x => x.Key, x => x.GroupBy(u => u.IsMale).Count());
        }

        public static bool AnyMatch(List<User> users, int age)
        {
            //return false;
            return users.Select(x => (int)x.Age).Equals(age);
        }

        public static bool NoneMatch(List<User> users, int age)
        {
          return false;
        }

        public static User FindAny(List<User> users, string name)
        {
          return null;
        }

        public static List<User> SortByAge(List<User> users)
        {
          return users.OrderBy(x => x.Age).ToList();
        }

        public static List<int> GenerateFirst10PrimeNumbers()
        {
          return null;
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number)+double.Epsilon; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static List<int> Generate10RandomNumbers()
        {
            var rnd = new Random();
            return null;
        }

        public static User FindOldest(List<User> users)
        {
            return null;
            //return users.Where(x => x.Age);
        }

        public static int SumAge(List<User> users)
        {
            return users.Sum(x => x.Age);
        }

    }
}
