bool IsPalindrome(string str)
{
    string rev = new string(str.Reverse().ToArray());
    return str == rev;
}
