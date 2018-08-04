using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static AutoMapper.IMapper Mapping;
        public static void RegisterAutoMappers()
        {
            Mapping = new MapperConfiguration(config =>
            {
                config.CreateMap<Post, PostViewModel>();
                config.CreateMap<Tag, TagViewModel>();
                config.CreateMap<PostTag, PostTagViewModel>();
            }).CreateMapper();
        }
    }
}