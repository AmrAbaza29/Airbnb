﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class Image
{
    public Guid Id { get; set; }
    public string URL { get; set; } = string.Empty;

    //Nav Props and FKeys

    public string? UserId { get ; set; }   
    public string? PropertyId { get; set; }
    public Guid? AmenityId { get; set; }
    public Guid? RuleId { get; set; }    

    public User? User { get; set; }
    public Property? Property { get; set; }
    public Amenity? Amenity { get; set; }
    public Rule? Rule { get; set; }
}
