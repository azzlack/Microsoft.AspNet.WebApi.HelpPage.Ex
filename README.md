Microsoft.AspNet.WebApi.HelpPage.Ex
===================================

Extensions for Microsoft ASP.NET Web API Help Pages

#### Features
* Show controllers and methods using `Authorize` attribute on documentation page
* Properly support tags like `<c>`, `<code>`, `<para>`, `<example>`, `<exception>`, `<paramref>`, `<see>`, `<seealso>`, `<typeparamref>`

#### Usage
1. Install the NuGet package, and overwrite all files when asked.
2. Open Properties for your web api project, and select the `Build` tab. Under `Output`, check `XML documentation file`. In the edit box, type `App_Data/XmlDocument.xml`.
3. Open the `Areas\HelpPage\HelpPageConfig.cs` file and change the following line:
        //config.SetDocumentationProvider(new XmlDocumentationProvider(HttpContext.Current.Server.MapPath("~/App_Data/XmlDocument.xml")));
    to
        config.SetDocumentationProvider(new MultipleXmlDocumentationProvider(HttpContext.Current.Server.MapPath("~/App_Data/XmlDocument.xml")));
4. Document your controller and models using [standard .NET documentation comments](http://msdn.microsoft.com/en-us/library/5ast78ax.aspx)
5. For more advanced stuff, follow the guide at http://www.asp.net/web-api/overview/creating-web-apis/creating-api-help-pages