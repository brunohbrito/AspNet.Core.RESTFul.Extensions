﻿using System;
using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;

namespace RESTFul.Api.ViewModels
{
    public class UserSearch : IQuerySort, IQueryPaging
    {
        public string Username { get; set; }

        [QueryOperator(Operator = WhereOperator.GreaterThan)]
        public DateTime? Birthday { get; set; }

        [QueryOperator(Operator = WhereOperator.Contains, HasName = "Firstname")]
        public string Name { get; set; }

        public int Offset { get; set; }
        public int Limit { get; set; } = 10;
        public string Sort { get; set; }
    }

}
