﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Infrastructure
{
    public static class IsTypePlastic
    {
        public static bool CheckType(Type typeForValidation)
        {
            foreach (var type in PlasticConsts.ValidPlasticTypes)
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
