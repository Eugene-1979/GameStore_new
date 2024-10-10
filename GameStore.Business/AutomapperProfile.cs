using AutoMapper;

using GameStore.Business.Models;
using GameStore.Data.Entities;
using System.Linq;

namespace GameStore.Business
    {
    public class AutomapperProfile : Profile
        {
        public AutomapperProfile()
            {


            CreateMap<Game, GameModel>().ReverseMap();
            CreateMap<Genre, GenreModel>().ReverseMap();
            CreateMap<Platform, PlatformModel>().ReverseMap();


/*
            CreateMap<ProductCategory, ProductCategoryModel>()
          .ForMember(rm => rm.ProductIds, r => r.MapFrom(x => x.Products.Select(q => q.Id)))
          .ReverseMap();


            CreateMap<Product, ProductModel>()
            .ForMember(rm => rm.ReceiptDetailIds, r => r.MapFrom(x => x.ReceiptDetails.Select(rd => rd.Id))).
             ForMember(rm => rm.CategoryName, r => r.MapFrom(x => x.Category.CategoryName))
             .ReverseMap();


            CreateMap<ReceiptDetail, ReceiptDetailModel>().
            ReverseMap();


            CreateMap<(Customer, Person), CustomerModel>().
            ForMember(rm => rm.Name, r => r.MapFrom(x => x.Item2.Name)).
            ForMember(rm => rm.Surname, r => r.MapFrom(x => x.Item2.Surname)).
            ForMember(rm => rm.BirthDate, r => r.MapFrom(x => x.Item2.BirthDate)).
            ForMember(rm => rm.DiscountValue, r => r.MapFrom(x => x.Item1.DiscountValue)).
            ForMember(rm => rm.ReceiptsIds, r => r.MapFrom(x => x.Item1.Receipts.Select(rd => rd.Id))).
            ForMember(rm => rm.Id, r => r.MapFrom(x => x.Item1.Id)).
            ForMember(rm => rm.Person, r => r.MapFrom(x => x.Item1.Person)).
            ForMember(rm => rm.Receipts, r => r.MapFrom(x => x.Item1.Receipts))
           .ReverseMap();

            CreateMap<Customer, CustomerModel>().
        ForMember(rm => rm.Id, r => r.MapFrom(x => x.Id)).
         ForMember(rm => rm.DiscountValue, r => r.MapFrom(x => x.DiscountValue)).
         ForMember(rm => rm.Person, r => r.MapFrom((x, z) => new Person()
             {
             Name = z.Name,
             Surname = z.Surname,
             BirthDate = z.BirthDate

             }))
         .ReverseMap();


            CreateMap<Person, CustomerModel>().
            ForMember(rm => rm.Name, r => r.MapFrom(x => x.Name)).
            ForMember(rm => rm.Surname, r => r.MapFrom(x => x.Surname)).
            ForMember(rm => rm.BirthDate, r => r.MapFrom(x => x.BirthDate)).
            ReverseMap();

            CreateMap<Receipt, ReceiptModel>()
             .ForMember(rm => rm.ReceiptDetailsIds, r => r.MapFrom(x => x.ReceiptDetails.Select(rd => rd.Id))).
             ReverseMap();


            CreateMap<Customer, CustomerModel>().
            ForMember(rm => rm.Name, r => r.MapFrom(x => x.Person.Name)).
            ForMember(rm => rm.Surname, r => r.MapFrom(x => x.Person.Surname)).
            ForMember(rm => rm.BirthDate, r => r.MapFrom(x => x.Person.BirthDate)).
            ForMember(rm => rm.ReceiptsIds, r => r.MapFrom(x => x.Receipts.Select(q => q.Id))).
            ForMember(rm => rm.Person, r => r.Ignore()).
            ForMember(rm => rm.Receipts, r => r.Ignore()).
            ReverseMap();*/

            }
        }
    }