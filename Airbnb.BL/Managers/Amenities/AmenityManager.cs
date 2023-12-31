﻿
using Airbnb.BL.Dtos.Amenities;
using Airbnb.DAL;

namespace Airbnb.BL.Managers.Amenities
{
    public class AmenityManager : IAmenityManager
    {
        private readonly IAmenityRepo _amenityRepo;

        public AmenityManager(IAmenityRepo amenityRepo)
        {
            _amenityRepo = amenityRepo;
        }
        public IEnumerable<AmenityReadDto> GetAll()
        {
            IEnumerable<Amenity> amenityFromDb = _amenityRepo.GetAll();
            return amenityFromDb.Select(A => new AmenityReadDto
            {
                Id = A.Id,
                Name = A.Name,
                Picture = A.Picture

            });
        }
    

        public AmenityReadDto? GetAmenityById(Guid id)
        {
            Amenity? AmenityFromDb = _amenityRepo.GetAmenityById(id);
            if (AmenityFromDb == null)
            {
                return null;
            }
            return new AmenityReadDto
            {
                Id = AmenityFromDb.Id,
                Picture = AmenityFromDb.Picture,
                Name = AmenityFromDb.Name
            };
        }
        public Guid Add(AmenityAddDto AmenityFromRequest )
        {
            Amenity amenity = new Amenity
            {
                Id = AmenityFromRequest.Id,
                Name = AmenityFromRequest.Name,
                Picture = AmenityFromRequest.Picture
            };
            _amenityRepo.Add(amenity);
            _amenityRepo.SaveChanges();
            return amenity.Id;


        }
        public bool Update(AmenityUpdateDto amenityFromRequest)
        {
            Amenity? amenity = _amenityRepo.GetAmenityById(amenityFromRequest.Id );
            if (amenityFromRequest == null)
            {
                return false;
            }
            amenityFromRequest.Picture=amenity.Picture;
            amenityFromRequest.Name = amenity.Name;
            _amenityRepo.Update(amenity);
            _amenityRepo.SaveChanges();
            return true;
        }

        public bool Delete(Guid Id )
        {
            Amenity? amenity = _amenityRepo.GetAmenityById(Id );
            if (amenity == null)
            {
                return false;
            }
            _amenityRepo.Delete(amenity);

            _amenityRepo.SaveChanges();
            return true;
        }

       
    }
}
