using Raven.Client;
using Raven.Client.Document;
using RavenLinqpadDriver.Bridge;
using Raven.Client.Indexes;

namespace RavenDemo
{
    public class MyDocStoreCreator : ICreateDocumentStore
    {
        public IDocumentStore CreateDocumentStore(ConnectionInfo connectionInfo)
        {
            var ds = new DocumentStore
                         {
                             Url = connectionInfo.Url
                         };
            try
            {
                //ds.Initialize();

                //IndexCreation.CreateIndexes(GetType().Assembly, ds);

                return ds;
            }
            catch (System.Exception)
            {
                ds.Dispose();
                throw;
            }
        }
    }
}