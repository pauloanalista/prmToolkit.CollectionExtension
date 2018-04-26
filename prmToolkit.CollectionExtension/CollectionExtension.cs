using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace prmToolkit.CollectionExtension
{
    public static class CollectionExtension
    {
        public static IEnumerable<IEnumerable<T>> SplitCollection<T>(this IEnumerable<T> source, int recordCount)
        {
            if (source == null || recordCount == 0)
            {
                throw new Exception("É obrigatório passar uma coleção e definir a quantidade de registros em que deseja paginar.");
            }

            using (var enumerator = source.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var currentPage = new List<T>(recordCount){
                        enumerator.Current
                    };

                    while (currentPage.Count < recordCount && enumerator.MoveNext())
                    {
                        currentPage.Add(enumerator.Current);
                    }
                    yield return new ReadOnlyCollection<T>(currentPage);
                }
            }
        }
    }
}
