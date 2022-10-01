using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Infrastructure
{
    public static class IsTypePaper
    {
        public static bool CheckType(Type typeForValidation)
        {
            foreach (var type in PaperConsts.ValidPaperTypes)
            {
                if (typeForValidation == type)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
