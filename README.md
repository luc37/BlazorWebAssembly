# BlazorWebAssembly
Welcome to the Pokemon Blazor Web Assembly!

This is a simple application built using C#, .Net 8, Blazor and uses the Blazorize.Material UI component library.
This site is currently hosted on the Google Cloud until April 11, 2024.

The goal of this project has been to create a simple Blazor application quickly to explore some of the features of the technology.
Rather that create a new WebApi for this site a public API has been used. This has had some performance issues, as this API does 
not provide much data in any LIST calls. Thus, in the source control there are places where I have had to make many API calls 
get the data we need. <br /><br />

See below the following links <br />

C#: https://learn.microsoft.com/en-us/dotnet/csharp/
.Net 8: https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8
Blazor: https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor
Blazorise: https://blazorise.com/
Pokemon API: https://pokeapi.co/docs/v2#pokemon
GoogleCloud: https://cloud.google.com/

The source control for the project is found on Github: https://github.com/luc37/BlazorWebAssembly

Current Deployment:
Publish to Google Cloud buckets. 
Run a file publish in VS 2022.
Copy files and folders to the bucket.

Live site:
blazor.dexterdevelopment.uk

Current issues:
Loading a page via URL return an XML page.