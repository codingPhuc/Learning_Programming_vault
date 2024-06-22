
An **AutoMapper** is a class or a function that inherits from the AutoMapper profile function. Its purpose is to enhance code readability. With AutoMapper, a domain object can be converted into a DTO (Data Transfer Object) with just one line of code.

Here are the steps to create an AutoMapper:

1. **Download the library**: This is the first step where you add the AutoMapper library to your project.
    
2. **Create an AutoMapper class**: This class will inherit from the Profile class provided by AutoMapper.
    
3. **Initialize the AutoMapper**: When the program first starts, add a line to build the AutoMapper.
    

Here’s an example of an AutoMapper class:

```csharp
using AutoMapper;
using NZWalksAPI.Models.Domain;
using NZWalksAPI.Models.DTO;

namespace NZWalksAPI.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        { 
            CreateMap<Region, RegionDTO>().ReverseMap(); 
            CreateMap<AddRegionRequestDto , Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDTo, Region>().ReverseMap();
        }
    }
}
```

In the startup configuration, add this line to initialize the AutoMapper:

```csharp
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
```
