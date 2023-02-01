// See https://aka.ms/new-console-template for more information

string str1 = "TAUXXTAUXXTAUXXTAUXXTAUXX";
string str2 = "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX";
Solution s = new Solution();
var ans = s.GcdOfStrings(str1, str2);
Console.WriteLine(ans);


public class Solution
{
  public string GcdOfStrings(string str1, string str2)
  {
    var n1 = str1.Length;
    var n2 = str2.Length;
    var temp = n2;
    if (n1 < n2)
    {
      return GcdOfStrings(str2, str1);
    }
    // O(Min(N, M) * K)
    while (n2 > 0)
    {
      if (n1 % n2 == 0)
      {
        int size = n1 / n2;
        string target = str2.Substring(0, n2);
        string str = "";
        for (int i = 1; i <= size; i++)
        {
          str += target;
        }
        if (str1 == str)
        {
          var tLength = target.Length;
          if (temp % tLength == 0)
          {
            var tsize = temp / tLength;
            str = "";
            for (int i = 1; i <= tsize; i++)
            {
              str += target;
            }
            if (str == str2)
              return target;
          }
        }
      }
      n2--;
    }

    return "";
  }
}