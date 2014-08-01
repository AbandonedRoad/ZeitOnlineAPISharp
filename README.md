ZeitOnlineAPISharp
==================

C# Wrapper for ZEIT ONLINE Content API (http://developer.zeit.de/index/)

Status
==================
Not all endpoints are currently added. If you need to consume an endpoint I haven't added, feel free to open an issue.

Dependencies
==================
ZeitOnlineAPISharp uses Json.Net via NuGet

Usage
==================
```
ZeitOnlineAPISharp.API api = new ZeitOnlineAPISharp.API("YOUR API KEY");

ZeitOnlineAPISharp.Endpoints.KeywordEndpoint keywordEndpoint = new ZeitOnlineAPISharp.Endpoints.KeywordEndpoint(api);
var response = keywordEndpoint.Query("gaza");

ZeitOnlineAPISharp.Endpoints.ContentEndpoint contentEndpoint = new ZeitOnlineAPISharp.Endpoints.ContentEndpoint(api);
var contentResponse = contentEndpoint.Query(response.Matches[0].UUID);

ZeitOnlineAPISharp.Endpoints.ClientEndpoint clientEndpoint = new ZeitOnlineAPISharp.Endpoints.ClientEndpoint(api);
var clientResponse = clientEndpoint.Query();


ZeitOnlineAPISharp.Endpoints.DepartmentEndpoint departmentEndpoint = new ZeitOnlineAPISharp.Endpoints.DepartmentEndpoint(api);
var departmentReponse = departmentEndpoint.Query("politik");
```

The wrappers uses a small waiting period of _API.WaitPeriodMilliseconds_ between multiple requests.
You can set the _API.LimitRate_ property to _true/false_, depending on whether you want to use wait between multiple requests.
