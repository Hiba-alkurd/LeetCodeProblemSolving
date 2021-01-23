namespace DefaultNamespace
{
    public class main
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if(strs.Length == 0) return "";
        
            string common = strs[0];
            bool found = false;
            foreach (var word in strs)
            {
                var subString = word;
                found = false;
                
                if (common == "") return common;
                
                while (!found && common!="")
                {
                    if (common == subString) found = true;
                    else if (common.Length > subString.Length) common = common.Remove(subString.Length);
                    else if (common.Length < subString.Length) subString = subString.Remove(common.Length);
                    else
                    {
                        common = common.Remove(common.Length - 1);
                        subString = subString.Remove(subString.Length - 1);
                    }
                    found = (common == subString);
                }
            }
            return common;
        }
    }
}