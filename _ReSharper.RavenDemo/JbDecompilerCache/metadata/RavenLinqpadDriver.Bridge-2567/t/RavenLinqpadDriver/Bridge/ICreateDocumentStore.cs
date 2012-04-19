// Type: RavenLinqpadDriver.Bridge.ICreateDocumentStore
// Assembly: RavenLinqpadDriver.Bridge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=585b2b0c3c4c2d89
// Assembly location: Z:\Code\RavenDemo\packages\RavenDB-Linqpad-Driver-Bridge.1.0.0-alpha\lib\net40\RavenLinqpadDriver.Bridge.dll

using Raven.Client;

namespace RavenLinqpadDriver.Bridge
{
    public interface ICreateDocumentStore
    {
        IDocumentStore CreateDocumentStore(ConnectionInfo connectionInfo);
    }
}
