using AutoMapper;
using BookAPI.Data;
using BookAPI.Models;

namespace BookAPI.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            // Map instances of Book to BookModel and vice versa
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
