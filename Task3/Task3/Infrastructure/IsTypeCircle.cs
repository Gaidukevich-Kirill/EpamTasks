using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Infrastructure
{
    public static class IsTypeCircle
    {
        public static bool CheckType(Type typeForValidation)
        {
            foreach (var type in CircleConsts.ValidCircleTypes)
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
