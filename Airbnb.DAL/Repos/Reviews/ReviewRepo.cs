﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class ReviewRepo:GenericRepo<UserReviewProperty>,IReviewRepo
{
    private readonly RentContext _rentContext;

    public ReviewRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }

    public IEnumerable<UserReviewProperty> GetAllReviews()   // GetAll
    {
        return _rentContext.Set<UserReviewProperty>().ToList();
    }

    public UserReviewProperty? GetReviewsById(string PropertyId, string UserId,Guid Id)              //GetById
    {
        return _rentContext.Set<UserReviewProperty>().Find(PropertyId, UserId,Id);
    }

    public void Add (UserReviewProperty userReviewProperty)         //Add
    {
        _rentContext.Set<UserReviewProperty>().Add(userReviewProperty);
    }

    public void Update(UserReviewProperty userReviewProperty)       //Update
    {

    }
    public void Delete (UserReviewProperty userReviewProperty)              //Delete
    {
        _rentContext.Set<UserReviewProperty>().Remove(userReviewProperty);
    }

    public int SaveChanges()
    {
        return _rentContext.SaveChanges();
    }

   
    public UserReviewProperty? GetReviewsByIdForUpdateAndDelete(string PropertyId, string UserId,Guid Id)
    {
        return _rentContext.Set<UserReviewProperty>().Find(PropertyId, UserId,Id);
    }
}
