public partial class Solution
{
    public string ReverseString(string s)
    {
        var c = s.ToCharArray();
        for (var i = 0; i < c.Length / 2; i++)
        {
            var tmp = c[i];
            c[i] = c[c.Length - i - 1];
            c[c.Length - i - 1] = tmp;
        }
        return new string(c);
    }
}