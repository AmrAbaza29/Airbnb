﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class UserReserveProperty
{
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }

    //Navigational Property
    public string UserId { get; set; } = string.Empty;
    public string PropertyId { get; set; } = string.Empty;
    public User? User { get; set; }
    public Property? Property { get; set; }
}
