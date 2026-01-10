using System;
using System.Collections.Generic;
using System.Linq;

namespace DialingCodesApp
{
    public static class DialingCodes
    {

        // Task 1
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        // Task 2
        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string>
            {
                { 1, "United States of America" },
                { 55, "Brazil" },
                { 91, "India" }
            };
        }

        // Task 3
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var dict = new Dictionary<int, string>();
            dict[countryCode] = countryName;
            return dict;
        }

        // Task 4
        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }

        // Task 5
        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                return existingDictionary[countryCode];
            }
            return "";
        }

        // Task 6
        public static bool CheckCodeExists(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        // Task 7
        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
                existingDictionary[countryCode] = countryName;

            return existingDictionary;
        }

        // Task 8
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        // Task 9
        public static string FindLongestCountryName(
            Dictionary<int, string> existingDictionary)
        {
            if (existingDictionary.Count == 0) return "";
            string longest="";
            foreach(var i in existingDictionary.Values)
            {
                if (i.Length > longest.Length)
                {
                    longest=i;
                }
            }
            return longest;
        }
    }
}
