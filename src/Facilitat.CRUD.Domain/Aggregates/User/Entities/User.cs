﻿using System;

namespace Facilitat.CRUD.Domain.Aggregates.User.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
    }
}