using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.DestinationDTOs;
using EntityLayer.Concrete;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile 
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTO, Announcement>();
            CreateMap<Announcement, AnnouncementAddDTO>();

            CreateMap<AnnouncementUpdateDTO, Announcement>();
            CreateMap<Announcement, AnnouncementUpdateDTO>();


            CreateMap<AnnouncementListDTO, Announcement>();
            CreateMap<Announcement, AnnouncementListDTO>();

            CreateMap<AppUserRegisterDTO, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTO>();

            CreateMap<AppUserLoginDTO, AppUser>();
            CreateMap<AppUser, AppUserLoginDTO>();

            CreateMap<DestinationAddDTO, Destination>();
            CreateMap<Destination, DestinationAddDTO>();

        }
    }
}
