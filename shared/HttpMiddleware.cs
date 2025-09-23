using System.Net;
using System.Collections;
namespace SimpleMDB;

public delegate Task HttpMiddleware(HttpListenerRequest req, HttpListenerResponse res, Hashtable options);