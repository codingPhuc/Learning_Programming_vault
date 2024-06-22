its kind of wide topic, and not only focused on the services/application itself but goes higher to infrastructure level. perhaps normal route (for Azure/C#) would be:

1. enable WAF as soon as possible for your project
    
2. design APIs to survive all WAF warnings and rejections (hardest part that why you will want to it enabled as soon as possible)
    
3. use standard net core authorization/authentication libraries and try not to override much of it configuration (i.e. addJwtBearer(), addOpenIdConnect()).
    
4. figure out best addDataProtection() configuration for your case (depends on how services are scaled, deployed etc)
    
5. preferably use API gateway and setup rate limiting there
    
6. use normal static models in your APIs (not raw JSON), and set viable validation limits via validation - [https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-7.0#validation-attributes](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-7.0#validation-attributes)


https://owasp.org/www-project-top-ten/