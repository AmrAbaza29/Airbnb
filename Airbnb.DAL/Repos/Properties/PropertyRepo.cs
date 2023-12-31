﻿namespace Airbnb.DAL;

public class PropertyRepo:GenericRepo<Property>, IPropertyRepo
{
    private readonly RentContext _rentContext;

    public PropertyRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }

    void IPropertyRepo.Add(Property property)
    {
        _rentContext.Set<Property>().Add(property);
    }
    void IPropertyRepo.Update(Property property)
    {
    }

    void IPropertyRepo.Delete(Property property)
    {
        _rentContext.Set<Property>().Remove(property);
    }



    IEnumerable<Property> IPropertyRepo.GetAllProperties()
    {
        return _rentContext.Set<Property>().ToList(); ;
    }

    Property? IPropertyRepo.GetPropertyById(string id)
    {
        return _rentContext.Set<Property>().Find(id);
    }

    int IPropertyRepo.SaveChanges()
    {
        return _rentContext.SaveChanges();
    }

   
}
