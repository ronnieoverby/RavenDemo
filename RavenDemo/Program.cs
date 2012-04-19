using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client;
using RavenLinqpadDriver.Bridge;
using MvcMusicStore.Models;

namespace RavenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDocumentStore ds;

            //var dsc = new MyDocStoreCreator();

            //using (ds = dsc.CreateDocumentStore(new ConnectionInfo { Url = "http://localhost:8080" }))
            //{
            //    using (var s = ds.OpenSession())
            //    {
            //        var albums = s.Query<Album>();
            //        foreach (var album in albums)
            //        {
            //            Console.WriteLine(album.Title);
            //        }
            //    }
            //}

            //Console.ReadKey();
        }
    }
}
