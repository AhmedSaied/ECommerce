﻿namespace ECommerce.Core.Entities.Product;

public class Category : BaseEntity<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
}
