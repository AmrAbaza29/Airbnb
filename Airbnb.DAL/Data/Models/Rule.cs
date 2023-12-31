﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class Rule
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Picture { get; set; } = string.Empty;

    //navprops
    public ICollection<PropertyRule> PropertyRules { get; set; }=new HashSet<PropertyRule>();
    public Image? Img { get; set; }

}
