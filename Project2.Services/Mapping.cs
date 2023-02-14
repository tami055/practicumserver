using AutoMapper;
using project2.Entities;
using Project2.Common.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<User,DTOSUser>().ReverseMap();
            CreateMap<Child, DTOSChild>().ReverseMap();
        }

    }
}
