namespace Pizza
{
    public class HelpFinding
    {
        public string FindingCommaOrPeriodAndCuttingCharacters(string sideDishes)
        {
            int index = FindIndexCommaOrPeriod(sideDishes);
            return ReturningCutWord(index, sideDishes);
        }

        private int FindIndexCommaOrPeriod(string sideDishes)
        {
            int index = sideDishes.IndexOf(",");
            if (index == -1)
            {
                index = sideDishes.IndexOf(".");
            }
            return index;
        }

        private string ReturningCutWord(int index, string sideDishes)
        {
            if (index == -1)
            {
                return "";
            }
            else
            {
                return sideDishes.Substring(0, index);
            }
        }

        public string RemoveSideDishAndWhiteSigns(string sideDish)
        {
            int index = FindIndexCommaOrPeriod(sideDish);
            sideDish = sideDish.Remove(0, index + 1);
            return sideDish.Trim();
        }

        public string CheckIsNotNull(string str)
        {
            if (string.IsNullOrEmpty(str)) return str = "";
            else return str;
        }

        public bool CheckStringIsNotEmpty(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            else return true;
        }

        public bool CheckStringIsEmpty(string text)
        {
            if (string.IsNullOrEmpty(text)) return true;
            else return false;
        }
    }
}
