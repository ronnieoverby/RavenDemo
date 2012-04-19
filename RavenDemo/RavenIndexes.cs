using Raven.Abstractions.Indexing;
using Raven.Client.Indexes;
using Raven.Client;
namespace RavenDemo
{
    internal static class RavenIndexes
    {
        public static void CreateIndexes(this IDocumentStore ds)
        {
            IndexCreation.CreateIndexes(typeof (RavenIndexes).Assembly, ds);
        }

        public class Everything : AbstractIndexCreationTask
        {
            public override IndexDefinition CreateIndexDefinition()
            {
                return new IndexDefinition
                {
                    Map = "from d in docs select new {}"
                };
            }
        }
    }
}