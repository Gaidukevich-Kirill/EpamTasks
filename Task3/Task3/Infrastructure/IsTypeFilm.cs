using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Infrastructure
{
    public static class IsTypeFilm
    {
        public static bool CheckType(Type typeForValidation)
        {
            foreach (var type in FilmConsts.ValidFilmTypes)
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
